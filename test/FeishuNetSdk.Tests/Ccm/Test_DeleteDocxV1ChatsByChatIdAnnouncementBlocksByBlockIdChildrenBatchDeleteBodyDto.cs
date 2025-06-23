namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 删除群公告中的块 请求体
/// <para>接口ID：7450053428095598620</para>
/// <para>文档地址：https://open.feishu.cn/document/group/upgraded-group-announcement/chat-announcement-block/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block-children%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_DeleteDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "start_index": 0,
    "end_index": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.DeleteDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}