namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 批量获取评论 请求体
/// <para>接口ID：7123144042921590786</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenCommentsBatchQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "comment_ids": [
        "1654857036541812356"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenCommentsBatchQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}