namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 批量编辑记录 响应体
/// <para>接口ID：7384730094872969244</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "success": true,
                "id": "1801464965461024",
                "errors": [
                    {
                        "code": "0",
                        "message": "success",
                        "sub_code": "k_ec_00001",
                        "fields": [
                            "_id"
                        ]
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}