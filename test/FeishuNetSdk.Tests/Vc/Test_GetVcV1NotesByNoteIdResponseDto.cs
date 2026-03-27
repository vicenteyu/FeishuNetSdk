// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_GetVcV1NotesByNoteIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取纪要详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取纪要详情 响应体
/// <para>接口ID：7621600266278522080</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/note/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fnote%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVcV1NotesByNoteIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "note": {
            "creator_id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
            "create_time": "1773922587",
            "artifacts": [
                {
                    "artifact_type": 1,
                    "create_time": "1773922587",
                    "doc_token": "BkX1wpU0gi6WP4klwRGchoqZntv"
                }
            ],
            "references": [
                {
                    "reference_type": 1,
                    "doc_token": "fqF1wpU0gi6WP4klwRGchoqqweA"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1NotesByNoteIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}