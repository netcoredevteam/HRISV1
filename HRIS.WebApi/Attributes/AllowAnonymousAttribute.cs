namespace HRIS.WebApi.Attributes
{
    #region AllowAnonymous Attribute
    /// <summary>
    /// Allow usage without defined roles
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class AllowAnonymousAttribute : Attribute
    { } 
    #endregion
}
