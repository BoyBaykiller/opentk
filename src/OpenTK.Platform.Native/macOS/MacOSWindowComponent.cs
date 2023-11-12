﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSWindowComponent : IWindowComponent
    {
        internal static IntPtr nsApplication;

        internal static readonly SEL selQuit = sel_registerName("quit"u8);
        internal static SEL selSharedApplication = sel_registerName("sharedApplication"u8);
        internal static SEL selSetActivationPolicy = sel_registerName("setActivationPolicy:"u8);
        internal static SEL selDiscardEventsMatchingMask_beforeEvent = sel_registerName("discardEventsMatchingMask:beforeEvent:"u8);
        internal static SEL selMainMenu = sel_registerName("mainMenu"u8);

        internal static SEL selType = sel_registerName("type"u8);
        internal static SEL selSendEvent = sel_registerName("sendEvent:"u8);
        internal static SEL selNextEventMatchingMask_untilDate_inMode_dequeue = sel_registerName("nextEventMatchingMask:untilDate:inMode:dequeue:"u8);
        internal static SEL selWindow = sel_registerName("window"u8);
        internal static SEL selButtonNumber = sel_registerName("buttonNumber"u8);
        internal static SEL selLocationInWindow = sel_registerName("locationInWindow"u8);
        internal static SEL selMouseLocation = sel_registerName("mouseLocation"u8);
        internal static SEL selScrollingDeltaX = sel_registerName("scrollingDeltaX"u8);
        internal static SEL selScrollingDeltaY = sel_registerName("scrollingDeltaY"u8);
        internal static SEL selHasPreciseScrollingDeltas = sel_registerName("hasPreciseScrollingDeltas"u8);
        internal static SEL selTrackingNumber = sel_registerName("trackingNumber"u8);
        internal static SEL selKeyCode = sel_registerName("keyCode"u8);
        internal static SEL selARepeat = sel_registerName("isARepeat"u8);


        internal static SEL selInitWithContentRect_styleMask_backing_defer = sel_registerName("initWithContentRect:styleMask:backing:defer:"u8);
        internal static SEL selInitWithFrame = sel_registerName("initWithFrame:"u8);

        internal static SEL selAddTrackingRect_owner_userData_assumeInside = sel_registerName("addTrackingRect:owner:userData:assumeInside:"u8);

        internal static SEL selScreen = sel_registerName("screen"u8);
        internal static SEL selFrame = sel_registerName("frame"u8);
        internal static SEL selBounds = sel_registerName("bounds"u8);
        internal static SEL selSetFrameTopLeftPoint = sel_registerName("setFrameTopLeftPoint:"u8);
        internal static SEL selContentView = sel_registerName("contentView"u8);
        internal static SEL selSetContentView = sel_registerName("setContentView:"u8);
        internal static SEL selInterpretKeyEvents = sel_registerName("interpretKeyEvents:"u8);

        internal static SEL selMakeKeyAndOrderFront = sel_registerName("makeKeyAndOrderFront:"u8);

        internal static SEL selRequestUserAttention = sel_registerName("requestUserAttention"u8);

        internal static SEL selConvertRectToBacking = sel_registerName("convertRectToBacking:"u8);
        internal static SEL selConvertRectToScreen = sel_registerName("convertRectToScreen:"u8);

        internal static SEL selIsMiniaturized = sel_registerName("isMiniaturized"u8);
        internal static SEL selMiniaturize = sel_registerName("miniaturize:"u8);
        internal static SEL selDeminiaturize = sel_registerName("deminiaturize:"u8);
        internal static SEL selIsZoomed = sel_registerName("isZoomed"u8);
        internal static SEL selZoom = sel_registerName("zoom:"u8);
        internal static SEL selIsVisible = sel_registerName("isVisible"u8);
        internal static SEL selOrderFront = sel_registerName("orderFront:"u8);
        internal static SEL selOrderOut = sel_registerName("orderOut:"u8);

        internal static SEL selStyleMask = sel_registerName("styleMask"u8);
        internal static SEL selSetStyleMask = sel_registerName("setStyleMask:"u8);

        internal static SEL selLevel = sel_registerName("level"u8);
        internal static SEL selSetLevel = sel_registerName("setLevel:"u8);

        internal static SEL selScreens = sel_registerName("screens"u8);
        internal static SEL selCount = sel_registerName("count"u8);
        internal static SEL selObjectAtIndex = sel_registerName("objectAtIndex:"u8);

        internal static SEL selObject = sel_registerName("object"u8);

        internal static SEL selUpdate = sel_registerName("update"u8);

        internal static SEL selArray = sel_registerName("array"u8);
        internal static SEL selArrayWithObject = sel_registerName("arrayWithObject:"u8);

        internal static SEL selLength = sel_registerName("length"u8);

        internal static SEL selIsKindOfClass = sel_registerName("isKindOfClass:"u8);
        internal static SEL selInitWithAttributedString = sel_registerName("initWithAttributedString:"u8);
        internal static SEL selInitWithString = sel_registerName("initWithString:"u8);
        internal static SEL selMutableString = sel_registerName("mutableString"u8);
        internal static SEL selString = sel_registerName("string"u8);
        internal static SEL selSetString = sel_registerName("setString:"u8);

        internal static SEL selAddCursorRect_Cursor = sel_registerName("addCursorRect:cursor:"u8);
        internal static SEL selInvalidateCursorRectsForView = sel_registerName("invalidateCursorRectsForView:"u8);
        internal static SEL selEnableCursorRects = sel_registerName("enableCursorRects"u8);
        internal static SEL selDisableCursorRects = sel_registerName("disableCursorRects"u8);

        internal static SEL selSuperclass = sel_registerName("superclass"u8);




        internal static IntPtr NSDefaultRunLoop = GetStringConstant(FoundationLibrary, "NSDefaultRunLoopMode"u8);

        internal static readonly ObjCClass NSEventClass = objc_getClass("NSEvent"u8);
        internal static readonly ObjCClass NSScreenClass = objc_getClass("NSScreen");
        internal static readonly ObjCClass NSArrayClass = objc_getClass("NSArray");
        internal static readonly ObjCClass NSAttributedStringClass = objc_getClass("NSAttributedString"u8);
        internal static readonly ObjCClass NSMutableAttributedStringClass = objc_getClass("NSMutableAttributedString"u8);

        internal static ObjCClass NSOpenTKWindowClass;
        internal static ObjCClass NSOpenTKViewClass;

        internal static readonly Dictionary<IntPtr, NSWindowHandle> NSWindowDict = new Dictionary<nint, NSWindowHandle>();

        /// <inheritdoc/>
        public string Name => nameof(MacOSWindowComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Window;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Window)
            {
                throw new PalException(this, "MacOSWindowComponent can only initialize the Window component.");
            }

            ObjCClass nsapp = objc_getClass("NSApplication"u8);
            class_addMethod(nsapp, selQuit, OnQuitHandler, "v@:"u8);

            nsApplication = objc_msgSend_IntPtr((IntPtr)nsapp, selSharedApplication);

            objc_msgSend_bool(nsApplication, selSetActivationPolicy, (long)NSApplicationActivationpolicy.Regular);
            objc_msgSend(nsApplication, selDiscardEventsMatchingMask_beforeEvent, (ulong)NSEventMask.Any, IntPtr.Zero);

            IntPtr mainMenu = objc_msgSend_IntPtr(nsApplication, selMainMenu);
            if (mainMenu == IntPtr.Zero)
            {
                IntPtr menubar = objc_msgSend_IntPtr((IntPtr)objc_getClass("NSMenu"u8), Alloc);
                IntPtr menuItem = objc_msgSend_IntPtr((IntPtr)objc_getClass("NSMenuItem"u8), Alloc);

                objc_msgSend(menubar, sel_registerName("addItem:"u8), menuItem);
                objc_msgSend(nsApplication, sel_registerName("setMainMenu:"u8), menubar);

                IntPtr appMenu = objc_msgSend_IntPtr((IntPtr)objc_getClass("NSMenu"u8), Alloc);
                IntPtr quitMenuItem = objc_msgSend_IntPtr(
                        objc_msgSend_IntPtr((IntPtr)objc_getClass("NSMenuItem"u8), Alloc),
                        sel_registerName("initWithTitle:action:keyEquivalent:"u8),
                        ToNSString("Quit"u8),
                        selQuit,
                        ToNSString("q"u8));

                objc_msgSend(appMenu, sel_registerName("addItem:"u8), quitMenuItem);
                objc_msgSend(menuItem, sel_registerName("setSubmenu:"u8), appMenu);

                objc_msgSend(nsApplication, sel_registerName("finishLaunching"u8));
            }

            // FIXME: OpenTK 3 creates a new window and view class for every window, with a unique name.
            // Is this something we also want to do?

            // Allocate a window class
            NSOpenTKWindowClass = objc_allocateClassPair(objc_getClass("NSWindow"u8), "NSOpenTKWindow"u8, 0);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowShouldClose:"u8), ShouldWindowCloseHandler, "b@:@"u8);
            //class_addMethod(opentkWindowClass, sel_registerName("keyDown:"u8), (KeyDownDelegate)keyDown, "v@:@"u8);

            // NSWindowDelegate methods. We set the window as it's own delegate.
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidBecomeKey:"u8), NSOtkWindowDelegate_WindowDidBecomeKeyInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidResignKey:"u8), NSOtkWindowDelegate_WindowDidResignKeyInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidResize:"u8), NSOtkWindowDelegate_WindowDidResizeInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidMove:"u8), NSOtkWindowDelegate_WindowDidMoveInst, "v@:@"u8);
            objc_registerClassPair(NSOpenTKWindowClass);

            IntPtr NSTextInputClientProtocol = objc_getProtocol("NSTextInputClient"u8);
            NSOpenTKViewClass = objc_allocateClassPair(objc_getClass("NSView"), "NSOpenTKView"u8, 0);

            // Add an IVar for the markedText, so we can use it without finding the managed window object.
            class_addIvar(NSOpenTKViewClass, "markedText"u8, (nuint)nuint.Size, (nuint)int.Log2(nuint.Size), "@"u8);

            class_addMethod(NSOpenTKViewClass, sel_registerName("resetCursorRects"u8), NSOtkView_ResetCursorRectsInst, "v@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("mouseEntered:"u8), NSOtkView_MouseEnteredInst, "v@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("mouseExited:"u8), NSOtkView_MouseExitedInst, "v@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("keyDown:"u8), NSOtkView_KeyDownInst, "v@:@"u8);

            // TODO: canBecomeKeyView, 
            class_addMethod(NSOpenTKViewClass, sel_registerName("acceptsFirstResponder"u8), NSOtkView_AcceptsFirstResponderInst, "c@:"u8);

            // NSTextInputClientProtocol functions
            class_addProtocol(NSOpenTKViewClass, NSTextInputClientProtocol);
            // FIXME: The method type encoding strings only work for 64-bit, as NSRange is defined using NSUInteger so it changes size depending on arch.
            // So {_NSRange=QQ} and {_NSPoint=dd} would have to have something else other than QQ and dd, but I can't figure out what it's supposed to be atm..
            // - Noggin_bops 2023-11-11
            class_addMethod(NSOpenTKViewClass, sel_registerName("hasMarkedText"u8), NSOtkView_NSTextInputClient_HasMarkedTextInst, "c@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("markedRange"u8), NSOtkView_NSTextInputClient_MarkedRangeInst, "{_NSRange=QQ}@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("selectedRange"u8), NSOtkView_NSTextInputClient_SelectedRangeInst, "{_NSRange=QQ}@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("setMarkedText:selectedRange:replacementRange:"u8), NSOtkView_NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRangeInst, "v@:@{_NSRange=QQ}{_NSRange=QQ}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("unmarkText"u8), NSOtkView_NSTextInputClient_UnmarkTextInst, "v@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("validAttributesForMarkedText"u8), NSOtkView_NSTextInputClient_ValidAttributesForMarkedTextInst, "@@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("attributedSubstringForProposedRange:actualRange:"u8), NSOtkView_NSTextInputClient_AttributedSubstringForProposedRange_ActualRangeInst, "@@:{_NSRange=QQ}^{_NSRange=QQ}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("insertText:replacementRange:"u8), NSOtkView_NSTextInputClient_InsertText_ReplacementRangeInst, "v@:@{_NSRange=QQ}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("characterIndexForPoint:"u8), NSOtkView_NSTextInputClient_CharacterIndexForPointInst, "Q@:{_NSPoint=dd}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("firstRectForCharacterRange:actualRange:"u8), NSOtkView_NSTextInputClient_FirstRectForCharacterRange_ActualRangeInst, "{_NSRect={_NSPoint=dd}{_NSSize=dd}}@:{_NSRange=QQ}^{_NSRange=QQ}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("doCommandBySelector:"u8), NSOtkView_NSTextInputClient_DoCommandBySelectorInst, "v@::"u8);;
            objc_registerClassPair(NSOpenTKViewClass);
        }

        private delegate void OnQuitDelegate(IntPtr self, SEL cmd);
        private static readonly OnQuitDelegate OnQuitHandler = OnQuit;
        private static void OnQuit(IntPtr self, SEL cmd)
        {
            Console.WriteLine("On quit!");

            // Actually quit.
            objc_msgSend(nsApplication, sel_registerName("terminate:"u8), nsApplication);
        }

        private delegate bool ShouldWindowCloseDelegate(IntPtr windowPtr, SEL selector, IntPtr sender);
        static ShouldWindowCloseDelegate ShouldWindowCloseHandler = ShouldWindowClose;
        private static bool ShouldWindowClose(IntPtr window, SEL selector, IntPtr sender)
        {
            // FIXME:
            // Send event and return false?
            // Or should we override performClose instead?
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                EventQueue.Raise(nswindow, PlatformEventType.Close, new CloseEventArgs(nswindow));

                // FIXME: Don't destroy the window by default.
                nswindow.Destroyed = true;
            }

            return true;
        }

        // We reuse this delegate definition for all window delegate notifications that return void
        // and takes a single NSNotification as it's arguments.
        // - Noggin_bops 2023-11-11
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void NSOtkWindowDelegate_Notification(IntPtr @delegate, SEL selector, IntPtr notification);

        private static readonly NSOtkWindowDelegate_Notification NSOtkWindowDelegate_WindowDidBecomeKeyInst = NSOtkWindowDelegate_WindowDidBecomeKey;
        private static void NSOtkWindowDelegate_WindowDidBecomeKey(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                EventQueue.Raise(nswindow, PlatformEventType.Focus, new FocusEventArgs(nswindow, true));
            }
            else
            {
                // FIXME: How do we get the logger here?
                // Logger?.LogDebug($"Got WindowDidBecomeKey for unknown window: 0x{window}");
                Console.WriteLine($"Got WindowDidBecomeKey for unknown window: 0x{window}");
            }
        }

        private static readonly NSOtkWindowDelegate_Notification NSOtkWindowDelegate_WindowDidResignKeyInst = NSOtkWindowDelegate_WindowDidResignKey;
        private static void NSOtkWindowDelegate_WindowDidResignKey(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                EventQueue.Raise(nswindow, PlatformEventType.Focus, new FocusEventArgs(nswindow, false));
            }
            else
            {
                // FIXME: How do we get the logger here?
                // Logger?.LogDebug($"Got WindowDidBecomeKey for unknown window: 0x{window}");
                Console.WriteLine($"Got WindowDidResignKey for unknown window: 0x{window}");
            }
        }

        private static readonly NSOtkWindowDelegate_Notification NSOtkWindowDelegate_WindowDidResizeInst = NSOtkWindowDelegate_WindowDidResize;
        private static void NSOtkWindowDelegate_WindowDidResize(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                if (nswindow.Context != null)
                {
                    objc_msgSend(nswindow.Context.Context, selUpdate);
                }

                CGRect bounds = objc_msgSend_CGRect(nswindow.View, selBounds);
                CGRect backing = objc_msgSend_CGRect(nswindow.View, selConvertRectToBacking, bounds);
                // FIXME: Framebuffer size event?

                // FIXME: Do not cast to int?
                Vector2i newSize = new Vector2i((int)bounds.size.x, (int)bounds.size.y);
                EventQueue.Raise(nswindow, PlatformEventType.WindowResize, new WindowResizeEventArgs(nswindow, newSize));
            }
            else
            {
                // FIXME: How do we get the logger here?
                // Logger?.LogDebug($"Got WindowDidResize for unknown window: 0x{window}");
                Console.WriteLine($"Got WindowDidResize for unknown window: 0x{window}");
            }
        }

        private static readonly NSOtkWindowDelegate_Notification NSOtkWindowDelegate_WindowDidMoveInst = NSOtkWindowDelegate_WindowDidMove;
        private static void NSOtkWindowDelegate_WindowDidMove(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                if (nswindow.Context != null)
                {
                    objc_msgSend(nswindow.Context.Context, selUpdate);
                }

                CGRect windowFrame = objc_msgSend_CGRect(nswindow.Window, selFrame);
                CGRect viewFrame = objc_msgSend_CGRect(nswindow.View, selFrame);

                windowFrame = CG.FlipYCoordinate(windowFrame);
                viewFrame = CG.FlipYCoordinate(viewFrame);

                // FIXME: Do not cast to int?
                Vector2i windowPosition = new Vector2i((int)windowFrame.size.x, (int)windowFrame.size.y);
                Vector2i viewPosition = new Vector2i((int)viewFrame.size.x, (int)viewFrame.size.y);
                EventQueue.Raise(nswindow, PlatformEventType.WindowMove, new WindowMoveEventArgs(nswindow, windowPosition, viewPosition));
            }
            else
            {
                // FIXME: How do we get the logger here?
                // Logger?.LogDebug($"Got WindowDidMove for unknown window: 0x{window}");
                Console.WriteLine($"Got WindowDidMove for unknown window: 0x{window}");
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void NSOtkView_ResetCursorRects_(IntPtr view, SEL selector);
        static NSOtkView_ResetCursorRects_ NSOtkView_ResetCursorRectsInst = NSOtkView_ResetCursorRects;
        static void NSOtkView_ResetCursorRects(IntPtr view, SEL selector)
        {
            objc_super super;
            super.receiver = view;
            super.pclass = (ObjCClass)objc_msgSend_IntPtr(view, selSuperclass);
            objc_msgSendSuper(super, selector);

            IntPtr window = objc_msgSend_IntPtr(view, selWindow);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow) == false)
            {
                // FIXME: How do we get the logger here?
                //Logger?.LogWarning($"Received ResetCurorRects event for unknown window: {window}");
                Console.WriteLine($"Received ResetCurorRects event for unknown window: {window}");
                return;
            }

            if (nswindow.Cursor != null)
            {
                CGRect bounds = objc_msgSend_CGRect(view, selBounds);
                switch (nswindow.Cursor.Mode)
                {
                    // If the cursor is animated, pick the current frame.
                    case NSCursorHandle.CursorMode.AnimatedCursor:
                        objc_msgSend(view, selAddCursorRect_Cursor, bounds, nswindow.Cursor.CursorFrames![nswindow.Cursor.Frame]);
                        break;
                    default:
                        objc_msgSend(view, selAddCursorRect_Cursor, bounds, nswindow.Cursor.Cursor);
                        break;
                }
            }
            else
            {
                // Null cursor means it is hidden.
                // FIXME: Hide the cursor? Should we do it here?
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void MouseEnteredDelegate(IntPtr view, SEL selector, IntPtr @event);
        static MouseEnteredDelegate NSOtkView_MouseEnteredInst = NSOtkView_MouseEntered;
        static void NSOtkView_MouseEntered(IntPtr view, SEL selector, IntPtr @event)
        {
            IntPtr window = objc_msgSend_IntPtr(@event, selWindow);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow) == false)
            {
                // FIXME: How do we get the logger here?
                //Logger?.LogWarning($"Received MouseEntered event with unknown window: {window}");
                Console.WriteLine($"Received MouseEntered event with unknown window: {window}");
                return;
            }

            EventQueue.Raise(nswindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(nswindow, true));
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void MouseExitedDelegate(IntPtr view, SEL selector, IntPtr @event);
        static MouseExitedDelegate NSOtkView_MouseExitedInst = NSOtkView_MouseExited;
        static void NSOtkView_MouseExited(IntPtr view, SEL selector, IntPtr @event)
        {
            IntPtr window = objc_msgSend_IntPtr(@event, selWindow);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow) == false)
            {
                // FIXME: How do we get the logger here?
                //Logger?.LogWarning($"Received MouseEntered event with unknown window: {window}");
                Console.WriteLine($"Received MouseExited event with unknown window: {window}");
                return;
            }

            EventQueue.Raise(nswindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(nswindow, false));
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void NSOtkView_KeyDown_(IntPtr view, SEL selector, IntPtr @event);
        private static NSOtkView_KeyDown_ NSOtkView_KeyDownInst = NSOtkView_KeyDown;
        private static void NSOtkView_KeyDown(IntPtr view, SEL selector, IntPtr @event)
        {
            IntPtr array = objc_msgSend_IntPtr((IntPtr)NSArrayClass, selArrayWithObject, @event);
            objc_msgSend_IntPtr(view, selInterpretKeyEvents, array);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        private delegate bool NSOtkView_AcceptsFirstResponder_(IntPtr view, SEL selector);
        private static NSOtkView_AcceptsFirstResponder_ NSOtkView_AcceptsFirstResponderInst = NSOtkView_AcceptsFirstResponder;
        private static bool NSOtkView_AcceptsFirstResponder(IntPtr view, SEL selector)
        {
            return true;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        private delegate bool /* BOOL */ NSTextInputClient_HasMarkedText(IntPtr view, SEL selector);
        private static readonly NSTextInputClient_HasMarkedText NSOtkView_NSTextInputClient_HasMarkedTextInst = NSOtkView_NSTextInputClient_HasMarkedText;
        private static bool /* BOOL */ NSOtkView_NSTextInputClient_HasMarkedText(IntPtr view, SEL selector)
        {
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_getInstanceVariable(view, "markedText"u8, out IntPtr markedText);
            ulong length = (ulong)objc_msgSend_IntPtr(markedText, selLength);
            return length > 0;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate NSRange NSTextInputClient_MarkedRange(IntPtr view, SEL selector);
        private static readonly NSTextInputClient_MarkedRange NSOtkView_NSTextInputClient_MarkedRangeInst = NSOtkView_NSTextInputClient_MarkedRange;
        private static NSRange NSOtkView_NSTextInputClient_MarkedRange(IntPtr view, SEL selector)
        {
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_getInstanceVariable(view, "markedText"u8, out IntPtr markedText);
            ulong length = (ulong)objc_msgSend_IntPtr(markedText, selLength);
            if (length > 0)
            {
                return new NSRange(0, (nuint)length-1);
            }
            else
            {
                return NSRange.kEmptyRange;
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate NSRange NSTextInputClient_SelectedRange(IntPtr view, SEL selector);
        private static readonly NSTextInputClient_SelectedRange NSOtkView_NSTextInputClient_SelectedRangeInst = NSOtkView_NSTextInputClient_SelectedRange;
        private static NSRange NSOtkView_NSTextInputClient_SelectedRange(IntPtr view, SEL selector)
        {
            return NSRange.kEmptyRange;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRange(IntPtr view, SEL selector, IntPtr /* id */ @string, NSRange selectedRange, NSRange replacementRange);
        private static readonly NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRange NSOtkView_NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRangeInst = NSOtkView_NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRange;
        private static void NSOtkView_NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRange(IntPtr view, SEL selector, IntPtr /* id */ @string, NSRange selectedRange, NSRange replacementRange)
        {
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_getInstanceVariable(view, "markedText"u8, out IntPtr markedText);
            objc_msgSend(markedText, Release);
            // FIXME: BOOL
            if (objc_msgSend_bool(@string, selIsKindOfClass, (IntPtr)objc_getClass("NSAttributedString"u8)))
            {
                markedText = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSMutableAttributedStringClass, Alloc), selInitWithAttributedString, @string);

            }
            else
            {
                markedText = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSMutableAttributedStringClass, Alloc), selInitWithString, @string);
            }
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_setInstanceVariable(view, "markedText"u8, markedText);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void NSTextInputClient_UnmarkText(IntPtr view, SEL selector);
        private static readonly NSTextInputClient_UnmarkText NSOtkView_NSTextInputClient_UnmarkTextInst = NSOtkView_NSTextInputClient_UnmarkText;
        private static void NSOtkView_NSTextInputClient_UnmarkText(IntPtr view, SEL selector)
        {
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_getInstanceVariable(view, "markedText"u8, out IntPtr markedText);
            // FIXME: Do not create a new NSString every time!
            objc_msgSend(objc_msgSend_IntPtr(markedText, selMutableString), selSetString, ToNSString(""));
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr /* NSArray<NSAttributedStringKey>* */ NSTextInputClient_ValidAttributesForMarkedText(IntPtr view, SEL selector);
        private static readonly NSTextInputClient_ValidAttributesForMarkedText NSOtkView_NSTextInputClient_ValidAttributesForMarkedTextInst = NSOtkView_NSTextInputClient_ValidAttributesForMarkedText;
        private static IntPtr /* NSAttributedString* */ NSOtkView_NSTextInputClient_ValidAttributesForMarkedText(IntPtr view, SEL selector)
        {
            return objc_msgSend_IntPtr((IntPtr)NSArrayClass, selArray);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr /* NSAttributedString* */ NSTextInputClient_AttributedSubstringForProposedRange_ActualRange(IntPtr view, SEL selector, NSRange range, ref NSRange actualRange);
        private static readonly NSTextInputClient_AttributedSubstringForProposedRange_ActualRange NSOtkView_NSTextInputClient_AttributedSubstringForProposedRange_ActualRangeInst = NSOtkView_NSTextInputClient_AttributedSubstringForProposedRange_ActualRange;
        private static IntPtr /* NSAttributedString* */ NSOtkView_NSTextInputClient_AttributedSubstringForProposedRange_ActualRange(IntPtr view, SEL selector, NSRange range, ref NSRange actualRange)
        {
            return IntPtr.Zero;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void NSTextInputClient_InsertText_ReplacementRange(IntPtr view, SEL selector, IntPtr /* id */ @string, NSRange range);
        private static readonly NSTextInputClient_InsertText_ReplacementRange NSOtkView_NSTextInputClient_InsertText_ReplacementRangeInst = NSOtkView_NSTextInputClient_InsertText_ReplacementRange;
        private static void NSOtkView_NSTextInputClient_InsertText_ReplacementRange(IntPtr view, SEL selector, IntPtr /* id */ @string, NSRange range)
        {
            IntPtr windowPtr = objc_msgSend_IntPtr(view, selWindow);
            if (NSWindowDict.TryGetValue(windowPtr, out NSWindowHandle? nswindow) == false)
            {
                Console.WriteLine($"Could not find NSWindow for NSView 0x{view}");
                return;
            }

            string str;
            if (objc_msgSend_bool(@string, selIsKindOfClass, (IntPtr)objc_getClass("NSAttributedString"u8)))
            {
                str = FromNSString(objc_msgSend_IntPtr(@string, selString));
            }
            else
            {
                str = FromNSString(@string);
            }

            EventQueue.Raise(nswindow, PlatformEventType.TextInput, new TextInputEventArgs(nswindow, str));
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate nuint NSTextInputClient_CharacterIndexForPoint(IntPtr view, SEL selector, CGPoint point);
        private static readonly NSTextInputClient_CharacterIndexForPoint NSOtkView_NSTextInputClient_CharacterIndexForPointInst = NSOtkView_NSTextInputClient_CharacterIndexForPoint;
        private static nuint NSOtkView_NSTextInputClient_CharacterIndexForPoint(IntPtr view, SEL selector, CGPoint point)
        {
            return 0;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate CGRect NSTextInputClient_FirstRectForCharacterRange_ActualRange(IntPtr view, SEL selector, CGPoint point);
        private static readonly NSTextInputClient_FirstRectForCharacterRange_ActualRange NSOtkView_NSTextInputClient_FirstRectForCharacterRange_ActualRangeInst = NSOtkView_NSTextInputClient_FirstRectForCharacterRange_ActualRange;
        private static CGRect NSOtkView_NSTextInputClient_FirstRectForCharacterRange_ActualRange(IntPtr view, SEL selector, CGPoint point)
        {
            // FIXME: Why do we do this?
            CGRect frame = objc_msgSend_CGRect(view, selFrame);
            return new CGRect(frame.origin, CGPoint.Zero);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void NSTextInputClient_DoCommandBySelector(IntPtr view, SEL _selector, SEL selector);
        private static readonly NSTextInputClient_DoCommandBySelector NSOtkView_NSTextInputClient_DoCommandBySelectorInst = NSOtkView_NSTextInputClient_DoCommandBySelector;
        private static void NSOtkView_NSTextInputClient_DoCommandBySelector(IntPtr view, SEL _selector, SEL selector)
        {
            Console.WriteLine("DoCommandBySelector");
        }

        /// <inheritdoc/>
        public bool CanSetIcon => true;

        /// <inheritdoc/>
        public bool CanGetDisplay => true;

        /// <inheritdoc/>
        public bool CanSetCursor => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool CanCaptureCursor => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<PlatformEventType> SupportedEvents => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowBorderStyle> SupportedStyles => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowMode> SupportedModes => throw new NotImplementedException();


        /// <inheritdoc/>
        public void ProcessEvents(bool waitForEvents = false)
        {
            IntPtr @event;
            while((@event = objc_msgSend_IntPtr(nsApplication, selNextEventMatchingMask_untilDate_inMode_dequeue, NSEventMask.Any, IntPtr.Zero, NSDefaultRunLoop, true)) != IntPtr.Zero)
            {
                NSEventType type = (NSEventType)objc_msgSend_ulong(@event, selType);

                IntPtr windowPtr = objc_msgSend_IntPtr(@event, selWindow);
                if (NSWindowDict.TryGetValue(windowPtr, out NSWindowHandle? nswindow) == false)
                {
                    if (type == NSEventType.MouseMoved ||
                        type == NSEventType.SystemDefined ||
                        type == NSEventType.AppKitDefined)
                    {
                        // Do not log the more spammy events..
                    }
                    else
                    {
                        Logger?.LogDebug($"Event for non opentk window: {type} (0x{windowPtr})");
                    }
                    
                    objc_msgSend(nsApplication, selSendEvent, @event);

                    continue;
                }

                switch (type)
                {
                    case NSEventType.LeftMouseDown:
                    case NSEventType.RightMouseDown:
                    case NSEventType.OtherMouseDown:
                        {
                            // FIXME: This should be a long, not ulong
                            ulong button = objc_msgSend_ulong(@event, selButtonNumber);
                            MouseButton mouseButton;
                            switch (button)
                            {
                                case 0: mouseButton = MouseButton.Button1; break;
                                case 1: mouseButton = MouseButton.Button2; break;
                                case 2: mouseButton = MouseButton.Button3; break;
                                case 3: mouseButton = MouseButton.Button4; break;
                                case 4: mouseButton = MouseButton.Button5; break;
                                case 5: mouseButton = MouseButton.Button6; break;
                                case 6: mouseButton = MouseButton.Button7; break;
                                case 7: mouseButton = MouseButton.Button8; break;
                                default: throw new PalException(this, $"Unknown mouse button: {button}");
                            }

                            EventQueue.Raise(nswindow, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(nswindow, mouseButton));

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.LeftMouseUp:
                    case NSEventType.RightMouseUp:
                    case NSEventType.OtherMouseUp:
                        {
                            // FIXME: This should be a long, not ulong
                            ulong button = objc_msgSend_ulong(@event, selButtonNumber);
                            MouseButton mouseButton;
                            switch (button)
                            {
                                case 0: mouseButton = MouseButton.Button1; break;
                                case 1: mouseButton = MouseButton.Button2; break;
                                case 2: mouseButton = MouseButton.Button3; break;
                                case 3: mouseButton = MouseButton.Button4; break;
                                case 4: mouseButton = MouseButton.Button5; break;
                                case 5: mouseButton = MouseButton.Button6; break;
                                case 6: mouseButton = MouseButton.Button7; break;
                                case 7: mouseButton = MouseButton.Button8; break;
                                default: throw new PalException(this, $"Unknown mouse button: {button}");
                            }

                            EventQueue.Raise(nswindow, PlatformEventType.MouseUp, new MouseButtonUpEventArgs(nswindow, mouseButton));

                            // FIXME: If the mouse is outside of the window after a drag we want to send a mouse exit event here

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.MouseMoved:
                        {
                            CGPoint point = objc_msgSend_CGPoint(@event, selLocationInWindow);

                            CGRect pointRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, new CGRect(point, CGPoint.Zero));

                            CGRect backing = objc_msgSend_CGRect(
                                nswindow.Window,
                                selConvertRectToBacking,
                                objc_msgSend_CGRect(nswindow.View, selBounds));

                            // FIXME: Coordinate space
                            Vector2 pos = new Vector2((float)pointRect.origin.x, (float)(backing.size.y - pointRect.origin.y));

                            EventQueue.Raise(nswindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(nswindow, pos));

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.LeftMouseDragged:
                    case NSEventType.RightMouseDragged:
                    case NSEventType.OtherMouseDragged:
                        {
                            CGPoint point = objc_msgSend_CGPoint(@event, selLocationInWindow);

                            CGRect pointRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, new CGRect(point, CGPoint.Zero));

                            CGRect backing = objc_msgSend_CGRect(
                                nswindow.Window,
                                selConvertRectToBacking,
                                objc_msgSend_CGRect(nswindow.View, selBounds));

                            // FIXME: Coordinate space
                            Vector2 pos = new Vector2((float)pointRect.origin.x, (float)(backing.size.y - pointRect.origin.y));

                            EventQueue.Raise(nswindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(nswindow, pos));

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.ScrollWheel:
                        {
                            float scrollX = objc_msgSend_float(@event, selScrollingDeltaX);
                            float scrollY = objc_msgSend_float(@event, selScrollingDeltaY);

                            bool preciseScrollingDeltas = objc_msgSend_bool(@event, selHasPreciseScrollingDeltas);

                            // FIXME: We might need to flip the horizontal direction?
                            // FIXME: Consider precise deltas...
                            Vector2 delta = new Vector2(scrollX, scrollY);
                            Vector2 distance = new Vector2(scrollX, scrollY);

                            if (preciseScrollingDeltas)
                            {
                                // FIXME: This is an ok hack for now but we want to do this
                                // "properly" in the future.
                                delta *= 0.1f;
                            }

                            MacOSMouseComponent.RegisterMouseWheelDelta(delta);
                            EventQueue.Raise(nswindow, PlatformEventType.Scroll, new ScrollEventArgs(nswindow, delta, distance));

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.KeyDown:
                        {
                            ushort keyCode = objc_msgSend_ushort(@event, selKeyCode);
                            // FIXME: BOOL
                            bool isRepeat = objc_msgSend_bool(@event, selARepeat);
                            Console.WriteLine($"Key down: 0x{keyCode:X}");

                            // FIXME: This is a temprary hack to get some of the most used key in.
                            switch (keyCode)
                            {
                                case 0x24: // kVK_Return
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.Return, Scancode.Return, isRepeat));
                                    break;
                                case 0x33: // kVK_Delete
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.Backspace, Scancode.Backspace, isRepeat));
                                    break;
                                case 0x35: // kVK_Escape
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.Escape, Scancode.Escape, isRepeat));
                                    break;
                                case 0x7B: // kVK_LeftArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.LeftArrow, Scancode.LeftArrow, isRepeat));
                                    break;
                                case 0x7C: // kVK_RightArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.RightArrow, Scancode.RightArrow, isRepeat));
                                    break;
                                case 0x7D: // kVK_DownArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.DownArrow, Scancode.DownArrow, isRepeat));
                                    break;
                                case 0x7E: // kVK_UpArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.UpArrow, Scancode.UpArrow, isRepeat));
                                    break;
                                default:
                                    break;
                            }

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.KeyUp:
                        {
                            ushort keyCode = objc_msgSend_ushort(@event, selKeyCode);
                            Console.WriteLine($"Key up: 0x{keyCode:X}");

                            // FIXME: This is a temprary hack to get some of the most used key in.
                            switch (keyCode)
                            {
                                case 0x24: // kVK_Return
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.Return, Scancode.Return));
                                    break;
                                case 0x33: // kVK_Delete
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.Backspace, Scancode.Backspace));
                                    break;
                                case 0x35: // kVK_Escape
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.Escape, Scancode.Escape));
                                    break;
                                case 0x7B: // kVK_LeftArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.LeftArrow, Scancode.LeftArrow));
                                    break;
                                case 0x7C: // kVK_RightArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.RightArrow, Scancode.RightArrow));
                                    break;
                                case 0x7D: // kVK_DownArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.DownArrow, Scancode.DownArrow));
                                    break;
                                case 0x7E: // kVK_UpArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.UpArrow, Scancode.UpArrow));
                                    break;
                                default:
                                    break;
                            }

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    default:
                        //Console.WriteLine($"Event type: {type}");
                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                }
            }
        }

        /// <inheritdoc/>
        public WindowHandle Create(GraphicsApiHints hints)
        {
            // FIXME: Better default placement of window?
            CGRect windowRect = new CGRect(500, 500, 500, 500);
            NSWindowStyleMask style = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable;

            IntPtr windowPtr = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenTKWindowClass, Alloc),
                selInitWithContentRect_styleMask_backing_defer,
                windowRect, style, NSBackingStoreType.Buffered, false);

            IntPtr viewPtr = objc_msgSend_IntPtr(windowPtr, selContentView);
            // FIXME: Error checking!

            // Replace the view!
            viewPtr = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenTKViewClass, Alloc),
                selInitWithFrame,
                objc_msgSend_CGRect(viewPtr, selBounds));

            objc_msgSend(windowPtr, selSetContentView, viewPtr);

            NSWindowHandle nswindow = new NSWindowHandle(windowPtr, viewPtr, hints);

            NSWindowDict.Add(windowPtr, nswindow);


            // FIXME: Move this somewhere?
            objc_msgSend(windowPtr, sel_registerName("setDelegate:"u8), windowPtr);
            // Makes the view able to get text input?
            objc_msgSend(windowPtr, sel_registerName("makeFirstResponder:"u8), viewPtr);
            objc_msgSend(windowPtr, sel_registerName("makeKeyWindow"u8));
            objc_msgSend(windowPtr, sel_registerName("center"u8));
            objc_msgSend(windowPtr, selMakeKeyAndOrderFront, windowPtr);

            IntPtr inputContext = objc_msgSend_IntPtr(viewPtr, sel_registerName("inputContext"u8));

            // Register the view for mouse enter/exit notifications.
            objc_msgSend_IntPtr(viewPtr, selAddTrackingRect_owner_userData_assumeInside,
                objc_msgSend_CGRect(viewPtr, selBounds),
                viewPtr,
                IntPtr.Zero,
                false);

            return nswindow;
        }

        /// <inheritdoc/>
        public void Destroy(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            NSWindowDict.Remove(nswindow.Window);

            // This also releases the window if the releaseWhenClosed property is true
            // This is the default.
            objc_msgSend(nswindow.Window, sel_registerName("close"u8));

            // Maybe make sure that there are no references to the window?

            nswindow.Destroyed = true;
        }

        /// <inheritdoc/>
        public bool IsWindowDestroyed(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            return nswindow.Destroyed;
        }

        /// <inheritdoc/>
        public string GetTitle(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            IntPtr nsStringTitle = objc_msgSend_IntPtr(nswindow.Window, sel_registerName("title"u8));
            string title = FromNSString(nsStringTitle);
            return title;
        }

        /// <inheritdoc/>
        public void SetTitle(WindowHandle handle, string title)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            objc_msgSend(nswindow.Window, sel_registerName("setTitle:"u8), ToNSString(title));
        }

        /// <inheritdoc/>
        public IconHandle? GetIcon(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            IntPtr screen = objc_msgSend_IntPtr(nswindow.Window, selScreen);
            //CGRect screenBackingRect = objc_msgSend_CGRect(screen, selConvertRectToBacking, objc_msgSend_CGRect(screen, selFrame));

            CGRect frame = objc_msgSend_CGRect(nswindow.Window, selFrame);

            //CGRect backingRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, frame);

            //x = (int)backingRect.origin.x;
            //y = (int)(screenBackingRect.size.y - (backingRect.origin.y + backingRect.size.y));

            x = (int)frame.origin.x;
            y = (int)CG.FlipYCoordinate(frame.origin.y + frame.size.y);
        }

        /// <inheritdoc/>
        public void SetPosition(WindowHandle handle, int x, int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            float flippedY = CG.FlipYCoordinate(y);

            // FIXME: Coordinate space?
            objc_msgSend(nswindow.Window, selSetFrameTopLeftPoint, new CGPoint(x, flippedY));
        }

        /// <inheritdoc/>
        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect rect = objc_msgSend_CGRect(nswindow.Window, selFrame);

            // FIXME: Do not cast to int?
            width = (int)rect.size.x;
            height = (int)rect.size.y;
        }

        /// <inheritdoc/>
        public void SetSize(WindowHandle handle, int width, int height)
        {
            // FIXME: setFrame:display:

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.View, selFrame);

            CGRect screenRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToScreen, frame);

            x = (int)screenRect.origin.x;
            y = (int)CG.FlipYCoordinate(screenRect.origin.y + screenRect.size.y);
        }

        /// <inheritdoc/>
        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            // FIXME:
            //throw new NotImplementedException();
        }

        // FIXME: Separate the window size from the framebuffer size?

        /// <inheritdoc/>
        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.View, selFrame);

            CGRect screenFrame = objc_msgSend_CGRect(nswindow.Window, selConvertRectToScreen, frame);
            
            width = (int)(screenFrame.size.x);
            height = (int)(screenFrame.size.y);
        }

        /// <inheritdoc/>
        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            // FIXME:
            //throw new NotImplementedException();


        }

        public void GetFramebufferSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect bounds = objc_msgSend_CGRect(nswindow.View, selBounds);
            CGRect boundsBacking = objc_msgSend_CGRect(nswindow.View, selConvertRectToBacking, bounds);

            width = (int)(boundsBacking.size.x);
            height = (int)(boundsBacking.size.y);
        }

        /// <inheritdoc/>
        public void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetMaxClientSize(WindowHandle handle, int? width, int? height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetMinClientSize(WindowHandle handle, int? width, int? height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect windowFrame = objc_msgSend_CGRect(nswindow.Window, selFrame);
            windowFrame = CG.FlipYCoordinate(windowFrame);

            Box2 windowBounds = new Box2(
                (float)windowFrame.origin.x,
                (float)windowFrame.origin.y,
                (float)(windowFrame.origin.x + windowFrame.size.x),
                (float)(windowFrame.origin.y + windowFrame.size.y));

            // X11DisplayComponent.GetDisplay contains a loop very similar to this one
            // - Noggin_bops 2023-11-09
            IntPtr bestScreen = 0;
            float bestArea = 0;
            float bestDistance = float.PositiveInfinity;

            // Get all screens.
            IntPtr screensNSArray = objc_msgSend_IntPtr((IntPtr)NSScreenClass, selScreens);
            nint count = (nint)objc_msgSend_IntPtr(screensNSArray, selCount);
            for (int screenIdx = 0; screenIdx < count; screenIdx++)
            {
                IntPtr nsscreen = objc_msgSend_IntPtr(screensNSArray, selObjectAtIndex, (IntPtr)screenIdx);
                CGRect frame = objc_msgSend_CGRect(nsscreen, selFrame);

                Box2 bounds = new Box2(
                    (float)frame.origin.x,
                    (float)frame.origin.y,
                    (float)(frame.origin.x + frame.size.x),
                    (float)(frame.origin.y + frame.size.y));

                Box2 overlap = bounds.Intersected(windowBounds);

                if (overlap.SizeX * overlap.SizeY > bestArea)
                {
                    bestArea = overlap.SizeX * overlap.SizeY;
                    bestScreen = nsscreen;
                }
                else if (bestArea <= 0)
                {
                    // If there is no overlap we are looking for the display which is closest.
                    float dist = Distance(bounds, windowBounds);
                    if (dist < bestDistance)
                    {
                        bestDistance = dist;
                        if (bestArea < 0)
                        {
                            bestScreen = nsscreen;
                        }
                    }
                }
            }

            // FIXME: Maybe throw here?
            Debug.Assert(bestScreen != IntPtr.Zero);

            DisplayHandle disp = MacOSDisplayComponent.FindDisplay(bestScreen);

            return disp;

            // FIXME: Add a function like this to all Box types.
            static float Distance(Box2 a, Box2 b)
            {
                return Math.Min(
                    Math.Min(
                        a.DistanceToNearestEdge(b.Min),
                        a.DistanceToNearestEdge(b.Max)),
                    Math.Min(
                        a.DistanceToNearestEdge((b.Min.X, b.Max.Y)),
                        a.DistanceToNearestEdge((b.Min.Y, b.Max.X))));
            }
        }

        /// <inheritdoc/>
        public WindowMode GetMode(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (objc_msgSend_bool(nswindow.Window, selIsMiniaturized, nswindow.Window))
            {
                return WindowMode.Minimized;
            }

            // FIXME: Should we change to fullscreen instead?
            if (objc_msgSend_bool(nswindow.Window, selIsZoomed, nswindow.Window))
            {
                return WindowMode.Maximized;
            }

            // FIXME: check for fullscreen!

            if (objc_msgSend_bool(nswindow.Window, selIsVisible, nswindow.Window) == false)
            {
                return WindowMode.Hidden;
            }
            else
            {
                return WindowMode.Normal;
            }
        }

        /// <inheritdoc/>
        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            switch (mode)
            {
                case WindowMode.Hidden:
                    {
                        objc_msgSend(nswindow.Window, selOrderOut, nswindow.Window);

                        break;
                    }
                case WindowMode.Minimized:
                    {
                        objc_msgSend(nswindow.Window, selMiniaturize, nswindow.Window);
                        break;
                    }
                case WindowMode.Normal:
                    {
                        // FIXME: Is this everything we need to do?

                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsZoomed))
                        {
                            objc_msgSend(nswindow.Window, selZoom, nswindow.Window);
                        }

                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsMiniaturized))
                        {
                            objc_msgSend(nswindow.Window, selDeminiaturize, nswindow.Window);
                        }

                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsVisible) == false)
                        {
                            objc_msgSend(nswindow.Window, selOrderFront, nswindow.Window);
                        }

                        break;
                    }
                case WindowMode.Maximized:
                    {
                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsMiniaturized))
                        {
                            objc_msgSend(nswindow.Window, selDeminiaturize, nswindow.Window);
                        }

                        // If the window was hidden, show it.
                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsVisible) == false)
                        {
                            objc_msgSend(nswindow.Window, selOrderFront, nswindow.Window);
                        }

                        // FIXME: Should we be calling "zoom:" or "toggleFullscreen:" here?
                        // What is the "expected" behaviour.

                        // macos calls maximizing "zoom".
                        objc_msgSend(nswindow.Window, selZoom, nswindow.Window);
                        break;
                    }
                case WindowMode.WindowedFullscreen:
                    {
                        throw new NotImplementedException();
                        break;
                    }
                case WindowMode.ExclusiveFullscreen:
                    {
                        throw new NotImplementedException();
                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, mode.GetType());
            }
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle? display)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle display, VideoMode videoMode)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public bool GetFullscreenDisplay(WindowHandle window, [NotNullWhen(true)] out DisplayHandle? display)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public WindowBorderStyle GetBorderStyle(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            NSWindowStyleMask style = (NSWindowStyleMask)objc_msgSend_IntPtr(nswindow.Window, selStyleMask);

            // If the style mask is 0 it's the same as Borderless, it's not a flag.
            if (style == NSWindowStyleMask.Borderless)
            {
                return WindowBorderStyle.Borderless;
            }

            if (style.HasFlag(NSWindowStyleMask.UtilityWindow))
            {
                return WindowBorderStyle.ToolBox;
            }

            if (style.HasFlag(NSWindowStyleMask.Resizable))
            {
                return WindowBorderStyle.ResizableBorder;
            }

            return WindowBorderStyle.FixedBorder;
        }

        /// <inheritdoc/>
        public void SetBorderStyle(WindowHandle handle, WindowBorderStyle style)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            switch (style)
            {
                case WindowBorderStyle.Borderless:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Borderless;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        break;
                    }
                case WindowBorderStyle.FixedBorder:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        break;
                    }
                case WindowBorderStyle.ResizableBorder:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        break;
                    }
                case WindowBorderStyle.ToolBox:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable | NSWindowStyleMask.UtilityWindow;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        // FIXME: We can only set the utility flag on a NSPanel and not NSWindow...
                        // We might need to recreate the window as a panel, alternatively maybe it's
                        // possible to change the window to be an NSPanel after it's been instantiated?

                        Logger?.LogError("WindowBorderStyle.ToolBox currently doesn't work on macos.");

                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(style), (int)style, style.GetType());
            }
        }

        /// <inheritdoc/>
        public void SetAlwaysOnTop(WindowHandle handle, bool floating)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (floating)
            {
                objc_msgSend(nswindow.Window, selSetLevel, (IntPtr)NSWindowLevel.Floating);
            }
            else
            {
                objc_msgSend(nswindow.Window, selSetLevel, (IntPtr)NSWindowLevel.Normal);
            }
        }

        /// <inheritdoc/>
        public bool IsAlwaysOnTop(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            NSWindowLevel level = (NSWindowLevel)objc_msgSend_IntPtr(nswindow.Window, selLevel);
            if (level == NSWindowLevel.Floating)
            {
                return true;
            }
            else
            {
                // FIXME: Maybe log if level isn't `NSWindowLevel.Normal`?
                return false;
            }
        }

        /// <inheritdoc/>
        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);
            NSCursorHandle? nscursor = cursor?.As<NSCursorHandle>(this);

            nswindow.Cursor = nscursor;

            objc_msgSend(nswindow.Window, selInvalidateCursorRectsForView, nswindow.View);
        }

        /// <inheritdoc/>
        public CursorCaptureMode GetCursorCaptureMode(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void FocusWindow(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            objc_msgSend(nswindow.Window, selMakeKeyAndOrderFront, nswindow.Window);
        }

        /// <inheritdoc/>
        public void RequestAttention(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            // FIXME: Maybe store the requestID so we can cancel the request?
            ulong requestID = objc_msgSend_ulong(nsApplication, selRequestUserAttention, (ulong)NSRequestUserAttentionType.CriticalRequest);
        }

        /// <inheritdoc/>
        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            throw new NotImplementedException();
        }
    }
}
