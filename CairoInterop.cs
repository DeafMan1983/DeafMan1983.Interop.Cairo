using System.Runtime.InteropServices;

namespace DeafMan1983.Interop.Cairo
{
    public partial struct Context
    {
    }

    public partial struct Surface
    {
    }

    public partial struct Device
    {
    }

    public partial struct Matrix
    {
        public double xx;

        public double yx;

        public double xy;

        public double yy;

        public double x0;

        public double y0;
    }

    public partial struct Pattern
    {
    }

    public partial struct UserDataKey
    {
        public int unused;
    }

    [NativeTypeName("unsigned int")]
    public enum Status : uint
    {
        CAIRO_STATUS_SUCCESS = 0,
        CAIRO_STATUS_NO_MEMORY,
        CAIRO_STATUS_INVALID_RESTORE,
        CAIRO_STATUS_INVALID_POP_GROUP,
        CAIRO_STATUS_NO_CURRENT_POINT,
        CAIRO_STATUS_INVALID_MATRIX,
        CAIRO_STATUS_INVALID_STATUS,
        CAIRO_STATUS_NULL_POINTER,
        CAIRO_STATUS_INVALID_STRING,
        CAIRO_STATUS_INVALID_PATH_DATA,
        CAIRO_STATUS_READ_ERROR,
        CAIRO_STATUS_WRITE_ERROR,
        CAIRO_STATUS_SURFACE_FINISHED,
        CAIRO_STATUS_SurfaceType_MISMATCH,
        CAIRO_STATUS_PatternType_MISMATCH,
        CAIRO_STATUS_INVALID_CONTENT,
        CAIRO_STATUS_INVALID_FORMAT,
        CAIRO_STATUS_INVALID_VISUAL,
        CAIRO_STATUS_FILE_NOT_FOUND,
        CAIRO_STATUS_INVALID_DASH,
        CAIRO_STATUS_INVALID_DSC_COMMENT,
        CAIRO_STATUS_INVALID_INDEX,
        CAIRO_STATUS_CLIP_NOT_REPRESENTABLE,
        CAIRO_STATUS_TEMP_FILE_ERROR,
        CAIRO_STATUS_INVALID_STRIDE,
        CAIRO_STATUS_FONT_TYPE_MISMATCH,
        CAIRO_STATUS_USER_FONT_IMMUTABLE,
        CAIRO_STATUS_USER_FONT_ERROR,
        CAIRO_STATUS_NEGATIVE_COUNT,
        CAIRO_STATUS_INVALID_CLUSTERS,
        CAIRO_STATUS_INVALID_SLANT,
        CAIRO_STATUS_INVALID_WEIGHT,
        CAIRO_STATUS_INVALID_SIZE,
        CAIRO_STATUS_USER_FONT_NOT_IMPLEMENTED,
        CAIRO_STATUS_DeviceType_MISMATCH,
        CAIRO_STATUS_DEVICE_ERROR,
        CAIRO_STATUS_INVALID_MESH_CONSTRUCTION,
        CAIRO_STATUS_DEVICE_FINISHED,
        CAIRO_STATUS_JBIG2_GLOBAL_MISSING,
        CAIRO_STATUS_PNG_ERROR,
        CAIRO_STATUS_FREETYPE_ERROR,
        CAIRO_STATUS_WIN32_GDI_ERROR,
        CAIRO_STATUS_TAG_ERROR,
        CAIRO_STATUS_LAST_STATUS,
    }

    [NativeTypeName("unsigned int")]
    public enum Content : uint
    {
        CAIRO_CONTENT_COLOR = 0x1000,
        CAIRO_CONTENT_ALPHA = 0x2000,
        CAIRO_CONTENT_COLOR_ALPHA = 0x3000,
    }

    public enum Format
    {
        CAIRO_FORMAT_INVALID = -1,
        CAIRO_FORMAT_ARGB32 = 0,
        CAIRO_FORMAT_RGB24 = 1,
        CAIRO_FORMAT_A8 = 2,
        CAIRO_FORMAT_A1 = 3,
        CAIRO_FORMAT_RGB16_565 = 4,
        CAIRO_FORMAT_RGB30 = 5,
    }

    public partial struct RectangleInt32
    {
        public int x;

        public int y;

        public int width;

        public int height;
    }

    [NativeTypeName("unsigned int")]
    public enum Operator : uint
    {
        CAIRO_OPERATOR_CLEAR,
        CAIRO_OPERATOR_SOURCE,
        CAIRO_OPERATOR_OVER,
        CAIRO_OPERATOR_IN,
        CAIRO_OPERATOR_OUT,
        CAIRO_OPERATOR_ATOP,
        CAIRO_OPERATOR_DEST,
        CAIRO_OPERATOR_DEST_OVER,
        CAIRO_OPERATOR_DEST_IN,
        CAIRO_OPERATOR_DEST_OUT,
        CAIRO_OPERATOR_DEST_ATOP,
        CAIRO_OPERATOR_XOR,
        CAIRO_OPERATOR_ADD,
        CAIRO_OPERATOR_SATURATE,
        CAIRO_OPERATOR_MULTIPLY,
        CAIRO_OPERATOR_SCREEN,
        CAIRO_OPERATOR_OVERLAY,
        CAIRO_OPERATOR_DARKEN,
        CAIRO_OPERATOR_LIGHTEN,
        CAIRO_OPERATOR_COLOR_DODGE,
        CAIRO_OPERATOR_COLOR_BURN,
        CAIRO_OPERATOR_HARD_LIGHT,
        CAIRO_OPERATOR_SOFT_LIGHT,
        CAIRO_OPERATOR_DIFFERENCE,
        CAIRO_OPERATOR_EXCLUSION,
        CAIRO_OPERATOR_HSL_HUE,
        CAIRO_OPERATOR_HSL_SATURATION,
        CAIRO_OPERATOR_HSL_COLOR,
        CAIRO_OPERATOR_HSL_LUMINOSITY,
    }

    [NativeTypeName("unsigned int")]
    public enum Antialias : uint
    {
        CAIRO_ANTIALIAS_DEFAULT,
        CAIRO_ANTIALIAS_NONE,
        CAIRO_ANTIALIAS_GRAY,
        CAIRO_ANTIALIAS_SUBPIXEL,
        CAIRO_ANTIALIAS_FAST,
        CAIRO_ANTIALIAS_GOOD,
        CAIRO_ANTIALIAS_BEST,
    }

    [NativeTypeName("unsigned int")]
    public enum FillRule : uint
    {
        CAIRO_FILL_RULE_WINDING,
        CAIRO_FILL_RULE_EVEN_ODD,
    }

    [NativeTypeName("unsigned int")]
    public enum LineCap : uint
    {
        CAIRO_LINE_CAP_BUTT,
        CAIRO_LINE_CAP_ROUND,
        CAIRO_LINE_CAP_SQUARE,
    }

    [NativeTypeName("unsigned int")]
    public enum LineJoin : uint
    {
        CAIRO_LINE_JOIN_MITER,
        CAIRO_LINE_JOIN_ROUND,
        CAIRO_LINE_JOIN_BEVEL,
    }

    public partial struct Rectangle
    {
        public double x;

        public double y;

        public double width;

        public double height;
    }

    public unsafe partial struct RectangleList
    {
        [NativeTypeName("cairo_status_t")]
        public Status status;

        [NativeTypeName("cairo_rectangle_t *")]
        public Rectangle* rectangles;

        public int num_rectangles;
    }

    public partial struct ScaledFont
    {
    }

    public partial struct FontFace
    {
    }

    public partial struct Glyph
    {
        [NativeTypeName("unsigned long")]
        public nuint index;

        public double x;

        public double y;
    }

    public partial struct TextCluster
    {
        public int num_bytes;

        public int num_glyphs;
    }

    [NativeTypeName("unsigned int")]
    public enum TextClusterFlags : uint
    {
        CAIRO_TEXT_CLUSTER_FLAG_BACKWARD = 0x00000001,
    }

    public partial struct TextExtents
    {
        public double x_bearing;

        public double y_bearing;

        public double width;

        public double height;

        public double x_advance;

        public double y_advance;
    }

    public partial struct FontExtents
    {
        public double ascent;

        public double descent;

        public double height;

        public double max_x_advance;

        public double max_y_advance;
    }

    [NativeTypeName("unsigned int")]
    public enum FontSlant : uint
    {
        CAIRO_FONT_SLANT_NORMAL,
        CAIRO_FONT_SLANT_ITALIC,
        CAIRO_FONT_SLANT_OBLIQUE,
    }

    [NativeTypeName("unsigned int")]
    public enum FontWeight : uint
    {
        CAIRO_FONT_WEIGHT_NORMAL,
        CAIRO_FONT_WEIGHT_BOLD,
    }

    [NativeTypeName("unsigned int")]
    public enum SubPixelOrder : uint
    {
        CAIRO_SUBPIXEL_ORDER_DEFAULT,
        CAIRO_SUBPIXEL_ORDER_RGB,
        CAIRO_SUBPIXEL_ORDER_BGR,
        CAIRO_SUBPIXEL_ORDER_VRGB,
        CAIRO_SUBPIXEL_ORDER_VBGR,
    }

    [NativeTypeName("unsigned int")]
    public enum HintStyle : uint
    {
        CAIRO_HINT_STYLE_DEFAULT,
        CAIRO_HINT_STYLE_NONE,
        CAIRO_HINT_STYLE_SLIGHT,
        CAIRO_HINT_STYLE_MEDIUM,
        CAIRO_HINT_STYLE_FULL,
    }

    [NativeTypeName("unsigned int")]
    public enum HintMetrics : uint
    {
        CAIRO_HINT_METRICS_DEFAULT,
        CAIRO_HINT_METRICS_OFF,
        CAIRO_HINT_METRICS_ON,
    }

    public partial struct FontOptions
    {
    }

    [NativeTypeName("unsigned int")]
    public enum FontType : uint
    {
        CAIRO_FONT_TYPE_TOY,
        CAIRO_FONT_TYPE_FT,
        CAIRO_FONT_TYPE_WIN32,
        CAIRO_FONT_TYPE_QUARTZ,
        CAIRO_FONT_TYPE_USER,
    }

    [NativeTypeName("unsigned int")]
    public enum PathDataType : uint
    {
        Path_MOVE_TO,
        Path_LINE_TO,
        Path_CURVE_TO,
        Path_CLOSE_PATH,
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct PathData
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/cairo/cairo.h:2070:5)")]
        public Header header;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/cairo/cairo.h:2074:5)")]
        public Point point;

        public partial struct Header
        {
            [NativeTypeName("Path_data_type_t")]
            public PathDataType type;

            public int length;
        }

        public partial struct Point
        {
            public double x;

            public double y;
        }
    }

    public unsafe partial struct Path
    {
        [NativeTypeName("cairo_status_t")]
        public Status status;

        [NativeTypeName("Path_data_t *")]
        public PathData* data;

        public int num_data;
    }

    public enum DeviceType
    {
        CAIRO_DeviceType_DRM,
        CAIRO_DeviceType_GL,
        CAIRO_DeviceType_SCRIPT,
        CAIRO_DeviceType_XCB,
        CAIRO_DeviceType_XLIB,
        CAIRO_DeviceType_XML,
        CAIRO_DeviceType_COGL,
        CAIRO_DeviceType_WIN32,
        CAIRO_DeviceType_INVALID = -1,
    }

    [NativeTypeName("unsigned int")]
    public enum SurfaceObserverMode : uint
    {
        CAIRO_SURFACE_OBSERVER_NORMAL = 0,
        CAIRO_SURFACE_OBSERVER_RECORD_OPERATIONS = 0x1,
    }

    [NativeTypeName("unsigned int")]
    public enum SurfaceType : uint
    {
        CAIRO_SurfaceType_IMAGE,
        CAIRO_SurfaceType_PDF,
        CAIRO_SurfaceType_PS,
        CAIRO_SurfaceType_XLIB,
        CAIRO_SurfaceType_XCB,
        CAIRO_SurfaceType_GLITZ,
        CAIRO_SurfaceType_QUARTZ,
        CAIRO_SurfaceType_WIN32,
        CAIRO_SurfaceType_BEOS,
        CAIRO_SurfaceType_DIRECTFB,
        CAIRO_SurfaceType_SVG,
        CAIRO_SurfaceType_OS2,
        CAIRO_SurfaceType_WIN32_PRINTING,
        CAIRO_SurfaceType_QUARTZ_IMAGE,
        CAIRO_SurfaceType_SCRIPT,
        CAIRO_SurfaceType_QT,
        CAIRO_SurfaceType_RECORDING,
        CAIRO_SurfaceType_VG,
        CAIRO_SurfaceType_GL,
        CAIRO_SurfaceType_DRM,
        CAIRO_SurfaceType_TEE,
        CAIRO_SurfaceType_XML,
        CAIRO_SurfaceType_SKIA,
        CAIRO_SurfaceType_SUBSURFACE,
        CAIRO_SurfaceType_COGL,
    }

    [NativeTypeName("unsigned int")]
    public enum PatternType : uint
    {
        CAIRO_PatternType_SOLID,
        CAIRO_PatternType_SURFACE,
        CAIRO_PatternType_LINEAR,
        CAIRO_PatternType_RADIAL,
        CAIRO_PatternType_MESH,
        CAIRO_PatternType_RASTER_SOURCE,
    }

    [NativeTypeName("unsigned int")]
    public enum Extend : uint
    {
        CAIRO_EXTEND_NONE,
        CAIRO_EXTEND_REPEAT,
        CAIRO_EXTEND_REFLECT,
        CAIRO_EXTEND_PAD,
    }

    [NativeTypeName("unsigned int")]
    public enum Filter : uint
    {
        CAIRO_FILTER_FAST,
        CAIRO_FILTER_GOOD,
        CAIRO_FILTER_BEST,
        CAIRO_FILTER_NEAREST,
        CAIRO_FILTER_BILINEAR,
        CAIRO_FILTER_GAUSSIAN,
    }

    public partial struct Region
    {
    }

    [NativeTypeName("unsigned int")]
    public enum RegionOverlap : uint
    {
        CAIRO_RegionOverlap_IN,
        CAIRO_RegionOverlap_OUT,
        CAIRO_RegionOverlap_PART,
    }

    public static unsafe partial class Cairo
    {
        private const string libcairo = "cairo";

        [DllImport(libcairo)]
        public static extern int cairo_version();

        [DllImport(libcairo)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* cairo_version_string();

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_t *")]
        public static extern Context* cairo_create([NativeTypeName("cairo_surface_t *")] Surface* target);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_t *")]
        public static extern Context* cairo_reference([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_destroy([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint cairo_get_reference_count([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void* cairo_get_user_data([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_set_user_data([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key, void* user_data, [NativeTypeName("cairo_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport(libcairo)]
        public static extern void cairo_save([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_restore([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_push_group([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_push_group_with_content([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_content_t")] Content content);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_pop_group([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_pop_group_to_source([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_set_operator([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_operator_t")] Operator op);

        [DllImport(libcairo)]
        public static extern void cairo_set_source([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_pattern_t *")] Pattern* source);

        [DllImport(libcairo)]
        public static extern void cairo_set_source_rgb([NativeTypeName("cairo_t *")] Context* cr, double red, double green, double blue);

        [DllImport(libcairo)]
        public static extern void cairo_set_source_rgba([NativeTypeName("cairo_t *")] Context* cr, double red, double green, double blue, double alpha);

        [DllImport(libcairo)]
        public static extern void cairo_set_source_surface([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_surface_t *")] Surface* surface, double x, double y);

        [DllImport(libcairo)]
        public static extern void cairo_set_tolerance([NativeTypeName("cairo_t *")] Context* cr, double tolerance);

        [DllImport(libcairo)]
        public static extern void cairo_set_antialias([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_antialias_t")] Antialias antialias);

        [DllImport(libcairo)]
        public static extern void cairo_set_fill_rule([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_fill_rule_t")] FillRule fill_rule);

        [DllImport(libcairo)]
        public static extern void cairo_set_line_width([NativeTypeName("cairo_t *")] Context* cr, double width);

        [DllImport(libcairo)]
        public static extern void cairo_set_line_cap([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_line_cap_t")] LineCap line_cap);

        [DllImport(libcairo)]
        public static extern void cairo_set_line_join([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_line_join_t")] LineJoin line_join);

        [DllImport(libcairo)]
        public static extern void cairo_set_dash([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const double *")] double* dashes, int num_dashes, double offset);

        [DllImport(libcairo)]
        public static extern void cairo_set_miter_limit([NativeTypeName("cairo_t *")] Context* cr, double limit);

        [DllImport(libcairo)]
        public static extern void cairo_translate([NativeTypeName("cairo_t *")] Context* cr, double tx, double ty);

        [DllImport(libcairo)]
        public static extern void cairo_scale([NativeTypeName("cairo_t *")] Context* cr, double sx, double sy);

        [DllImport(libcairo)]
        public static extern void cairo_rotate([NativeTypeName("cairo_t *")] Context* cr, double angle);

        [DllImport(libcairo)]
        public static extern void cairo_transform([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const cairo_matrix_t *")] Matrix* matrix);

        [DllImport(libcairo)]
        public static extern void cairo_set_matrix([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const cairo_matrix_t *")] Matrix* matrix);

        [DllImport(libcairo)]
        public static extern void cairo_identity_matrix([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_user_to_device([NativeTypeName("cairo_t *")] Context* cr, double* x, double* y);

        [DllImport(libcairo)]
        public static extern void cairo_user_to_device_distance([NativeTypeName("cairo_t *")] Context* cr, double* dx, double* dy);

        [DllImport(libcairo)]
        public static extern void cairo_device_to_user([NativeTypeName("cairo_t *")] Context* cr, double* x, double* y);

        [DllImport(libcairo)]
        public static extern void cairo_device_to_user_distance([NativeTypeName("cairo_t *")] Context* cr, double* dx, double* dy);

        [DllImport(libcairo)]
        public static extern void cairo_new_path([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_move_to([NativeTypeName("cairo_t *")] Context* cr, double x, double y);

        [DllImport(libcairo)]
        public static extern void cairo_new_sub_path([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_line_to([NativeTypeName("cairo_t *")] Context* cr, double x, double y);

        [DllImport(libcairo)]
        public static extern void cairo_curve_to([NativeTypeName("cairo_t *")] Context* cr, double x1, double y1, double x2, double y2, double x3, double y3);

        [DllImport(libcairo)]
        public static extern void cairo_arc([NativeTypeName("cairo_t *")] Context* cr, double xc, double yc, double radius, double angle1, double angle2);

        [DllImport(libcairo)]
        public static extern void cairo_arc_negative([NativeTypeName("cairo_t *")] Context* cr, double xc, double yc, double radius, double angle1, double angle2);

        [DllImport(libcairo)]
        public static extern void cairo_rel_move_to([NativeTypeName("cairo_t *")] Context* cr, double dx, double dy);

        [DllImport(libcairo)]
        public static extern void cairo_rel_line_to([NativeTypeName("cairo_t *")] Context* cr, double dx, double dy);

        [DllImport(libcairo)]
        public static extern void cairo_rel_curve_to([NativeTypeName("cairo_t *")] Context* cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3);

        [DllImport(libcairo)]
        public static extern void cairo_rectangle([NativeTypeName("cairo_t *")] Context* cr, double x, double y, double width, double height);

        [DllImport(libcairo)]
        public static extern void cairo_close_path([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void Path_extents([NativeTypeName("cairo_t *")] Context* cr, double* x1, double* y1, double* x2, double* y2);

        [DllImport(libcairo)]
        public static extern void cairo_paint([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_paint_with_alpha([NativeTypeName("cairo_t *")] Context* cr, double alpha);

        [DllImport(libcairo)]
        public static extern void cairo_mask([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void cairo_mask_surface([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_surface_t *")] Surface* surface, double surface_x, double surface_y);

        [DllImport(libcairo)]
        public static extern void cairo_stroke([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_stroke_preserve([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_fill([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_fill_preserve([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_copy_page([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_show_page([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_in_stroke([NativeTypeName("cairo_t *")] Context* cr, double x, double y);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_in_fill([NativeTypeName("cairo_t *")] Context* cr, double x, double y);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_in_clip([NativeTypeName("cairo_t *")] Context* cr, double x, double y);

        [DllImport(libcairo)]
        public static extern void cairo_stroke_extents([NativeTypeName("cairo_t *")] Context* cr, double* x1, double* y1, double* x2, double* y2);

        [DllImport(libcairo)]
        public static extern void cairo_fill_extents([NativeTypeName("cairo_t *")] Context* cr, double* x1, double* y1, double* x2, double* y2);

        [DllImport(libcairo)]
        public static extern void cairo_reset_clip([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_clip([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_clip_preserve([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_clip_extents([NativeTypeName("cairo_t *")] Context* cr, double* x1, double* y1, double* x2, double* y2);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_RectangleList_t *")]
        public static extern RectangleList* cairo_copy_clip_RectangleList([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_RectangleList_destroy([NativeTypeName("cairo_RectangleList_t *")] RectangleList* RectangleList);

        [DllImport(libcairo)]
        public static extern void cairo_tag_begin([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const char *")] sbyte* tag_name, [NativeTypeName("const char *")] sbyte* attributes);

        [DllImport(libcairo)]
        public static extern void cairo_tag_end([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const char *")] sbyte* tag_name);

        [DllImport(libcairo)]
        public static extern Glyph* cairo_glyph_allocate(int num_glyphs);

        [DllImport(libcairo)]
        public static extern void cairo_glyph_free(Glyph* glyphs);

        [DllImport(libcairo)]
        public static extern TextCluster* cairo_text_cluster_allocate(int num_clusters);

        [DllImport(libcairo)]
        public static extern void cairo_text_cluster_free(TextCluster* clusters);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_options_t *")]
        public static extern FontOptions* cairo_font_options_create();

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_options_t *")]
        public static extern FontOptions* cairo_font_options_copy([NativeTypeName("const cairo_font_options_t *")] FontOptions* original);

        [DllImport(libcairo)]
        public static extern void cairo_font_options_destroy([NativeTypeName("cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_font_options_status([NativeTypeName("cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        public static extern void cairo_font_options_merge([NativeTypeName("cairo_font_options_t *")] FontOptions* options, [NativeTypeName("const cairo_font_options_t *")] FontOptions* other);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_font_options_equal([NativeTypeName("const cairo_font_options_t *")] FontOptions* options, [NativeTypeName("const cairo_font_options_t *")] FontOptions* other);

        [DllImport(libcairo)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint cairo_font_options_hash([NativeTypeName("const cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        public static extern void cairo_font_options_set_antialias([NativeTypeName("cairo_font_options_t *")] FontOptions* options, [NativeTypeName("cairo_antialias_t")] Antialias antialias);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_antialias_t")]
        public static extern Antialias cairo_font_options_get_antialias([NativeTypeName("const cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        public static extern void cairo_font_options_set_subpixel_order([NativeTypeName("cairo_font_options_t *")] FontOptions* options, [NativeTypeName("cairo_subpixel_order_t")] SubPixelOrder subpixel_order);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_subpixel_order_t")]
        public static extern SubPixelOrder cairo_font_options_get_subpixel_order([NativeTypeName("const cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        public static extern void cairo_font_options_set_hint_style([NativeTypeName("cairo_font_options_t *")] FontOptions* options, [NativeTypeName("cairo_hint_style_t")] HintStyle hint_style);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_hint_style_t")]
        public static extern HintStyle cairo_font_options_get_hint_style([NativeTypeName("const cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        public static extern void cairo_font_options_set_hint_metrics([NativeTypeName("cairo_font_options_t *")] FontOptions* options, [NativeTypeName("cairo_hint_metrics_t")] HintMetrics hint_metrics);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_hint_metrics_t")]
        public static extern HintMetrics cairo_font_options_get_hint_metrics([NativeTypeName("const cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* cairo_font_options_get_variations([NativeTypeName("cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        public static extern void cairo_font_options_set_variations([NativeTypeName("cairo_font_options_t *")] FontOptions* options, [NativeTypeName("const char *")] sbyte* variations);

        [DllImport(libcairo)]
        public static extern void cairo_select_font_face([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const char *")] sbyte* family, [NativeTypeName("cairo_font_slant_t")] FontSlant slant, [NativeTypeName("cairo_font_weight_t")] FontWeight weight);

        [DllImport(libcairo)]
        public static extern void cairo_set_font_size([NativeTypeName("cairo_t *")] Context* cr, double size);

        [DllImport(libcairo)]
        public static extern void cairo_set_font_matrix([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const cairo_matrix_t *")] Matrix* matrix);

        [DllImport(libcairo)]
        public static extern void cairo_get_font_matrix([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_matrix_t *")] Matrix* matrix);

        [DllImport(libcairo)]
        public static extern void cairo_set_font_options([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        public static extern void cairo_get_font_options([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        public static extern void cairo_set_font_face([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_face_t *")]
        public static extern FontFace* cairo_get_font_face([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_set_scaled_font([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const cairo_scaled_font_t *")] ScaledFont* scaled_font);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_scaled_font_t *")]
        public static extern ScaledFont* cairo_get_scaled_font([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_show_text([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const char *")] sbyte* utf8);

        [DllImport(libcairo)]
        public static extern void cairo_show_glyphs([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const Glyph *")] Glyph* glyphs, int num_glyphs);

        [DllImport(libcairo)]
        public static extern void cairo_show_text_glyphs([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const char *")] sbyte* utf8, int utf8_len, [NativeTypeName("const Glyph *")] Glyph* glyphs, int num_glyphs, [NativeTypeName("const TextCluster *")] TextCluster* clusters, int num_clusters, [NativeTypeName("cairo_text_cluster_flags_t")] TextClusterFlags cluster_flags);

        [DllImport(libcairo)]
        public static extern void cairo_text_path([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const char *")] sbyte* utf8);

        [DllImport(libcairo)]
        public static extern void cairo_glyph_path([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const Glyph *")] Glyph* glyphs, int num_glyphs);

        [DllImport(libcairo)]
        public static extern void cairo_text_extents([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const char *")] sbyte* utf8, TextExtents* extents);

        [DllImport(libcairo)]
        public static extern void cairo_glyph_extents([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const Glyph *")] Glyph* glyphs, int num_glyphs, TextExtents* extents);

        [DllImport(libcairo)]
        public static extern void cairo_font_extents([NativeTypeName("cairo_t *")] Context* cr, FontExtents* extents);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_face_t *")]
        public static extern FontFace* cairo_font_face_reference([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        public static extern void cairo_font_face_destroy([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint cairo_font_face_get_reference_count([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_font_face_status([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_type_t")]
        public static extern FontType cairo_font_face_get_type([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        public static extern void* cairo_font_face_get_user_data([NativeTypeName("cairo_font_face_t *")] FontFace* font_face, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_font_face_set_user_data([NativeTypeName("cairo_font_face_t *")] FontFace* font_face, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key, void* user_data, [NativeTypeName("cairo_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_scaled_font_t *")]
        public static extern ScaledFont* cairo_scaled_font_create([NativeTypeName("cairo_font_face_t *")] FontFace* font_face, [NativeTypeName("const cairo_matrix_t *")] Matrix* font_matrix, [NativeTypeName("const cairo_matrix_t *")] Matrix* ctm, [NativeTypeName("const cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_scaled_font_t *")]
        public static extern ScaledFont* cairo_scaled_font_reference([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font);

        [DllImport(libcairo)]
        public static extern void cairo_scaled_font_destroy([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font);

        [DllImport(libcairo)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint cairo_scaled_font_get_reference_count([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_scaled_font_status([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_type_t")]
        public static extern FontType cairo_scaled_font_get_type([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font);

        [DllImport(libcairo)]
        public static extern void* cairo_scaled_font_get_user_data([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_scaled_font_set_user_data([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key, void* user_data, [NativeTypeName("cairo_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport(libcairo)]
        public static extern void cairo_scaled_font_extents([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, FontExtents* extents);

        [DllImport(libcairo)]
        public static extern void cairo_scaled_font_text_extents([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, [NativeTypeName("const char *")] sbyte* utf8, TextExtents* extents);

        [DllImport(libcairo)]
        public static extern void cairo_scaled_font_glyph_extents([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, [NativeTypeName("const Glyph *")] Glyph* glyphs, int num_glyphs, TextExtents* extents);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_scaled_font_text_to_glyphs([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, double x, double y, [NativeTypeName("const char *")] sbyte* utf8, int utf8_len, Glyph** glyphs, int* num_glyphs, TextCluster** clusters, int* num_clusters, [NativeTypeName("cairo_text_cluster_flags_t *")] TextClusterFlags* cluster_flags);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_face_t *")]
        public static extern FontFace* cairo_scaled_font_get_font_face([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font);

        [DllImport(libcairo)]
        public static extern void cairo_scaled_font_get_font_matrix([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, [NativeTypeName("cairo_matrix_t *")] Matrix* font_matrix);

        [DllImport(libcairo)]
        public static extern void cairo_scaled_font_get_ctm([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, [NativeTypeName("cairo_matrix_t *")] Matrix* ctm);

        [DllImport(libcairo)]
        public static extern void cairo_scaled_font_get_scale_matrix([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, [NativeTypeName("cairo_matrix_t *")] Matrix* scale_matrix);

        [DllImport(libcairo)]
        public static extern void cairo_scaled_font_get_font_options([NativeTypeName("cairo_scaled_font_t *")] ScaledFont* scaled_font, [NativeTypeName("cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_face_t *")]
        public static extern FontFace* cairo_toy_font_face_create([NativeTypeName("const char *")] sbyte* family, [NativeTypeName("cairo_font_slant_t")] FontSlant slant, [NativeTypeName("cairo_font_weight_t")] FontWeight weight);

        [DllImport(libcairo)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* cairo_toy_font_face_get_family([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_slant_t")]
        public static extern FontSlant cairo_toy_font_face_get_slant([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_weight_t")]
        public static extern FontWeight cairo_toy_font_face_get_weight([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_font_face_t *")]
        public static extern FontFace* cairo_user_font_face_create();

        [DllImport(libcairo)]
        public static extern void cairo_user_font_face_set_init_func([NativeTypeName("cairo_font_face_t *")] FontFace* font_face, [NativeTypeName("cairo_user_scaled_font_init_func_t")] delegate* unmanaged[Cdecl]<ScaledFont*, Context*, FontExtents*, Status> init_func);

        [DllImport(libcairo)]
        public static extern void cairo_user_font_face_set_render_glyph_func([NativeTypeName("cairo_font_face_t *")] FontFace* font_face, [NativeTypeName("cairo_user_scaled_font_render_glyph_func_t")] delegate* unmanaged[Cdecl]<ScaledFont*, nuint, Context*, TextExtents*, Status> render_glyph_func);

        [DllImport(libcairo)]
        public static extern void cairo_user_font_face_set_text_to_glyphs_func([NativeTypeName("cairo_font_face_t *")] FontFace* font_face, [NativeTypeName("cairo_user_scaled_font_text_to_glyphs_func_t")] delegate* unmanaged[Cdecl]<ScaledFont*, sbyte*, int, Glyph**, int*, TextCluster**, int*, TextClusterFlags*, Status> text_to_glyphs_func);

        [DllImport(libcairo)]
        public static extern void cairo_user_font_face_set_unicode_to_glyph_func([NativeTypeName("cairo_font_face_t *")] FontFace* font_face, [NativeTypeName("cairo_user_scaled_font_unicode_to_glyph_func_t")] delegate* unmanaged[Cdecl]<ScaledFont*, nuint, nuint*, Status> unicode_to_glyph_func);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_user_scaled_font_init_func_t")]
        public static extern delegate* unmanaged[Cdecl]<ScaledFont*, Context*, FontExtents*, Status> cairo_user_font_face_get_init_func([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_user_scaled_font_render_glyph_func_t")]
        public static extern delegate* unmanaged[Cdecl]<ScaledFont*, nuint, Context*, TextExtents*, Status> cairo_user_font_face_get_render_glyph_func([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_user_scaled_font_text_to_glyphs_func_t")]
        public static extern delegate* unmanaged[Cdecl]<ScaledFont*, sbyte*, int, Glyph**, int*, TextCluster**, int*, TextClusterFlags*, Status> cairo_user_font_face_get_text_to_glyphs_func([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_user_scaled_font_unicode_to_glyph_func_t")]
        public static extern delegate* unmanaged[Cdecl]<ScaledFont*, nuint, nuint*, Status> cairo_user_font_face_get_unicode_to_glyph_func([NativeTypeName("cairo_font_face_t *")] FontFace* font_face);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_operator_t")]
        public static extern Operator cairo_get_operator([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_get_source([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern double cairo_get_tolerance([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_antialias_t")]
        public static extern Antialias cairo_get_antialias([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_has_current_point([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_get_current_point([NativeTypeName("cairo_t *")] Context* cr, double* x, double* y);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_fill_rule_t")]
        public static extern FillRule cairo_get_fill_rule([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern double cairo_get_line_width([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_line_cap_t")]
        public static extern LineCap cairo_get_line_cap([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_line_join_t")]
        public static extern LineJoin cairo_get_line_join([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern double cairo_get_miter_limit([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern int cairo_get_dash_count([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_get_dash([NativeTypeName("cairo_t *")] Context* cr, double* dashes, double* offset);

        [DllImport(libcairo)]
        public static extern void cairo_get_matrix([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("cairo_matrix_t *")] Matrix* matrix);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_get_target([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_get_group_target([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("Path_t *")]
        public static extern Path* cairo_copy_path([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("Path_t *")]
        public static extern Path* cairo_copy_path_flat([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        public static extern void cairo_append_path([NativeTypeName("cairo_t *")] Context* cr, [NativeTypeName("const Path_t *")] Path* path);

        [DllImport(libcairo)]
        public static extern void Path_destroy([NativeTypeName("Path_t *")] Path* path);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_status([NativeTypeName("cairo_t *")] Context* cr);

        [DllImport(libcairo)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* cairo_status_to_string([NativeTypeName("cairo_status_t")] Status status);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_device_t *")]
        public static extern Device* cairo_device_reference([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_DeviceType_t")]
        public static extern DeviceType cairo_device_get_type([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_device_status([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_device_acquire([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern void cairo_device_release([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern void cairo_device_flush([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern void cairo_device_finish([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern void cairo_device_destroy([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint cairo_device_get_reference_count([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern void* cairo_device_get_user_data([NativeTypeName("cairo_device_t *")] Device* device, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_device_set_user_data([NativeTypeName("cairo_device_t *")] Device* device, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key, void* user_data, [NativeTypeName("cairo_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_surface_create_similar([NativeTypeName("cairo_surface_t *")] Surface* other, [NativeTypeName("cairo_content_t")] Content content, int width, int height);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_surface_create_similar_image([NativeTypeName("cairo_surface_t *")] Surface* other, [NativeTypeName("cairo_format_t")] Format format, int width, int height);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_surface_map_to_image([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("const cairo_rectangle_int_t *")] RectangleInt32* extents);

        [DllImport(libcairo)]
        public static extern void cairo_surface_unmap_image([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("cairo_surface_t *")] Surface* image);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_surface_create_for_rectangle([NativeTypeName("cairo_surface_t *")] Surface* target, double x, double y, double width, double height);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_surface_create_observer([NativeTypeName("cairo_surface_t *")] Surface* target, SurfaceObserverMode mode);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_observer_add_paint_callback([NativeTypeName("cairo_surface_t *")] Surface* abstract_surface, [NativeTypeName("cairo_surface_observer_callback_t")] delegate* unmanaged[Cdecl]<Surface*, Surface*, void*, void> func, void* data);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_observer_add_mask_callback([NativeTypeName("cairo_surface_t *")] Surface* abstract_surface, [NativeTypeName("cairo_surface_observer_callback_t")] delegate* unmanaged[Cdecl]<Surface*, Surface*, void*, void> func, void* data);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_observer_add_fill_callback([NativeTypeName("cairo_surface_t *")] Surface* abstract_surface, [NativeTypeName("cairo_surface_observer_callback_t")] delegate* unmanaged[Cdecl]<Surface*, Surface*, void*, void> func, void* data);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_observer_add_stroke_callback([NativeTypeName("cairo_surface_t *")] Surface* abstract_surface, [NativeTypeName("cairo_surface_observer_callback_t")] delegate* unmanaged[Cdecl]<Surface*, Surface*, void*, void> func, void* data);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_observer_add_glyphs_callback([NativeTypeName("cairo_surface_t *")] Surface* abstract_surface, [NativeTypeName("cairo_surface_observer_callback_t")] delegate* unmanaged[Cdecl]<Surface*, Surface*, void*, void> func, void* data);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_observer_add_flush_callback([NativeTypeName("cairo_surface_t *")] Surface* abstract_surface, [NativeTypeName("cairo_surface_observer_callback_t")] delegate* unmanaged[Cdecl]<Surface*, Surface*, void*, void> func, void* data);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_observer_add_finish_callback([NativeTypeName("cairo_surface_t *")] Surface* abstract_surface, [NativeTypeName("cairo_surface_observer_callback_t")] delegate* unmanaged[Cdecl]<Surface*, Surface*, void*, void> func, void* data);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_observer_print([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("cairo_write_func_t")] delegate* unmanaged[Cdecl]<void*, byte*, uint, Status> write_func, void* closure);

        [DllImport(libcairo)]
        public static extern double cairo_surface_observer_elapsed([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_device_observer_print([NativeTypeName("cairo_device_t *")] Device* device, [NativeTypeName("cairo_write_func_t")] delegate* unmanaged[Cdecl]<void*, byte*, uint, Status> write_func, void* closure);

        [DllImport(libcairo)]
        public static extern double cairo_device_observer_elapsed([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern double cairo_device_observer_paint_elapsed([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern double cairo_device_observer_mask_elapsed([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern double cairo_device_observer_fill_elapsed([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern double cairo_device_observer_stroke_elapsed([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        public static extern double cairo_device_observer_glyphs_elapsed([NativeTypeName("cairo_device_t *")] Device* device);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_surface_reference([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern void cairo_surface_finish([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern void cairo_surface_destroy([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_device_t *")]
        public static extern Device* cairo_surface_get_device([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint cairo_surface_get_reference_count([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_status([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_SurfaceType_t")]
        public static extern SurfaceType cairo_surface_get_type([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_content_t")]
        public static extern Content cairo_surface_get_content([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_write_to_png([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("const char *")] sbyte* filename);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_write_to_png_stream([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("cairo_write_func_t")] delegate* unmanaged[Cdecl]<void*, byte*, uint, Status> write_func, void* closure);

        [DllImport(libcairo)]
        public static extern void* cairo_surface_get_user_data([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_set_user_data([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key, void* user_data, [NativeTypeName("cairo_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport(libcairo)]
        public static extern void cairo_surface_get_mime_data([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("const char *")] sbyte* mime_type, [NativeTypeName("const unsigned char **")] byte** data, [NativeTypeName("unsigned long *")] nuint* length);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_surface_set_mime_data([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("const char *")] sbyte* mime_type, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("unsigned long")] nuint length, [NativeTypeName("cairo_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, void* closure);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_surface_supports_mime_type([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("const char *")] sbyte* mime_type);

        [DllImport(libcairo)]
        public static extern void cairo_surface_get_font_options([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("cairo_font_options_t *")] FontOptions* options);

        [DllImport(libcairo)]
        public static extern void cairo_surface_flush([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern void cairo_surface_mark_dirty([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern void cairo_surface_mark_dirty_rectangle([NativeTypeName("cairo_surface_t *")] Surface* surface, int x, int y, int width, int height);

        [DllImport(libcairo)]
        public static extern void cairo_surface_set_device_scale([NativeTypeName("cairo_surface_t *")] Surface* surface, double x_scale, double y_scale);

        [DllImport(libcairo)]
        public static extern void cairo_surface_get_device_scale([NativeTypeName("cairo_surface_t *")] Surface* surface, double* x_scale, double* y_scale);

        [DllImport(libcairo)]
        public static extern void cairo_surface_set_device_offset([NativeTypeName("cairo_surface_t *")] Surface* surface, double x_offset, double y_offset);

        [DllImport(libcairo)]
        public static extern void cairo_surface_get_device_offset([NativeTypeName("cairo_surface_t *")] Surface* surface, double* x_offset, double* y_offset);

        [DllImport(libcairo)]
        public static extern void cairo_surface_set_fallback_resolution([NativeTypeName("cairo_surface_t *")] Surface* surface, double x_pixels_per_inch, double y_pixels_per_inch);

        [DllImport(libcairo)]
        public static extern void cairo_surface_get_fallback_resolution([NativeTypeName("cairo_surface_t *")] Surface* surface, double* x_pixels_per_inch, double* y_pixels_per_inch);

        [DllImport(libcairo)]
        public static extern void cairo_surface_copy_page([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern void cairo_surface_show_page([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_surface_has_show_text_glyphs([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_image_surface_create([NativeTypeName("cairo_format_t")] Format format, int width, int height);

        [DllImport(libcairo)]
        public static extern int cairo_format_stride_for_width([NativeTypeName("cairo_format_t")] Format format, int width);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_image_surface_create_for_data([NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("cairo_format_t")] Format format, int width, int height, int stride);

        [DllImport(libcairo)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* cairo_image_surface_get_data([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_format_t")]
        public static extern Format cairo_image_surface_get_format([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern int cairo_image_surface_get_width([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern int cairo_image_surface_get_height([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern int cairo_image_surface_get_stride([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_image_surface_create_from_png([NativeTypeName("const char *")] sbyte* filename);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_image_surface_create_from_png_stream([NativeTypeName("cairo_read_func_t")] delegate* unmanaged[Cdecl]<void*, byte*, uint, Status> read_func, void* closure);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_recording_surface_create([NativeTypeName("cairo_content_t")] Content content, [NativeTypeName("const cairo_rectangle_t *")] Rectangle* extents);

        [DllImport(libcairo)]
        public static extern void cairo_recording_surface_ink_extents([NativeTypeName("cairo_surface_t *")] Surface* surface, double* x0, double* y0, double* width, double* height);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_recording_surface_get_extents([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("cairo_rectangle_t *")] Rectangle* extents);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_pattern_create_raster_source(void* user_data, [NativeTypeName("cairo_content_t")] Content content, int width, int height);

        [DllImport(libcairo)]
        public static extern void cairo_raster_source_pattern_set_callback_data([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, void* data);

        [DllImport(libcairo)]
        public static extern void* cairo_raster_source_pattern_get_callback_data([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void cairo_raster_source_pattern_set_acquire([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("cairo_raster_source_acquire_func_t")] delegate* unmanaged[Cdecl]<Pattern*, void*, Surface*, RectangleInt32*, Surface*> acquire, [NativeTypeName("cairo_raster_source_release_func_t")] delegate* unmanaged[Cdecl]<Pattern*, void*, Surface*, void> release);

        [DllImport(libcairo)]
        public static extern void cairo_raster_source_pattern_get_acquire([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("cairo_raster_source_acquire_func_t *")] delegate* unmanaged[Cdecl]<Pattern*, void*, Surface*, RectangleInt32*, Surface*>* acquire, [NativeTypeName("cairo_raster_source_release_func_t *")] delegate* unmanaged[Cdecl]<Pattern*, void*, Surface*, void>* release);

        [DllImport(libcairo)]
        public static extern void cairo_raster_source_pattern_set_snapshot([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("cairo_raster_source_snapshot_func_t")] delegate* unmanaged[Cdecl]<Pattern*, void*, Status> snapshot);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_raster_source_snapshot_func_t")]
        public static extern delegate* unmanaged[Cdecl]<Pattern*, void*, Status> cairo_raster_source_pattern_get_snapshot([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void cairo_raster_source_pattern_set_copy([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("cairo_raster_source_copy_func_t")] delegate* unmanaged[Cdecl]<Pattern*, void*, Pattern*, Status> copy);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_raster_source_copy_func_t")]
        public static extern delegate* unmanaged[Cdecl]<Pattern*, void*, Pattern*, Status> cairo_raster_source_pattern_get_copy([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void cairo_raster_source_pattern_set_finish([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("cairo_raster_source_finish_func_t")] delegate* unmanaged[Cdecl]<Pattern*, void*, void> finish);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_raster_source_finish_func_t")]
        public static extern delegate* unmanaged[Cdecl]<Pattern*, void*, void> cairo_raster_source_pattern_get_finish([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_pattern_create_rgb(double red, double green, double blue);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_pattern_create_rgba(double red, double green, double blue, double alpha);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_pattern_create_for_surface([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_pattern_create_linear(double x0, double y0, double x1, double y1);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_pattern_create_radial(double cx0, double cy0, double radius0, double cx1, double cy1, double radius1);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_pattern_create_mesh();

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_pattern_t *")]
        public static extern Pattern* cairo_pattern_reference([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void cairo_pattern_destroy([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint cairo_pattern_get_reference_count([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_pattern_status([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void* cairo_pattern_get_user_data([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_pattern_set_user_data([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("const cairo_user_data_key_t *")] UserDataKey* key, void* user_data, [NativeTypeName("cairo_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_PatternType_t")]
        public static extern PatternType cairo_pattern_get_type([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void cairo_pattern_add_color_stop_rgb([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, double offset, double red, double green, double blue);

        [DllImport(libcairo)]
        public static extern void cairo_pattern_add_color_stop_rgba([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, double offset, double red, double green, double blue, double alpha);

        [DllImport(libcairo)]
        public static extern void cairo_mesh_pattern_begin_patch([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void cairo_mesh_pattern_end_patch([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void cairo_mesh_pattern_curve_to([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, double x1, double y1, double x2, double y2, double x3, double y3);

        [DllImport(libcairo)]
        public static extern void cairo_mesh_pattern_line_to([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, double x, double y);

        [DllImport(libcairo)]
        public static extern void cairo_mesh_pattern_move_to([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, double x, double y);

        [DllImport(libcairo)]
        public static extern void cairo_mesh_pattern_set_control_point([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("unsigned int")] uint point_num, double x, double y);

        [DllImport(libcairo)]
        public static extern void cairo_mesh_pattern_set_corner_color_rgb([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("unsigned int")] uint corner_num, double red, double green, double blue);

        [DllImport(libcairo)]
        public static extern void cairo_mesh_pattern_set_corner_color_rgba([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("unsigned int")] uint corner_num, double red, double green, double blue, double alpha);

        [DllImport(libcairo)]
        public static extern void cairo_pattern_set_matrix([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("const cairo_matrix_t *")] Matrix* matrix);

        [DllImport(libcairo)]
        public static extern void cairo_pattern_get_matrix([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("cairo_matrix_t *")] Matrix* matrix);

        [DllImport(libcairo)]
        public static extern void cairo_pattern_set_extend([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("cairo_extend_t")] Extend extend);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_extend_t")]
        public static extern Extend cairo_pattern_get_extend([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        public static extern void cairo_pattern_set_filter([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("cairo_filter_t")] Filter filter);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_filter_t")]
        public static extern Filter cairo_pattern_get_filter([NativeTypeName("cairo_pattern_t *")] Pattern* pattern);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_pattern_get_rgba([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, double* red, double* green, double* blue, double* alpha);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_pattern_get_surface([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("cairo_surface_t **")] Surface** surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_pattern_get_color_stop_rgba([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, int index, double* offset, double* red, double* green, double* blue, double* alpha);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_pattern_get_color_stop_count([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, int* count);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_pattern_get_linear_points([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, double* x0, double* y0, double* x1, double* y1);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_pattern_get_radial_circles([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, double* x0, double* y0, double* r0, double* x1, double* y1, double* r1);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_mesh_pattern_get_patch_count([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("unsigned int *")] uint* count);

        [DllImport(libcairo)]
        [return: NativeTypeName("Path_t *")]
        public static extern Path* cairo_mesh_pattern_get_path([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("unsigned int")] uint patch_num);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_mesh_pattern_get_corner_color_rgba([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("unsigned int")] uint patch_num, [NativeTypeName("unsigned int")] uint corner_num, double* red, double* green, double* blue, double* alpha);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_mesh_pattern_get_control_point([NativeTypeName("cairo_pattern_t *")] Pattern* pattern, [NativeTypeName("unsigned int")] uint patch_num, [NativeTypeName("unsigned int")] uint point_num, double* x, double* y);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_init([NativeTypeName("cairo_matrix_t *")] Matrix* matrix, double xx, double yx, double xy, double yy, double x0, double y0);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_init_identity([NativeTypeName("cairo_matrix_t *")] Matrix* matrix);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_init_translate([NativeTypeName("cairo_matrix_t *")] Matrix* matrix, double tx, double ty);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_init_scale([NativeTypeName("cairo_matrix_t *")] Matrix* matrix, double sx, double sy);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_init_rotate([NativeTypeName("cairo_matrix_t *")] Matrix* matrix, double radians);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_translate([NativeTypeName("cairo_matrix_t *")] Matrix* matrix, double tx, double ty);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_scale([NativeTypeName("cairo_matrix_t *")] Matrix* matrix, double sx, double sy);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_rotate([NativeTypeName("cairo_matrix_t *")] Matrix* matrix, double radians);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_matrix_invert([NativeTypeName("cairo_matrix_t *")] Matrix* matrix);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_multiply([NativeTypeName("cairo_matrix_t *")] Matrix* result, [NativeTypeName("const cairo_matrix_t *")] Matrix* a, [NativeTypeName("const cairo_matrix_t *")] Matrix* b);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_transform_distance([NativeTypeName("const cairo_matrix_t *")] Matrix* matrix, double* dx, double* dy);

        [DllImport(libcairo)]
        public static extern void cairo_matrix_transform_point([NativeTypeName("const cairo_matrix_t *")] Matrix* matrix, double* x, double* y);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_region_t *")]
        public static extern Region* cairo_region_create();

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_region_t *")]
        public static extern Region* cairo_region_create_rectangle([NativeTypeName("const cairo_rectangle_int_t *")] RectangleInt32* rectangle);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_region_t *")]
        public static extern Region* cairo_region_create_rectangles([NativeTypeName("const cairo_rectangle_int_t *")] RectangleInt32* rects, int count);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_region_t *")]
        public static extern Region* cairo_region_copy([NativeTypeName("const cairo_region_t *")] Region* original);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_region_t *")]
        public static extern Region* cairo_region_reference([NativeTypeName("cairo_region_t *")] Region* region);

        [DllImport(libcairo)]
        public static extern void cairo_region_destroy([NativeTypeName("cairo_region_t *")] Region* region);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_region_equal([NativeTypeName("const cairo_region_t *")] Region* a, [NativeTypeName("const cairo_region_t *")] Region* b);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_region_status([NativeTypeName("const cairo_region_t *")] Region* region);

        [DllImport(libcairo)]
        public static extern void cairo_region_get_extents([NativeTypeName("const cairo_region_t *")] Region* region, [NativeTypeName("cairo_rectangle_int_t *")] RectangleInt32* extents);

        [DllImport(libcairo)]
        public static extern int cairo_region_num_rectangles([NativeTypeName("const cairo_region_t *")] Region* region);

        [DllImport(libcairo)]
        public static extern void cairo_region_get_rectangle([NativeTypeName("const cairo_region_t *")] Region* region, int nth, [NativeTypeName("cairo_rectangle_int_t *")] RectangleInt32* rectangle);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_region_is_empty([NativeTypeName("const cairo_region_t *")] Region* region);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_RegionOverlap_t")]
        public static extern RegionOverlap cairo_region_contains_rectangle([NativeTypeName("const cairo_region_t *")] Region* region, [NativeTypeName("const cairo_rectangle_int_t *")] RectangleInt32* rectangle);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_bool_t")]
        public static extern int cairo_region_contains_point([NativeTypeName("const cairo_region_t *")] Region* region, int x, int y);

        [DllImport(libcairo)]
        public static extern void cairo_region_translate([NativeTypeName("cairo_region_t *")] Region* region, int dx, int dy);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_region_subtract([NativeTypeName("cairo_region_t *")] Region* dst, [NativeTypeName("const cairo_region_t *")] Region* other);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_region_subtract_rectangle([NativeTypeName("cairo_region_t *")] Region* dst, [NativeTypeName("const cairo_rectangle_int_t *")] RectangleInt32* rectangle);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_region_intersect([NativeTypeName("cairo_region_t *")] Region* dst, [NativeTypeName("const cairo_region_t *")] Region* other);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_region_intersect_rectangle([NativeTypeName("cairo_region_t *")] Region* dst, [NativeTypeName("const cairo_rectangle_int_t *")] RectangleInt32* rectangle);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_region_union([NativeTypeName("cairo_region_t *")] Region* dst, [NativeTypeName("const cairo_region_t *")] Region* other);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_region_union_rectangle([NativeTypeName("cairo_region_t *")] Region* dst, [NativeTypeName("const cairo_rectangle_int_t *")] RectangleInt32* rectangle);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_region_xor([NativeTypeName("cairo_region_t *")] Region* dst, [NativeTypeName("const cairo_region_t *")] Region* other);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_status_t")]
        public static extern Status cairo_region_xor_rectangle([NativeTypeName("cairo_region_t *")] Region* dst, [NativeTypeName("const cairo_rectangle_int_t *")] RectangleInt32* rectangle);

        [DllImport(libcairo)]
        public static extern void cairo_debug_reset_static_data();
    }
}
