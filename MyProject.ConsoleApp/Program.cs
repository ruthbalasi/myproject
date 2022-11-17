// See https://aka.ms/new-console-template for more information

using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interface;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;


var role1 = new Role { Id = 1, Name = "admin", Description = "admin" };
var role2 = new Role { Id = 2, Name = "user", Description = "user" };

var permission1 = new Permission { Id = 10, Name = "VIEW_ALL_PRODUCTS" };
var permission2 = new Permission { Id = 20, Name = "VIEW_ALL_ORDERS" };

var claim1 = new Claim { Id = 1, RoleId = 1, PermissionId = 10, Policy = EPolicy.Allow };
var claim2 = new Claim { Id = 2, RoleId = 1, PermissionId = 20, Policy = EPolicy.Allow };
var claim3 = new Claim { Id = 3, RoleId = 2, PermissionId = 10, Policy = EPolicy.Allow };
var claim4 = new Claim { Id = 4, RoleId = 2, PermissionId = 20, Policy = EPolicy.Deny };

Console.WriteLine(claim4.Policy);

IContext mock = new MockContext();


IRoleRepositories roleRepository = new RoleRepository(mock);

Console.WriteLine( roleRepository.GetAll().ToList());
