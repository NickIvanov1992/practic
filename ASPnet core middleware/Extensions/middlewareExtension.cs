
    public static class middlewareExtension                   // расширяющий метод
    {
        public static void middlewareMethod(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<Adressmiddleware>();
        }
    }

