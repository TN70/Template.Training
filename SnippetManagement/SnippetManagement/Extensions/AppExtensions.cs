﻿namespace SnippetManagement.Extensions
{
    public static class AppExtensions
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Template.Training.Mvc");
            });
        }
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            //app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
