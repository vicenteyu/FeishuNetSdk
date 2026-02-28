// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-01
//
// Last Modified By : yxr
// Last Modified On : 2026-03-01
// ************************************************************************
// <copyright file="Test_GetBitableV1AppsByAppTokenBlockWorkflowsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出工作流 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出工作流 响应体
/// <para>接口ID：7530602249640755201</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-block_workflow/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-block_workflow%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenBlockWorkflowsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "workflows": [
            {
                "workflow_id": "12412312421312",
                "title": "工作流",
                "status": "Enable"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenBlockWorkflowsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}