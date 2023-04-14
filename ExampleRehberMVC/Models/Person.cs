using System;
using System.Collections.Generic;

namespace ExampleRehberMVC.Models;

public partial class Person
{
    public long PersonId { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public long Number { get; set; }
}
