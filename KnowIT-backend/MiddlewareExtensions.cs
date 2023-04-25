namespace KnowIT_backend
{
    public static class MiddlewareExtensions
    {
        public static void AddCorsExtension(this IServiceCollection services)
        {
            string []cors = { "http://localhost:3000" };

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.WithOrigins(cors)
                            .SetIsOriginAllowedToAllowWildcardSubdomains()
                            .WithExposedHeaders("Content-Disposition")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
        }
    }
}
