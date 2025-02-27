using System;
using System.Collections.Generic;

namespace WebTest.DB;

public partial class Task
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool IsCompleted { get; set; } = false;

    public string ColorBox { get; set; } = "col-sm-2 bg-danger m-3 text-light";
}
