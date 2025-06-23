namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 删除字段 响应体
/// <para>接口ID：6960166873968525315</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-field/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "field_id": "fldPTb0U2y",
        "deleted": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.DeleteBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}