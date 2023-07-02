using System;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Wrapper for the native library libX11.so.
    /// </summary>
    internal static class LibX11
    {
        private const string X11 = "X11";

        static LibX11()
        {
            DllResolver.InitLoader();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal unsafe delegate int XErrorHandler(XDisplayPtr display, XErrorEvent* error_event);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSetErrorHandler(XErrorHandler handler);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XGetErrorText(XDisplayPtr display, int code, [Out, MarshalAs(UnmanagedType.LPUTF8Str)] StringBuilder buffer_return, int length);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XDisplayPtr XOpenDisplay([MarshalAs(UnmanagedType.LPStr)]string? name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XDefaultScreen(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XScreenCount(XDisplayPtr dispay);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong XBlackPixel(XDisplayPtr display, int screenNumber);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong XWhitePixel(XDisplayPtr display, int screenNumber);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XWindow XCreateSimpleWindow(
            XDisplayPtr display,
            XWindow parent,
            int x,
            int y,
            uint width,
            uint height,
            ulong border,
            ulong background);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XWindow XCreateWindow(
            XDisplayPtr display,
            XWindow parent,
            int x,
            int y,
            uint width,
            uint height,
            uint border,
            int depth,
            uint @class,
            ref XVisual visual,
            XWindowAttributeValueMask valueMask,
            ref XSetWindowAttributes attributes);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XConfigureWindow(XDisplayPtr display, XWindow w, XWindowChangesMask value_mask, ref XWindowChanges values);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XMoveWindow(XDisplayPtr display, XWindow w, int x, int y);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XResizeWindow(XDisplayPtr display, XWindow w, int width, int height);
        
        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XMoveResizeWindow(XDisplayPtr display, XWindow w, int x, int y, uint width, uint height);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XDisplayWidth(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XDisplayHeight(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XSetWMNormalHints(XDisplayPtr display, XWindow w, XSizeHints* hints);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int /* Status */ XGetWMNormalHints(XDisplayPtr display, XWindow w, XSizeHints* hints_return, XSizeHintFlags* supplied_return);

        internal struct XWMHints
        {
            internal XWMHintsMask flags;  /* marks which fields in this structure are defined */
            internal byte input;          /* does this application rely on the window manager to get keyboard input? */
            internal int initial_state;	/* see below */
            internal XPixmap icon_pixmap; /* pixmap to be used as icon */
            internal XWindow icon_window; /* window to be used as icon */
            internal int icon_x, icon_y;  /* initial position of icon */
            internal XPixmap icon_mask;   /* pixmap to be used as mask for icon_pixmap */
            internal XID window_group;    /* id of related window group */
            /* this structure may be extended in the future */
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XWMHints* XAllocWMHints();

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XWMHints* XGetWMHints(XDisplayPtr display, XWindow w);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XSetWMHints(XDisplayPtr display, XWindow w, XWMHints* wmhints);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XSizeHints* XAllocSizeHints();

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSelectInput(XDisplayPtr display, XWindow xWindow, XEventMask events);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XWindow XDefaultRootWindow(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XWindow XRootWindow(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XSetStandardProperties(
            XDisplayPtr display,
            XWindow window,
            [MarshalAs(UnmanagedType.LPStr)]string windowName,
            [MarshalAs(UnmanagedType.LPStr)]string iconName,
            XPixmap iconPixmap,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[]? argv,
            int argc,
            ref XSizeHints hints);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XGC XCreateGC(XDisplayPtr display, XDrawable drawable, long valueMask,
            IntPtr values);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSetBackground(XDisplayPtr display, XGC gc, ulong background);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSetForeground(XDisplayPtr display, XGC gc, ulong background);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XClearWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XMapRaised(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XMapWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XUnmapWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XWithdrawWindow(XDisplayPtr display, XWindow w, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XFreeGC(XDisplayPtr display, XGC gc);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XDestroyWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XCloseDisplay(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XNextEvent(XDisplayPtr display, out XEvent @event);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XFree(IntPtr pointer);
        
        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int XFree(void* pointer);

        internal static unsafe int XFree<T>(Span<T> span)
        {
            return XFree(Unsafe.AsPointer(ref MemoryMarshal.GetReference(span)));
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XColorMap XCreateColormap(
            XDisplayPtr display,
            XWindow window,
            ref XVisual visual,
            int alloc);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XColorMap XDefaultColormap(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XFreeColormap(XDisplayPtr display, XColorMap colormap);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XStoreName(XDisplayPtr display, XWindow window, [MarshalAs(UnmanagedType.LPStr)]string name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XGetWindowAttributes(
            XDisplayPtr display,
            XWindow window,
            out XWindowAttributes attributes);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XTranslateCoordinates(
            XDisplayPtr display,
            XWindow source,
            XWindow destination,
            int sourceX,
            int sourceY,
            out int destinationX,
            out int destinationY,
            out XWindow child);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSendEvent(
            XDisplayPtr display,
            XWindow window,
            int propagate,
            XEventMask eventMask,
            in XEvent ea);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XEventsQueued(XDisplayPtr display, XEventsQueuedMode mode);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XFetchName(XDisplayPtr display, XWindow window, out IntPtr name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XAtom XInternAtom(XDisplayPtr display, string atomName, bool onlyIfExists);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XInternAtoms(
            XDisplayPtr display,
            ref IntPtr names,
            int count,
            bool onlyIfExists,
            ref XAtom atoms);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPUTF8Str)]
        internal static extern string XGetAtomName(XDisplayPtr display, XAtom atom);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XGetWindowProperty(
            XDisplayPtr display,
            XWindow window,
            XAtom property,
            long offset,
            long length,
            [MarshalAs(UnmanagedType.I1)] bool delete,
            XAtom requestType,
            out XAtom actualType,
            out int actualFormat,
            out long numberOfItems,
            out long remainingBytes,
            out IntPtr contents
        );

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XChangeProperty(
            XDisplayPtr display,
            XWindow window,
            XAtom property,
            XAtom propertyType,
            int format,
            XPropertyMode mode,
            IntPtr data,
            int elements
        );

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XSetInputFocus(XDisplayPtr display, XWindow focus, RevertTo revert_to, XTime time);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XRaiseWindow(XDisplayPtr display, XWindow w);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFlush(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XSetWMProtocols(XDisplayPtr display, XWindow w, [In] XAtom[] protocols, int count);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XCursor XCreateFontCursor(XDisplayPtr display, XCursorShape shape);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XDefineCursor(XDisplayPtr display, XWindow w, XCursor cursor);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XUndefineCursor(XDisplayPtr display, XWindow w);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFreeCursor(XDisplayPtr display, XCursor cursor);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte XQueryPointer(
            XDisplayPtr display,
            XWindow w,
            out XWindow root_return,
            out XWindow child_return,
            out int root_x_return,
            out int root_y_return,
            out int win_x_return,
            out int win_y_return,
            out uint mask_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XWarpPointer(
            XDisplayPtr display,
            XWindow src_w,
            XWindow dest_w,
            int src_x,
            int src_y,
            uint src_width,
            uint src_height,
            int dest_x,
            int dest_y);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XPixmap XCreatePixmap(XDisplayPtr display, XDrawable d, int width, int height, int depth);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFreePixmap(XDisplayPtr display, XPixmap pixmap);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XPixmap XCreateBitmapFromData(XDisplayPtr display, XDrawable d, byte* data, int width, int height);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XCursor XCreatePixmapCursor(XDisplayPtr display, XPixmap source, XPixmap mask, XColorPtr foreground_color, XColorPtr background_color, int x, int y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal unsafe delegate bool XPredicate(XDisplayPtr display, ref XEvent @event, IntPtr arg);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal static extern bool XCheckIfEvent(XDisplayPtr display, out XEvent event_return, XPredicate predicate, IntPtr arg);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XIconifyWindow(XDisplayPtr display, XWindow w, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GrabResult XGrabPointer(
            XDisplayPtr display,
            XWindow grab_window,
            [MarshalAs(UnmanagedType.I1)] bool owner_events,
            XEventMask event_mask,
            GrabMode pointer_mode,
            GrabMode keyboard_mode,
            XWindow confine_to,
            XCursor cursor,
            XTime time);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XUngrabPointer(XDisplayPtr display, XTime time);

        internal static unsafe string[] XListExtensions(XDisplayPtr display, out int nextensions_return)
        {
            byte** ptr = XListExtensions(display, out nextensions_return);

            string[] strings = new string[nextensions_return];
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = Marshal.PtrToStringUTF8((IntPtr)ptr[i]) ?? throw new NullReferenceException("XListExtensions() returned null string.");
            }
            
            return strings;

            [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
            static unsafe extern byte** XListExtensions(XDisplayPtr display, out int nextensions_return);
        }
        
    }
}
