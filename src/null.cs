// Ways to guard against null arguments


// 1a
if (args is null){
    throw new ArgumentNullException(nameof(args));
}

// 1b
ArgumentNullException.ThrowIfNull(args);

// 1c
value = arg ??
    throw new ArgumentNullException(nameof(arg));



// 2a
if (customer is not null &&
    customer.Orders is not null)
    {
        customer.Orders.Ship();
    }


// 2b 
customer?.Orders?.Ship();

