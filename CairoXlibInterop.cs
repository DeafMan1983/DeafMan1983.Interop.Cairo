using System.Runtime.InteropServices;

using TerraFX.Interop.Xlib;

namespace DeafMan1983.Interop.Cairo
{
    public static unsafe partial class Cairo
    {
        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_xlib_surface_create([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("Drawable")] Drawable drawable, Visual* visual, int width, int height);

        [DllImport(libcairo)]
        [return: NativeTypeName("cairo_surface_t *")]
        public static extern Surface* cairo_xlib_surface_create_for_bitmap([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("Pixmap")] Pixmap bitmap, Screen* screen, int width, int height);

        [DllImport(libcairo)]
        public static extern void cairo_xlib_surface_set_size([NativeTypeName("cairo_surface_t *")] Surface* surface, int width, int height);

        [DllImport(libcairo)]
        public static extern void cairo_xlib_surface_set_drawable([NativeTypeName("cairo_surface_t *")] Surface* surface, [NativeTypeName("Drawable")] Drawable drawable, int width, int height);

        [DllImport(libcairo)]
        [return: NativeTypeName("Display *")]
        public static extern Display* cairo_xlib_surface_get_display([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        [return: NativeTypeName("Drawable")]
        public static extern nuint cairo_xlib_surface_get_drawable([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern Screen* cairo_xlib_surface_get_screen([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern Visual* cairo_xlib_surface_get_visual([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern int cairo_xlib_surface_get_depth([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern int cairo_xlib_surface_get_width([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern int cairo_xlib_surface_get_height([NativeTypeName("cairo_surface_t *")] Surface* surface);

        [DllImport(libcairo)]
        public static extern void cairo_xlib_device_debug_cap_xrender_version([NativeTypeName("cairo_device_t *")] Device* device, int major_version, int minor_version);

        [DllImport(libcairo)]
        public static extern void cairo_xlib_device_debug_set_precision([NativeTypeName("cairo_device_t *")] Device* device, int precision);

        [DllImport(libcairo)]
        public static extern int cairo_xlib_device_debug_get_precision([NativeTypeName("cairo_device_t *")] Device* device);
    }
}
