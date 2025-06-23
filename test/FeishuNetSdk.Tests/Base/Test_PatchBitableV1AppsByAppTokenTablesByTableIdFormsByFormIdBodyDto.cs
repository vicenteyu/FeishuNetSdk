namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新表单元数据 请求体
/// <para>接口ID：7119425455108669468</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "文档问题反馈",
    "description": "请详细描述开发中遇到的问题，并附上问题截图",
    "shared": true,
    "shared_limit": "tenant_editable",
    "submit_limit_once": true
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}