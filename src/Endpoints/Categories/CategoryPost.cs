﻿using IWantApp.Domain.Products;
using IWantApp.Infra.Data;

namespace IWantApp.Endpoints.Categories;

public class CategoryPost
{
    public static string Template => "/categories";
    // O "=>" serve para setar a rota na hora que criar a propriedade 
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action; 
    public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context) 
    {
        var category = new Category(categoryRequest.Name, "Test", "Test");
        
        //Tratando o erro 400 Bad Request "Usuario informou dados errados", retornando um padrão "rfc7231"
        if (!category.IsValid)
        {
            return Results.ValidationProblem(category.Notifications.ConvertToProblemDetails());
        }

        context.Categories.Add(category);
        context.SaveChanges();

        return Results.Created($"/categories/{category.Id}", category.Id);
    }
}
