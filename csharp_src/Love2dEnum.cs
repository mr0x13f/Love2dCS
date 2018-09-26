﻿namespace Love
{
    /// <summary>
    /// Different types of arcs that can be drawn.
    /// </summary>
    public enum ArcType : int
    {
        /// <summary>
        /// The arc circle's two end-points are unconnected when the arc is drawn as a line. Behaves like the "closed" arc type when the arc is drawn in filled mode.
        /// </summary>
        Open,

        /// <summary>
        /// The arc circle's two end-points are connected to each other.
        /// </summary>
        Closed,

        /// <summary>
        /// The arc is drawn like a slice of pie, with the arc circle connected to the center at its end-points.
        /// </summary>
        Pie,
    };


    public enum BlendMode : int
    {
        /// <summary>
        /// Alpha blending (normal). The alpha of what's drawn determines its opacity.
        /// </summary>
        Alpha,

        /// <summary>
        /// The pixel colors of what's drawn are added to the pixel colors already on the screen. The alpha of the screen is not modified.
        /// </summary>
        Add,

        /// <summary>
        /// The pixel colors of what's drawn are subtracted from the pixel colors already on the screen. The alpha of the screen is not modified.
        /// </summary>
        Subtract,

        /// <summary>
        /// The pixel colors of what's drawn are multiplied with the pixel colors already on the screen (darkening them). The alpha of drawn objects is multiplied with the alpha of the screen rather than determining how much the colors on the screen are affected, even when the <see cref="Graphics.BlendAlphaMode.PreMultiplied"/> BlendAlphaMode is used.
        /// </summary>
        Multiply,

        /// <summary>
        /// The pixel colors of what's drawn are compared to the existing pixel colors, and the larger of the two values for each color component is used. Only works when the "premultiplied" BlendAlphaMode is used in <see cref="Graphics.SetBlendMode"/>
        /// </summary>
        Lighten,

        /// <summary>
        /// The pixel colors of what's drawn are compared to the existing pixel colors, and the smaller of the two values for each color component is used. Only works when the "premultiplied" BlendAlphaMode is used in <see cref="Graphics.SetBlendMode"/>
        /// </summary>
        Darken,

        /// <summary>
        /// 'Screen' blending.
        /// </summary>
        Screen,

        /// <summary>
        /// The colors of what's drawn completely replace what was on the screen, with no additional blending. The BlendAlphaMode specified in love.graphics.setBlendMode still affects what happens.
        /// </summary>
        Replace,
    };


    /// <summary>
    /// The "premultiplied" constant should generally be used when drawing a Canvas to the screen, because the RGB values of the Canvas' texture had previously been multiplied by its alpha values when drawing content to the Canvas itself.
    /// <para>The "alphamultiply" constant does not affect the "multiply" BlendMode.Similarly, the "screen" BlendMode's math is only correct if the "premultiplied" alpha mode is used and the alpha of drawn objects has already been multiplied with its RGB values previously (possibly inside a shader).</para>
    /// <para>https://love2d.org/wiki/BlendAlphaMode</para>
    /// </summary>
    public enum BlendAlphaMode : int
    {
        /// <summary>
        /// The RGB values of what's drawn are multiplied by the alpha values of those colors during blending. This is the default alpha mode.
        /// </summary>
        Multiply,

        /// <summary>
        /// The RGB values of what's drawn are not multiplied by the alpha values of those colors during blending. For most blend modes to work correctly with this alpha mode, the colors of a drawn object need to have had their RGB values multiplied by their alpha values at some point previously ("premultiplied alpha").
        /// </summary>
        PreMultiplied,
    };
    public enum LineStyle : int
    {
        Rough,
        Smooth,
    };

    /// <summary>
    /// https://love2d.org/wiki/LineJoin
    /// </summary>
    public enum LineJoin : int
    {
        /// <summary>
        /// No cap applied to the ends of the line segments.
        /// <para>https://love2d.org/wiki/LineJoin</para>
        /// </summary>
        None,

        /// <summary>
        /// The ends of the line segments beveled in an angle so that they join seamlessly.
        /// <para>https://love2d.org/wiki/LineJoin</para>
        /// </summary>
        Miter,

        /// <summary>
        /// Flattens the point where line segments join together.
        /// <para>https://love2d.org/wiki/LineJoin</para>
        /// </summary>
        Bevel,
    };

    /// <summary>
    /// <para>How a stencil function modifies the stencil values of pixels it touches.</para>
    /// https://love2d.org/wiki/StencilAction
    /// </summary>
    public enum StencilAction : int
    {
        /// <summary>
        /// The stencil value of a pixel will be replaced by the value specified in love.graphics.stencil, if any object touches the pixel.
        /// </summary>
        Replace,

        /// <summary>
        /// The stencil value of a pixel will be incremented by 1 for each object that touches the pixel. If the stencil value reaches 255 it will stay at 255.
        /// </summary>
        Increment,

        /// <summary>
        /// The stencil value of a pixel will be decremented by 1 for each object that touches the pixel. If the stencil value reaches 0 it will stay at 0.
        /// </summary>
        Decrement,

        /// <summary>
        /// The stencil value of a pixel will be incremented by 1 for each object that touches the pixel. If a stencil value of 255 is incremented it will be set to 0.
        /// </summary>
        IncrementWrap,

        /// <summary>
        /// The stencil value of a pixel will be decremented by 1 for each object that touches the pixel. If the stencil value of 0 is decremented it will be set to 255.
        /// </summary>
        DecrementWrap,

        /// <summary>
        /// The stencil value of a pixel will be bitwise-inverted for each object that touches the pixel. If a stencil value of 0 is inverted it will become 255.
        /// </summary>
        Invert,
    };

    /// <summary>
    /// Different types of per-pixel stencil test comparisons. The pixels of an object will be drawn if the comparison succeeds, for each pixel that the object touches.
    /// <para>https://love2d.org/wiki/CompareMode</para>
    /// </summary>
    public enum CompareMode : int
    {
        /// <summary>
        /// The stencil value of the pixel must be less than the supplied value.
        /// </summary>
        Less,

        /// <summary>
        /// The stencil value of the pixel must be less than or equal to the supplied value.
        /// </summary>
        LEqual,

        /// <summary>
        /// The stencil value of the pixel must be equal to the supplied value.
        /// </summary>
        Equal,

        /// <summary>
        /// The stencil value of the pixel must be greater than or equal to the supplied value.
        /// </summary>
        GEqual,

        /// <summary>
        /// The stencil value of the pixel must be greater than the supplied value.
        /// </summary>
        Greater,

        /// <summary>
        /// The stencil value of the pixel must not be equal to the supplied value.
        /// </summary>
        NotEqual,

        Always,
    };

    /// <summary>
    /// https://love2d.org/wiki/GraphicsFeature
    /// <para>Graphics features that can be checked for with love.graphics.getSupported.</para>
    /// </summary>
    public enum Feature : int
    {
        /// <summary>
        /// Whether multiple Canvases with different formats can be used in the same love.graphics.setCanvas call.
        /// <para>multicanvasformats is supported on OpenGL 3-capable desktop systems, and OpenGL ES 3-capable mobile devices.</para>
        /// </summary>
        MultiCanvasFormats,


        /// <summary>
        /// Whether the "clampzero" WrapMode is supported.
        /// <para>clampzero is supported on all desktop systems, but only some mobile devices. If it's not supported and it's attempted to be set, the "clamp" wrap mode will automatically be used instead.</para>
        /// </summary>
        ClampZero,


        /// <summary>
        /// Whether the "lighten" and "darken" BlendModes are supported.
        /// <para>lighten is supported on all desktop systems, and OpenGL ES 3-capable mobile devices.</para>
        /// </summary>
        Lighten,

        /// <summary>
        /// Whether textures with non-power-of-two dimensions can use mipmapping and the 'repeat' WrapMode (Texture:setMipmapFilter).
        /// </summary>
        FullNPOT,

        /// <summary>
        /// Whether pixel shaders can use "highp" 32 bit floating point numbers (as opposed to just 16 bit or lower precision).
        /// </summary>
        PixelShaderHighp,

        /// <summary>
        /// 
        /// </summary>
        ShaderDerivatives,

        /// <summary>
        /// Whether GLSL 3 Shaders can be used.
        /// </summary>
        GLSL3,

        /// <summary>
        /// Whether mesh instancing (love.graphics.drawInstanced) is supported.
        /// </summary>
        Instancing,
    };



    /// <summary>
    /// Type of distribution new particles are drawn from: None, uniform, normal, ellipse, borderellipse, borderrectangle.
    /// <para>https://love2d.org/wiki/AreaSpreadDistribution</para>
    /// </summary>
    public enum AreaSpreadDistribution : int
    {
        None,

        /// <summary>
        /// Uniform distribution.
        /// </summary>
        Uniform,

        /// <summary>
        /// Normal (gaussian) distribution.
        /// </summary>
        Normal,

        /// <summary>
        /// Uniform distribution in an ellipse.
        /// </summary>
        Ellipse,


        /// <summary>
        /// Distribution in an ellipse with particles spawning at the edges of the ellipse.
        /// </summary>
        BorderEllipse,

        /// <summary>
        /// Distribution in a rectangle with particles spawning at the edges of the rectangle.
        /// </summary>
        BorderRectangle,
    };

    /// <summary>
    /// Controls whether shapes are drawn as an outline, or filled.
    /// </summary>
    public enum DrawMode : int
    {
        /// <summary>
        /// Draw outlined shape.
        /// </summary>
        Line,

        /// <summary>
        /// Draw filled shape.
        /// </summary>
        Fill,
    };

    // The expected usage pattern of the Mesh's vertex data.
    public enum SpriteBatchUsage : int
    {
        /// <summary>
        /// The object data will always change between draws.
        /// </summary>
        Stream,

        /// <summary>
        /// The object's data will change occasionally during its lifetime.
        /// </summary>
        Dynamic,

        /// <summary>
        /// The object will not be modified after initial sprites or vertices are added.
        /// </summary>
        Static,
    };

    /// <summary>
    /// https://love2d.org/wiki/MeshDrawMode
    /// </summary>
    public enum MeshDrawMode : int
    {
        /// <summary>
        /// The vertices create a "fan" shape with the first vertex acting as the hub point. Can be easily used to draw simple convex polygons.
        /// </summary>
        Trangles,

        /// <summary>
        /// The vertices create a series of connected triangles using vertices 1, 2, 3, then 3, 2, 4 (note the order), then 3, 4, 5, and so on.
        /// </summary>
        Strip,

        /// <summary>
        /// The vertices create a "fan" shape with the first vertex acting as the hub point. Can be easily used to draw simple convex polygons.
        /// </summary>
        Fan,

        /// <summary>
        /// The vertices are drawn as unconnected points (see love.graphics.setPointSize.)
        /// </summary>
        Points,
    };

    /// <summary>
    /// Pixel formats for Textures, ImageData, and CompressedImageData.
    /// https://love2d.org/wiki/PixelFormat
    /// </summary>
    public enum PixelFormat : int
    {
        PIXELFORMAT_UNKNOWN,

        // these are converted to an actual format by love
        PIXELFORMAT_NORMAL,
        PIXELFORMAT_HDR,

        // "regular" formats
        PIXELFORMAT_R8,
        PIXELFORMAT_RG8,
        PIXELFORMAT_RGBA8,
        PIXELFORMAT_sRGBA8,
        PIXELFORMAT_R16,
        PIXELFORMAT_RG16,
        PIXELFORMAT_RGBA16,
        PIXELFORMAT_R16F,
        PIXELFORMAT_RG16F,
        PIXELFORMAT_RGBA16F,
        PIXELFORMAT_R32F,
        PIXELFORMAT_RG32F,
        PIXELFORMAT_RGBA32F,

        PIXELFORMAT_LA8, // Same as RG8, but accessed as (L, L, L, A)

        // packed formats
        PIXELFORMAT_RGBA4,
        PIXELFORMAT_RGB5A1,
        PIXELFORMAT_RGB565,
        PIXELFORMAT_RGB10A2,
        PIXELFORMAT_RG11B10F,

        // depth/stencil formats
        PIXELFORMAT_STENCIL8,
        PIXELFORMAT_DEPTH16,
        PIXELFORMAT_DEPTH24,
        PIXELFORMAT_DEPTH32F,
        PIXELFORMAT_DEPTH24_STENCIL8,
        PIXELFORMAT_DEPTH32F_STENCIL8,

        // compressed formats
        PIXELFORMAT_DXT1,
        PIXELFORMAT_DXT3,
        PIXELFORMAT_DXT5,
        PIXELFORMAT_BC4,
        PIXELFORMAT_BC4s,
        PIXELFORMAT_BC5,
        PIXELFORMAT_BC5s,
        PIXELFORMAT_BC6H,
        PIXELFORMAT_BC6Hs,
        PIXELFORMAT_BC7,
        PIXELFORMAT_PVR1_RGB2,
        PIXELFORMAT_PVR1_RGB4,
        PIXELFORMAT_PVR1_RGBA2,
        PIXELFORMAT_PVR1_RGBA4,
        PIXELFORMAT_ETC1,
        PIXELFORMAT_ETC2_RGB,
        PIXELFORMAT_ETC2_RGBA,
        PIXELFORMAT_ETC2_RGBA1,
        PIXELFORMAT_EAC_R,
        PIXELFORMAT_EAC_Rs,
        PIXELFORMAT_EAC_RG,
        PIXELFORMAT_EAC_RGs,
        PIXELFORMAT_ASTC_4x4,
        PIXELFORMAT_ASTC_5x4,
        PIXELFORMAT_ASTC_5x5,
        PIXELFORMAT_ASTC_6x5,
        PIXELFORMAT_ASTC_6x6,
        PIXELFORMAT_ASTC_8x5,
        PIXELFORMAT_ASTC_8x6,
        PIXELFORMAT_ASTC_8x8,
        PIXELFORMAT_ASTC_10x5,
        PIXELFORMAT_ASTC_10x6,
        PIXELFORMAT_ASTC_10x8,
        PIXELFORMAT_ASTC_10x10,
        PIXELFORMAT_ASTC_12x10,
        PIXELFORMAT_ASTC_12x12,
    };

    /// <summary>
    /// https://love2d.org/wiki/CanvasMipmapMode
    /// </summary>
    public enum CanvasMipmapMode : int
    {
        /// <summary>
        /// Do not enable mipmap.
        /// </summary>
        MIPMAPS_NONE,

        /// <summary>
        /// Let user manually generate mipmap.
        /// </summary>
        MIPMAPS_MANUAL,

        /// <summary>
        /// Automatically generate mipmap.
        /// </summary>
        MIPMAPS_AUTO,
    }

    /// <summary>
    /// Types of textures (2D, cubemap, etc.)
    /// </summary>
    public enum TextureType : int
    {
        /// <summary>
        /// Regular 2D texture with width and height.
        /// </summary>
        TEXTURE_2D,

        /// <summary>
        /// 3D texture with width, height, and depth. Requires a custom shader to use. Volume textures can have texture filtering applied along the 3rd axis.
        /// </summary>
        TEXTURE_VOLUME,

        /// <summary>
        /// Several same-size 2D textures organized into a single object. Similar to a texture atlas / sprite sheet, but avoids sprite bleeding and other issues.
        /// </summary>
        TEXTURE_2D_ARRAY,

        /// <summary>
        /// Cubemap texture with 6 faces. Requires a custom shader (and Shader:send) to use. Sampling from a cube texture in a shader takes a 3D direction vector instead of a texture coordinate.
        /// </summary>
        TEXTURE_CUBE,
    }

}
