namespace TodoApi.Models;

//A model is a set of classes that represent the data that the app manages. The model for this app is the TodoItem class
public class TodoItem
{
    public long Id { get; set; } //functions as the unique key in a relational database
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Secret { get; set; }
}

//Model classes can go anywhere in the project, but the Models folder is used by convention