// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSuiteDocsApiMetaResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取元数据 响应体
/// <para>接口ID：6907569743420637186</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/obtain-metadata</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjN3UjLzYzN14yM2cTN</para>
/// </summary>
[TestClass]
public class Test_PostSuiteDocsApiMetaResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0, 
    "msg": "Success",
    "data": { 
        "docs_metas": [ { 
                "docs_token": "doc22222",
                "docs_type": "doc",
                "title": "abc", 
                "owner_id": "12345", 
                "create_time": 123456, 
                "latest_modify_user": "12345", 
                "latest_modify_time": 123456
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSuiteDocsApiMetaResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}