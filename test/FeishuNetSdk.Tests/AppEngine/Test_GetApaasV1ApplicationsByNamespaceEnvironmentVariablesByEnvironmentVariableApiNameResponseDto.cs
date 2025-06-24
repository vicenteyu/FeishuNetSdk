// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetApaasV1ApplicationsByNamespaceEnvironmentVariablesByEnvironmentVariableApiNameResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询环境变量详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询环境变量详情 响应体
/// <para>接口ID：7385474062586314754</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-environment_variable/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-environment_variable%2fget</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1ApplicationsByNamespaceEnvironmentVariablesByEnvironmentVariableApiNameResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "item": {
            "api_name": "globalParam_0b410b17704",
            "label": {
                "zh_cn": "示例文本",
                "en_us": "Sample text"
            },
            "description": "Sample text",
            "value": "[1757083131077684,1757085362739239,1757083720703032]",
            "is_encrypted": false,
            "object_api_name": "_user",
            "object_label": {
                "zh_cn": "示例文本",
                "en_us": "Sample text"
            },
            "created_at": 1718350902019,
            "updated_at": 1718350902019,
            "type": "lookup"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1ApplicationsByNamespaceEnvironmentVariablesByEnvironmentVariableApiNameResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}