namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open OpenTK.Mathematics

module Matrix4 =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors =
        //
        [<Property>]
        let ``Sixteen value constructor sets all components to the correct values`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            Assert.Equal(a, A.M11)
            Assert.Equal(b, A.M12)
            Assert.Equal(c, A.M13)
            Assert.Equal(d, A.M14)

            Assert.Equal(e, A.M21)
            Assert.Equal(f, A.M22)
            Assert.Equal(g, A.M23)
            Assert.Equal(h, A.M24)

            Assert.Equal(i, A.M31)
            Assert.Equal(j, A.M32)
            Assert.Equal(k, A.M33)
            Assert.Equal(l, A.M34)

            Assert.Equal(m, A.M41)
            Assert.Equal(n, A.M42)
            Assert.Equal(o, A.M43)
            Assert.Equal(p, A.M44)

        [<Property>]
        let ``Matrix3 partial constructor sets all components to the correct values`` (a, b, c, d, e, f, g, h, i) =
            let B = Matrix3(a, b, c, d, e, f, g, h, i)
            let A = Matrix4(B)

            Assert.Equal(a, A.M11)
            Assert.Equal(b, A.M12)
            Assert.Equal(c, A.M13)
            Assert.Equal(0.0f, A.M14)

            Assert.Equal(d, A.M21)
            Assert.Equal(e, A.M22)
            Assert.Equal(f, A.M23)
            Assert.Equal(0.0f, A.M24)

            Assert.Equal(g, A.M31)
            Assert.Equal(h, A.M32)
            Assert.Equal(i, A.M33)
            Assert.Equal(0.0f, A.M34)

            Assert.Equal(0.0f, A.M41)
            Assert.Equal(0.0f, A.M42)
            Assert.Equal(0.0f, A.M43)
            Assert.Equal(1.0f, A.M44)

        [<Property>]
        let ``Four-vector4 constructor sets all components to the correct values`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let v1 = Vector4(a, b, c, d)
            let v2 = Vector4(e, f, g, h)
            let v3 = Vector4(i, j, k, l)
            let v4 = Vector4(m, n, o, p)

            let A = Matrix4(v1, v2, v3, v4)

            Assert.Equal(a, A.M11)
            Assert.Equal(b, A.M12)
            Assert.Equal(c, A.M13)
            Assert.Equal(d, A.M14)

            Assert.Equal(e, A.M21)
            Assert.Equal(f, A.M22)
            Assert.Equal(g, A.M23)
            Assert.Equal(h, A.M24)

            Assert.Equal(i, A.M31)
            Assert.Equal(j, A.M32)
            Assert.Equal(k, A.M33)
            Assert.Equal(l, A.M34)

            Assert.Equal(m, A.M41)
            Assert.Equal(n, A.M42)
            Assert.Equal(o, A.M43)
            Assert.Equal(p, A.M44)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Equality =
        //
        [<Property>]
        let ``Two matrices with identical values are equal`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)
            let B = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)
            let equality = A = B

            Assert.True(equality)

        [<Property>]
        let ``A matrix is not equal to an object which is not a matrix`` (a : Matrix4, b : Vector3) =
            Assert.False(a.Equals(b))

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Multiplication =
        //
        [<Property>]
        let ``Matrix multiplication is done by row/column multiplication and summation`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)
            let B = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            let R11 = a*a + b*e + c*i + d*m
            let R12 = a*b + b*f + c*j + d*n
            let R13 = a*c + b*g + c*k + d*o
            let R14 = a*d + b*h + c*l + d*p

            let R21 = e*a + f*e + g*i + h*m
            let R22 = e*b + f*f + g*j + h*n
            let R23 = e*c + f*g + g*k + h*o
            let R24 = e*d + f*h + g*l + h*p

            let R31 = i*a + j*e + k*i + l*m
            let R32 = i*b + j*f + k*j + l*n
            let R33 = i*c + j*g + k*k + l*o
            let R34 = i*d + j*h + k*l + l*p

            let R41 = m*a + n*e + o*i + p*m
            let R42 = m*b + n*f + o*j + p*n
            let R43 = m*c + n*g + o*k + p*o
            let R44 = m*d + n*h + o*l + p*p

            let AB = A*B

            Assert.Equal(R11, AB.M11)
            Assert.Equal(R12, AB.M12)
            Assert.Equal(R13, AB.M13)
            Assert.Equal(R14, AB.M14)

            Assert.Equal(R21, AB.M21)
            Assert.Equal(R22, AB.M22)
            Assert.Equal(R23, AB.M23)
            Assert.Equal(R24, AB.M24)

            Assert.Equal(R31, AB.M31)
            Assert.Equal(R32, AB.M32)
            Assert.Equal(R33, AB.M33)
            Assert.Equal(R34, AB.M34)

            Assert.Equal(R41, AB.M41)
            Assert.Equal(R42, AB.M42)
            Assert.Equal(R43, AB.M43)
            Assert.Equal(R44, AB.M44)

        [<Property>]
        let ``Matrix multiplication by scalar is the same as row multiplication by scalar`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, scalar : float32) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            let R1 = Vector4(a, b, c, d) * scalar
            let R2 = Vector4(e, f, g, h) * scalar
            let R3 = Vector4(i, j, k, l) * scalar
            let R4 = Vector4(m, n, o, p) * scalar

            let AScaled = A * scalar

            Assert.Equal(R1, AScaled.Row0)
            Assert.Equal(R2, AScaled.Row1)
            Assert.Equal(R3, AScaled.Row2)
            Assert.Equal(R4, AScaled.Row3)

        [<Property>]
        let ``Static method matrix multiplication by scalar is the same as row multiplication by scalar`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, scalar : float32) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            let R1 = Vector4(a, b, c, d) * scalar
            let R2 = Vector4(e, f, g, h) * scalar
            let R3 = Vector4(i, j, k, l) * scalar
            let R4 = Vector4(m, n, o, p) * scalar

            let AScaled = Matrix4.Mult(A, scalar)

            Assert.Equal(R1, AScaled.Row0)
            Assert.Equal(R2, AScaled.Row1)
            Assert.Equal(R3, AScaled.Row2)
            Assert.Equal(R4, AScaled.Row3)

        [<Property>]
        let ``Static method matrix multiplication by reference by scalar is the same as row multiplication by scalar`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, scalar : float32) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            let R1 = Vector4(a, b, c, d) * scalar
            let R2 = Vector4(e, f, g, h) * scalar
            let R3 = Vector4(i, j, k, l) * scalar
            let R4 = Vector4(m, n, o, p) * scalar

            let AScaled = Matrix4.Mult(&A, scalar)

            Assert.Equal(R1, AScaled.Row0)
            Assert.Equal(R2, AScaled.Row1)
            Assert.Equal(R3, AScaled.Row2)
            Assert.Equal(R4, AScaled.Row3)


    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Addition =
        //
        [<Property>]
        let ``Matrix addition adds corresponding components`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)
            let B = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            let sum = A + B

            Assert.Equal(a + a, sum.M11)
            Assert.Equal(b + b, sum.M12)
            Assert.Equal(c + c, sum.M13)
            Assert.Equal(d + d, sum.M14)

            Assert.Equal(e + e, sum.M21)
            Assert.Equal(f + f, sum.M22)
            Assert.Equal(g + g, sum.M23)
            Assert.Equal(h + h, sum.M24)

            Assert.Equal(i + i, sum.M31)
            Assert.Equal(j + j, sum.M32)
            Assert.Equal(k + k, sum.M33)
            Assert.Equal(l + l, sum.M34)

            Assert.Equal(m + m, sum.M41)
            Assert.Equal(n + n, sum.M42)
            Assert.Equal(o + o, sum.M43)
            Assert.Equal(p + p, sum.M44)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Subtraction =
        //
        [<Property>]
        let ``Matrix subtraction subtracts corresponding components`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)
            let B = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            let sub = A - B

            Assert.Equal(a - a, sub.M11)
            Assert.Equal(b - b, sub.M12)
            Assert.Equal(c - c, sub.M13)
            Assert.Equal(d - d, sub.M14)

            Assert.Equal(e - e, sub.M21)
            Assert.Equal(f - f, sub.M22)
            Assert.Equal(g - g, sub.M23)
            Assert.Equal(h - h, sub.M24)

            Assert.Equal(i - i, sub.M31)
            Assert.Equal(j - j, sub.M32)
            Assert.Equal(k - k, sub.M33)
            Assert.Equal(l - l, sub.M34)

            Assert.Equal(m - m, sub.M41)
            Assert.Equal(n - n, sub.M42)
            Assert.Equal(o - o, sub.M43)
            Assert.Equal(p - p, sub.M44)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Indexing =
        //
        [<Property>]
        let ``Matrix set indexing sets correct components`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let mutable A = Matrix4()

            A.[0, 0] <- a
            A.[0, 1] <- b
            A.[0, 2] <- c
            A.[0, 3] <- d

            A.[1, 0] <- e
            A.[1, 1] <- f
            A.[1, 2] <- g
            A.[1, 3] <- h

            A.[2, 0] <- i
            A.[2, 1] <- j
            A.[2, 2] <- k
            A.[2, 3] <- l

            A.[3, 0] <- m
            A.[3, 1] <- n
            A.[3, 2] <- o
            A.[3, 3] <- p

            Assert.Equal(a, A.M11)
            Assert.Equal(b, A.M12)
            Assert.Equal(c, A.M13)
            Assert.Equal(d, A.M14)

            Assert.Equal(e, A.M21)
            Assert.Equal(f, A.M22)
            Assert.Equal(g, A.M23)
            Assert.Equal(h, A.M24)

            Assert.Equal(i, A.M31)
            Assert.Equal(j, A.M32)
            Assert.Equal(k, A.M33)
            Assert.Equal(l, A.M34)

            Assert.Equal(m, A.M41)
            Assert.Equal(n, A.M42)
            Assert.Equal(o, A.M43)
            Assert.Equal(p, A.M44)

        [<Property>]
        let ``Matrix get indexing accesses the correct components`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            Assert.Equal(a, A.[0, 0])
            Assert.Equal(b, A.[0, 1])
            Assert.Equal(c, A.[0, 2])
            Assert.Equal(d, A.[0, 3])

            Assert.Equal(e, A.[1, 0])
            Assert.Equal(f, A.[1, 1])
            Assert.Equal(g, A.[1, 2])
            Assert.Equal(h, A.[1, 3])

            Assert.Equal(i, A.[2, 0])
            Assert.Equal(j, A.[2, 1])
            Assert.Equal(k, A.[2, 2])
            Assert.Equal(l, A.[2, 3])

            Assert.Equal(m, A.[3, 0])
            Assert.Equal(n, A.[3, 1])
            Assert.Equal(o, A.[3, 2])
            Assert.Equal(p, A.[3, 3])


        [<Property>]
        let ``Indexed set operator throws exception for negative indices`` (b : Matrix4, x : float32) =
            let mutable a = b

            (fun() -> a.[-1, 2] <- x) |> Assert.ThrowsIndexExn
            (fun() -> a.[1, -2] <- x) |> Assert.ThrowsIndexExn
            (fun() -> a.[-1, -2] <- x) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed get operator throws exception for negative indices`` (a : Matrix4) =
            (fun() -> a.[-1, 2] |> ignore) |> Assert.ThrowsIndexExn
            (fun() -> a.[1, -2] |> ignore) |> Assert.ThrowsIndexExn
            (fun() -> a.[-1, -2] |> ignore) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed set operator throws exception for large indices`` (a : Matrix4, x : float32) =
            let mutable b = a
            (fun() -> b.[5, 2] <- x) |> Assert.ThrowsIndexExn
            (fun() -> b.[1, 6] <- x) |> Assert.ThrowsIndexExn
            (fun() -> b.[7, 12] <- x) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed get operator throws exception for large indices`` (a : Matrix4) =
            (fun() -> a.[5, 2] |> ignore) |> Assert.ThrowsIndexExn
            (fun() -> a.[1, 6] |> ignore) |> Assert.ThrowsIndexExn
            (fun() -> a.[7, 12] |> ignore) |> Assert.ThrowsIndexExn

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Row and column properties`` =
        //
        [<Property>]
        let ``Matrix row properties return the correct components`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let A = Matrix4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            let R0 = A.Row0
            let R1 = A.Row1
            let R2 = A.Row2
            let R3 = A.Row3

            Assert.Equal(a, R0.X)
            Assert.Equal(b, R0.Y)
            Assert.Equal(c, R0.Z)
            Assert.Equal(d, R0.W)

            Assert.Equal(e, R1.X)
            Assert.Equal(f, R1.Y)
            Assert.Equal(g, R1.Z)
            Assert.Equal(h, R1.W)

            Assert.Equal(i, R2.X)
            Assert.Equal(j, R2.Y)
            Assert.Equal(k, R2.Z)
            Assert.Equal(l, R2.W)

            Assert.Equal(m, R3.X)
            Assert.Equal(n, R3.Y)
            Assert.Equal(o, R3.Z)
            Assert.Equal(p, R3.W)

        [<Property>]
        let ``Matrix4_CreateSwizzle should equal Matrix4_Swizzle Indentity`` () =
            let checkSwizzle (x : int, y : int, z : int, w : int) = 
                let m1 = Matrix4.Identity * Matrix4.CreateSwizzle(x, y, z, w);
                let m2 = Matrix4.Swizzle(Matrix4.Identity, x, y, z, w);

                Assert.Equal(m1[0, 0], m2[0, 0]);
                Assert.Equal(m1[0, 1], m2[0, 1]);
                Assert.Equal(m1[0, 2], m2[0, 2]);
                Assert.Equal(m1[0, 3], m2[0, 3]);
                Assert.Equal(m1[1, 0], m2[1, 0]);
                Assert.Equal(m1[1, 1], m2[1, 1]);
                Assert.Equal(m1[1, 2], m2[1, 2]);
                Assert.Equal(m1[1, 3], m2[1, 3]);
                Assert.Equal(m1[2, 0], m2[2, 0]);
                Assert.Equal(m1[2, 1], m2[2, 1]);
                Assert.Equal(m1[2, 2], m2[2, 2]);
                Assert.Equal(m1[2, 3], m2[2, 3]);
                Assert.Equal(m1[3, 0], m2[3, 0]);
                Assert.Equal(m1[3, 1], m2[3, 1]);
                Assert.Equal(m1[3, 2], m2[3, 2]);
                Assert.Equal(m1[3, 3], m2[3, 3]);

            for x = 0 to 3 do
                for y = 0 to 3 do
                    for z = 0 to 3 do
                        for w = 0 to 3 do
                            checkSwizzle(x, y, z, w)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Quaternion conversion`` =
        //
        [<Property>]
        let ``Quaternion to Matrix4 equals Quaternion to AxisAngle to Matrix4`` (q: Quaternion) =
            let A = Matrix4.CreateFromQuaternion(q)
            let axis, angle = q.ToAxisAngle()
            let B = Matrix4.CreateFromAxisAngle(axis, angle)

            let epsilon = 0.00001f;

            Assert.ApproximatelyEqualDelta(A.M11, B.M11, epsilon)
            Assert.ApproximatelyEqualDelta(A.M12, B.M12, epsilon)
            Assert.ApproximatelyEqualDelta(A.M13, B.M13, epsilon)
            Assert.ApproximatelyEqualDelta(A.M14, B.M14, epsilon)

            Assert.ApproximatelyEqualDelta(A.M21, B.M21, epsilon)
            Assert.ApproximatelyEqualDelta(A.M22, B.M22, epsilon)
            Assert.ApproximatelyEqualDelta(A.M23, B.M23, epsilon)
            Assert.ApproximatelyEqualDelta(A.M24, B.M24, epsilon)

            Assert.ApproximatelyEqualDelta(A.M31, B.M31, epsilon)
            Assert.ApproximatelyEqualDelta(A.M32, B.M32, epsilon)
            Assert.ApproximatelyEqualDelta(A.M33, B.M33, epsilon)
            Assert.ApproximatelyEqualDelta(A.M34, B.M34, epsilon)

            Assert.ApproximatelyEqualDelta(A.M41, B.M41, epsilon)
            Assert.ApproximatelyEqualDelta(A.M42, B.M42, epsilon)
            Assert.ApproximatelyEqualDelta(A.M43, B.M43, epsilon)
            Assert.ApproximatelyEqualDelta(A.M44, B.M44, epsilon)

        [<Property>]
        let ``Quaternion to Matrix3 equals Quaternion to AxisAngle to Matrix3`` (q: Quaternion) =
            let A = Matrix3.CreateFromQuaternion(q)
            let axis, angle = q.ToAxisAngle()
            let B = Matrix3.CreateFromAxisAngle(axis, angle)

            let epsilon = 0.00001f;

            Assert.ApproximatelyEqualDelta(A.M11, B.M11, epsilon)
            Assert.ApproximatelyEqualDelta(A.M12, B.M12, epsilon)
            Assert.ApproximatelyEqualDelta(A.M13, B.M13, epsilon)

            Assert.ApproximatelyEqualDelta(A.M21, B.M21, epsilon)
            Assert.ApproximatelyEqualDelta(A.M22, B.M22, epsilon)
            Assert.ApproximatelyEqualDelta(A.M23, B.M23, epsilon)

            Assert.ApproximatelyEqualDelta(A.M31, B.M31, epsilon)
            Assert.ApproximatelyEqualDelta(A.M32, B.M32, epsilon)
            Assert.ApproximatelyEqualDelta(A.M33, B.M33, epsilon)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Extraction functions`` =
        //
        [<Property>]
        let ``Matrix4.ExtractPerspectiveOffCenter returns what was passed to CreatePerspectiveOffCenter`` (rightLeft: Range, bottomTop: Range, nearFar : PositiveRange) =
            let right = rightLeft.Start
            let left = rightLeft.Stop
            let bottom = bottomTop.Start
            let top = bottomTop.Stop
            let near = nearFar.Start
            let far = nearFar.Stop
            let A = Matrix4.CreatePerspectiveOffCenter(right, left, bottom, top, near, far)

            let mutable exRight = 0.0f
            let mutable exLeft = 0.0f
            let mutable exBottom = 0.0f
            let mutable exTop = 0.0f
            let mutable exNear = 0.0f
            let mutable exFar = 0.0f
            A.ExtractPerspectiveOffCenter(&exRight, &exLeft, &exBottom, &exTop, &exNear, &exFar)

            Assert.ApproximatelyEqual(right, exRight)
            Assert.ApproximatelyEqual(left, exLeft)
            Assert.ApproximatelyEqual(bottom, exBottom)
            Assert.ApproximatelyEqual(top, exTop)
            Assert.ApproximatelyEqual(near, exNear)
            Assert.ApproximatelyEqual(far, exFar)

        [<Property>]
        let ``Matrix4.ExtractPerspectiveFieldOfView returns what was passed to CreatePerspectiveFieldOfView`` (AcuteAngle fovy, aspect: float32, nearFar : PositiveRange) =
            let fovy = MathHelper.Abs(fovy)
            let aspect = MathHelper.Abs(aspect)
            let near = nearFar.Start
            let far = nearFar.Stop
            let A = Matrix4.CreatePerspectiveFieldOfView(fovy, aspect, near, far)

            let mutable exFovy = 0.0f
            let mutable exAspect = 0.0f
            let mutable exNear = 0.0f
            let mutable exFar = 0.0f
            A.ExtractPerspectiveFieldOfView(&exFovy, &exAspect, &exNear, &exFar)

            Assert.ApproximatelyEqual(fovy, exFovy)
            Assert.ApproximatelyEqual(aspect, exAspect)
            Assert.ApproximatelyEqual(near, exNear)
            Assert.ApproximatelyEqual(far, exFar)
        
        [<Property>]
        let ``Matrix4.ExtractOrthographicOffCenter returns what was passed to CreateOrthographicOffCenter`` (rightLeft: Range, bottomTop: Range, nearFar : PositiveRange) =
            let right = rightLeft.Start
            let left = rightLeft.Stop
            let bottom = bottomTop.Start
            let top = bottomTop.Stop
            let near = nearFar.Start
            let far = nearFar.Stop
            let A = Matrix4.CreateOrthographicOffCenter(right, left, bottom, top, near, far)

            let mutable exRight = 0.0f
            let mutable exLeft = 0.0f
            let mutable exBottom = 0.0f
            let mutable exTop = 0.0f
            let mutable exNear = 0.0f
            let mutable exFar = 0.0f
            A.ExtractOrthographicOffCenter(&exRight, &exLeft, &exBottom, &exTop, &exNear, &exFar)

            Assert.ApproximatelyEqual(right, exRight);
            Assert.ApproximatelyEqual(left, exLeft);
            Assert.ApproximatelyEqual(bottom, exBottom);
            Assert.ApproximatelyEqual(top, exTop);
            Assert.ApproximatelyEqual(near, exNear);
            Assert.ApproximatelyEqual(far, exFar);

        [<Property>]
        let ``Matrix4.ExtractPerspectiveFieldOfView returns what was passed to CreateOrthographic`` (widthHeight: PositiveRange, nearFar : PositiveRange) =
            let width = widthHeight.Start
            let height = widthHeight.Stop
            let near = nearFar.Start
            let far = nearFar.Stop
            let A = Matrix4.CreateOrthographic(width, height, near, far)

            let mutable exWidth = 0.0f
            let mutable exHeight = 0.0f
            let mutable exNear = 0.0f
            let mutable exFar = 0.0f
            A.ExtractOrthographic(&exWidth, &exHeight, &exNear, &exFar)

            Assert.ApproximatelyEqual(width, exWidth);
            Assert.ApproximatelyEqual(height, exHeight);
            Assert.ApproximatelyEqual(near, exNear);
            Assert.ApproximatelyEqual(far, exFar);