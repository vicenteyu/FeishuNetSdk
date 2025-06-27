// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量新建记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 批量新建记录 响应体
/// <para>接口ID：7384730094872985628</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchCreateResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}