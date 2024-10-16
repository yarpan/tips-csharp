

try
{
    DoSomething();
}
catch (Exception ex)
{
    LogError(ex);
    throw ex;  // Resets Stack Trace
}


try
{
    DoSomething();
}
catch (Exception ex)
{
    LogError(ex);
    throw;  // Keeps Stack Trace
}