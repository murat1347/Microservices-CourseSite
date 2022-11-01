﻿using FreeCourse.Services.Catalog.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Services.Catalog.Dtos
{
    public class CourseDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedTime { get; set; }
        public Feature Feature { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
