// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1NotesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取备注列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取备注列表 响应体
/// <para>接口ID：6950644745484419099</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/note/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fnote%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1NotesResponseDto : TestBase
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
                "id": "6949805467799537964",
                "talent_id": "6916472453069883661",
                "application_id": "6891565253964859661",
                "is_private": false,
                "create_time": 1618209327096,
                "modify_time": 1618209327096,
                "creator_id": "ou_f476cb099ac9227c9bae09ce46112579",
                "content": "这是一个备注"
            }
        ],
        "has_more": true,
        "page_token": "10"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1NotesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}