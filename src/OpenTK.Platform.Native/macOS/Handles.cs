﻿using System;
using OpenTK.Core.Platform;
namespace OpenTK.Platform.Native.macOS
{
    internal class NSWindowHandle : WindowHandle
    {
        public IntPtr Window { get; set; }
        public IntPtr View { get; set; }

        // This is used to implement SwapBuffers
        public NSOpenGLContext? Context { get; set; }

        public NSCursorHandle? Cursor { get; set; }

        public NSIconHandle? Icon { get; set; }

        public bool Destroyed { get; set; } = false;

        public NSWindowHandle(IntPtr window, IntPtr view, GraphicsApiHints graphicsApiHints) : base(graphicsApiHints)
        {
            Window = window;
            View = view;
        }
    }

    internal class NSOpenGLContext : OpenGLContextHandle
    {
        public IntPtr Context { get; set; }

        public NSOpenGLContext? SharedContext { get; private set; }

        public NSOpenGLContext(IntPtr context, NSOpenGLContext? sharedContext)
        {
            Context = context;
            SharedContext = sharedContext;
        }
    }

    // FIXME: Is this an NSScreen handle or a CGDirectDisplay handle?
    internal class NSScreenHandle : DisplayHandle
    {
        public uint DirectDisplayID { get; set; }

        // FIXME: Do we need this?
        public uint UnitNumber { get; set; }

        public IntPtr Screen { get; set; }

        public string Name { get; set; } 

        public bool IsPrimary { get; set; }

        public NSScreenHandle(uint directDisplayID, uint unitNumber, IntPtr screen, string name, bool isPrimary)
        {
            DirectDisplayID = directDisplayID;
            UnitNumber = unitNumber;
            Screen = screen;
            Name = name;
            IsPrimary = isPrimary;
        }
    }

    internal class NSCursorHandle : CursorHandle
    {
        public CursorMode Mode = CursorMode.Uninitialized;

        public IntPtr Cursor;

        public IntPtr[]? CursorFrames;
        /// <summary>Delay between frames.</summary>
        public double Delay = 0;
        /// <summary>Used to keep track of this cursors current animation time.</summary>
        public double Time = 0;
        /// <summary>The current frame.</summary>
        public int Frame = 0;
        
        public NSCursorHandle(CursorMode mode, IntPtr cursor)
        {
            Mode = mode;
            Cursor = cursor;
        }

        public NSCursorHandle(CursorMode mode, IntPtr[] cursorFrames, double delay)
        {
            Mode = mode;
            CursorFrames = cursorFrames;
            Delay = delay;
        }

        internal enum CursorMode
        {
            Uninitialized,
            SystemCursor,
            SystemAnimatedCursor,
            CustomCursor,
            CustomAnimatedCursor,
        }
    }

    internal class NSIconHandle : IconHandle
    {
        public IntPtr Image { get; set; }
        public IntPtr SymbolConfiguration { get; set; }

        public NSIconHandle(IntPtr image)
        {
            Image = image;
        }

        public NSIconHandle(IntPtr image, IntPtr symbolConfiguration)
        {
            Image = image;
            SymbolConfiguration = symbolConfiguration;
        }
    }
}

