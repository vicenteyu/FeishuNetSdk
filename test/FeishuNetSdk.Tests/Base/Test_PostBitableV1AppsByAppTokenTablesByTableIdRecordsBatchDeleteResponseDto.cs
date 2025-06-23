namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 删除多条记录 响应体
/// <para>接口ID：6952707657162620930</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "records": [
            {
                "deleted": true,
                "record_id": "recpCsf4ME"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}