namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 删除群公告中的块 响应体
/// <para>接口ID：7450053428095598620</para>
/// <para>文档地址：https://open.feishu.cn/document/group/upgraded-group-announcement/chat-announcement-block/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block-children%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_DeleteDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenBatchDeleteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "revision_id": 1,
        "client_token": "fe599b60-450f-46ff-b2ef-9f6675625b97"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.DeleteDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenBatchDeleteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}