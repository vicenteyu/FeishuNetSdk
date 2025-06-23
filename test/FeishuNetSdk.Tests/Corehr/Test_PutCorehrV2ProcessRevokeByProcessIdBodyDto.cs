namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 撤销流程 请求体
/// <para>接口ID：7431231062508142593</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/update-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_revoke%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutCorehrV2ProcessRevokeByProcessIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "ou_91791271921729102012",
    "reason": "原因自定义字符串",
    "system_user": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PutCorehrV2ProcessRevokeByProcessIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}