// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出表单问题 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出表单问题 响应体
/// <para>接口ID：7112628058154909698</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form-field%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsResponseDto : TestBase
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
                "field_id": "fldjX7dUj5",
                "title": "任务名称",
                "description": "请概述该任务",
                "required": true,
                "visible": true
            }
        ],
        "page_token": "fld1lAbHh7",
        "has_more": true,
        "total": 1
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}