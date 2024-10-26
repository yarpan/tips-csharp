// Ways to guard against null arguments

// 1a
if (args is null)
{
    throw new ArgumentNullException(nameof(args));
}

// 1b
ArgumentNullException.ThrowIfNull(args);

// 1c
value = arg ??
    throw new ArgumentNullException(nameof(arg));


//========================================
// Conditional expression
// 2a
if (customer is not null &&
    customer.Orders is not null)
{
    customer.Orders.Ship();
}

// 2b 
customer?.Orders?.Ship();


//========================================
//Check for NOT null
//3a 
if (student != null)
{
    Console.Writeline('Student is NOT null');
}

//3b
if (student is not null)
{
    Console.Writeline('Student is NOT null');
}

//3c 
if (student is { })
{
    Console.Writeline('Student is NOT null');
}


//========================================
