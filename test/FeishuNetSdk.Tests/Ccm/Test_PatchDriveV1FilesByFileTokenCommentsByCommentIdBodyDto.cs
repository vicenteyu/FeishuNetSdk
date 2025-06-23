namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 解决/恢复评论 请求体
/// <para>接口ID：6955017385137766401</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchDriveV1FilesByFileTokenCommentsByCommentIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "is_solved": true
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PatchDriveV1FilesByFileTokenCommentsByCommentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}