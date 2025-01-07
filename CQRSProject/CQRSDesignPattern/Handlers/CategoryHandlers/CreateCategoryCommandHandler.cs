﻿using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Commands.CategoryCommands;
using CQRSProject.Entities;

namespace CQRSProject.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName,
            });
            _context.SaveChanges();
        }
    }
}