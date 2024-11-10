
switch (grade)
{
    case 'A':
        result = "Excelent";
        break;
    case 'B':
        result = "Good";
        break;
    default:
        result = "May be better";
        break;
}


string result = grade switch
{
    'A' => "Excelent",
    'B' => "Good",
    _ => "May be better"
}