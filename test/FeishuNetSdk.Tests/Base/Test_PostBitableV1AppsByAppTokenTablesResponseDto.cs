namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增一个数据表 响应体
/// <para>接口ID：6960166873968541699</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "table_id": "tblDBTWm6Es84d8c",
        "default_view_id": "vewUuKOz2R",
        "field_id_list": [
            "fldhr2hBEA"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}