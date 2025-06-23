namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 合并转发消息 请求体
/// <para>接口ID：7210967154035638275</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/merge_forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fmerge_forward</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesMergeForwardBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "receive_id": "oc_a0553eda9014c201e6969b478895c230",
    "message_id_list": ["om_d862083dd13b61cc009e66c40a0f0a56","om_61244dab1ef11257621dcd7g0e256651"]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1MessagesMergeForwardBodyDto>(json);
        Assert.IsNotNull(result);
    }
}