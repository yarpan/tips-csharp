//Ways to guard against null arguments


//1
if (args is null){
    throw new ArgumentNullException(nameof(args));
}


//2
ArgumentNullException.ThrowIfNull(args);


//3
value = arg ??
    throw new ArgumentNullException(nameof(arg))