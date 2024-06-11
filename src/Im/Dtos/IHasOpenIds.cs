namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 用户Id
    /// </summary>
    public interface IHasOpenIds
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        string[]? OpenIds { get; set; }
    }
}
