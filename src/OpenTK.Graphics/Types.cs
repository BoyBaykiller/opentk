using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
    namespace OpenGL
    {
        public delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    namespace OpenGLES1
    {
        public unsafe delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    namespace OpenGLES3
    {
        public unsafe delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    public struct CLContext
    {
        public IntPtr Value;

        public CLContext(IntPtr value)
        {
            Value = value;
        }

        public static explicit operator CLContext(IntPtr val) => new CLContext(val);
    }

    public struct CLEvent
    {
        public IntPtr Value;

        public CLEvent(IntPtr value)
        {
            Value = value;
        }

        public static explicit operator CLEvent(IntPtr val) => new CLEvent(val);
    }

    public struct GLSync
    {
        public IntPtr Value;

        public GLSync(IntPtr value)
        {
            Value = value;
        }

        public static explicit operator GLSync(IntPtr val) => new GLSync(val);
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GLHandleARB
    {
        [FieldOffset(0)] private readonly uint _value1;
        [FieldOffset(0)] private readonly IntPtr _value2;

        public GLHandleARB(uint val)
        {
            _value2 = IntPtr.Zero;
            _value1 = val;
        }

        public GLHandleARB(IntPtr val)
        {
            _value1 = 0;
            _value2 = val;
        }

        public static explicit operator GLHandleARB(uint val) => new GLHandleARB(val);
        public static explicit operator GLHandleARB(IntPtr val) => new GLHandleARB(val);
        public static explicit operator uint(GLHandleARB val) => val._value1;
        public static explicit operator IntPtr(GLHandleARB val) => val._value2;
    }

    public struct ProgramHandle
    {
        public static readonly ProgramHandle Zero = new ProgramHandle(0);

        public int Handle;

        public ProgramHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is ProgramHandle device && Equals(device);
        }

        public bool Equals([AllowNull] ProgramHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ProgramHandle left, ProgramHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ProgramHandle left, ProgramHandle right)
        {
            return !(left == right);
        }

        public static explicit operator ProgramHandle(int Program1) => new ProgramHandle(Program1);
        public static explicit operator int(ProgramHandle programHandle) => programHandle.Handle;
    }

    public struct ProgramPipelineHandle
    {
        public static readonly ProgramPipelineHandle Zero = new ProgramPipelineHandle(0);

        public int Handle;

        public ProgramPipelineHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is ProgramPipelineHandle device && Equals(device);
        }

        public bool Equals([AllowNull] ProgramPipelineHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ProgramPipelineHandle left, ProgramPipelineHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ProgramPipelineHandle left, ProgramPipelineHandle right)
        {
            return !(left == right);
        }

        public static explicit operator ProgramPipelineHandle(int ProgramPipeline) => new ProgramPipelineHandle(ProgramPipeline);
        public static explicit operator int(ProgramPipelineHandle programPipelineHandle) => programPipelineHandle.Handle;
    }

    public struct TextureHandle
    {
        public static readonly TextureHandle Zero = new TextureHandle(0);

        public int Handle;

        public TextureHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is TextureHandle device && Equals(device);
        }

        public bool Equals([AllowNull] TextureHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(TextureHandle left, TextureHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TextureHandle left, TextureHandle right)
        {
            return !(left == right);
        }

        public static explicit operator TextureHandle(int Texture) => new TextureHandle(Texture);
        public static explicit operator int(TextureHandle textureHandle) => textureHandle.Handle;
    }

    public struct BufferHandle
    {
        public static readonly BufferHandle Zero = new BufferHandle(0);

        public int Handle;

        public BufferHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is BufferHandle device && Equals(device);
        }

        public bool Equals([AllowNull] BufferHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(BufferHandle left, BufferHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(BufferHandle left, BufferHandle right)
        {
            return !(left == right);
        }

        public static explicit operator BufferHandle(int Buffer1) => new BufferHandle(Buffer1);
        public static explicit operator int(BufferHandle bufferHandle) => bufferHandle.Handle;
    }

    public struct ShaderHandle : IEquatable<ShaderHandle>
    {
        public static readonly ShaderHandle Zero = new ShaderHandle(0);

        public int Handle;

        public ShaderHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is ShaderHandle device && Equals(device);
        }

        public bool Equals([AllowNull] ShaderHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ShaderHandle left, ShaderHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ShaderHandle left, ShaderHandle right)
        {
            return !(left == right);
        }

        public static explicit operator ShaderHandle(int shader) => new ShaderHandle(shader);
        public static explicit operator int(ShaderHandle shaderHandle) => shaderHandle.Handle;
    }

    public struct QueryHandle
    {
        public static readonly QueryHandle Zero = new QueryHandle(0);

        public int Handle;

        public QueryHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is QueryHandle device && Equals(device);
        }

        public bool Equals([AllowNull] QueryHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(QueryHandle left, QueryHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(QueryHandle left, QueryHandle right)
        {
            return !(left == right);
        }

        public static explicit operator QueryHandle(int Query) => new QueryHandle(Query);
        public static explicit operator int(QueryHandle queryHandle) => queryHandle.Handle;
    }

    public struct FramebufferHandle
    {
        public static readonly FramebufferHandle Zero = new FramebufferHandle(0);

        public int Handle;

        public FramebufferHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is FramebufferHandle device && Equals(device);
        }

        public bool Equals([AllowNull] FramebufferHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(FramebufferHandle left, FramebufferHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(FramebufferHandle left, FramebufferHandle right)
        {
            return !(left == right);
        }

        public static explicit operator FramebufferHandle(int Framebuffer) => new FramebufferHandle(Framebuffer);
        public static explicit operator int(FramebufferHandle framebufferHandle) => framebufferHandle.Handle;
    }

    public struct RenderbufferHandle
    {
        public static readonly RenderbufferHandle Zero = new RenderbufferHandle(0);

        public int Handle;

        public RenderbufferHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is RenderbufferHandle device && Equals(device);
        }

        public bool Equals([AllowNull] RenderbufferHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(RenderbufferHandle left, RenderbufferHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(RenderbufferHandle left, RenderbufferHandle right)
        {
            return !(left == right);
        }

        public static explicit operator RenderbufferHandle(int Renderbuffer) => new RenderbufferHandle(Renderbuffer);
        public static explicit operator int(RenderbufferHandle renderbufferHandle) => renderbufferHandle.Handle;
    }

    public struct SamplerHandle
    {
        public static readonly SamplerHandle Zero = new SamplerHandle(0);

        public int Handle;

        public SamplerHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is SamplerHandle device && Equals(device);
        }

        public bool Equals([AllowNull] SamplerHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(SamplerHandle left, SamplerHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(SamplerHandle left, SamplerHandle right)
        {
            return !(left == right);
        }

        public static explicit operator SamplerHandle(int Sampler) => new SamplerHandle(Sampler);
        public static explicit operator int(SamplerHandle samplerHandle) => samplerHandle.Handle;
    }

    public struct TransformFeedbackHandle
    {
        public static readonly TransformFeedbackHandle Zero = new TransformFeedbackHandle(0);

        public int Handle;

        public TransformFeedbackHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is TransformFeedbackHandle device && Equals(device);
        }

        public bool Equals([AllowNull] TransformFeedbackHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(TransformFeedbackHandle left, TransformFeedbackHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TransformFeedbackHandle left, TransformFeedbackHandle right)
        {
            return !(left == right);
        }

        public static explicit operator TransformFeedbackHandle(int TransformFeedback) => new TransformFeedbackHandle(TransformFeedback);
        public static explicit operator int(TransformFeedbackHandle transformFeedbackHandle) => transformFeedbackHandle.Handle;
    }

    public struct VertexArrayHandle
    {
        public static readonly VertexArrayHandle Zero = new VertexArrayHandle(0);

        public int Handle;

        public VertexArrayHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is VertexArrayHandle device && Equals(device);
        }

        public bool Equals([AllowNull] VertexArrayHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(VertexArrayHandle left, VertexArrayHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(VertexArrayHandle left, VertexArrayHandle right)
        {
            return !(left == right);
        }

        public static explicit operator VertexArrayHandle(int VertexArray) => new VertexArrayHandle(VertexArray);
        public static explicit operator int(VertexArrayHandle vertexArrayHandle) => vertexArrayHandle.Handle;
    }

    public struct DisplayListHandle
    {
        public static readonly DisplayListHandle Zero = new DisplayListHandle(0);

        public int Handle;

        public DisplayListHandle(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is DisplayListHandle device && Equals(device);
        }

        public bool Equals([AllowNull] DisplayListHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(DisplayListHandle left, DisplayListHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DisplayListHandle left, DisplayListHandle right)
        {
            return !(left == right);
        }

        public static explicit operator DisplayListHandle(int DisplayList) => new DisplayListHandle(DisplayList);
        public static explicit operator int(DisplayListHandle displayListHandle) => displayListHandle.Handle;
    }
}
