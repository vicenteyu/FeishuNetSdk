// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDriveV1FilesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取文件夹中的文件清单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取文件夹中的文件清单 响应体
/// <para>接口ID：7108600920377016348</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1FilesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "data":{
        "files":[
            {
                "name":"test pdf.pdf",
                "parent_token":"fldbcO1UuPz8VwnpPx5a9abcef",
                "token":"boxbc0dGSMu23m7QkC1bvabcef",
                "type":"file",
                "created_time":"1679277808",
                "modified_time":"1679277808",
                "owner_id":"ou_20b31734443364ec8a1df89fdf325b44",
                "url":"https://feishu.cn/file/boxbc0dGSMu23m7QkC1bvabcef"
            },
            {
                "name":"test file.docx",
                "parent_token":"fldcnCEG903UUB4fUqfysdabcef",
                "shortcut_info":{
                    "target_token":"boxcnRPaXpD4I6Je9t8k8babcef",
                    "target_type":"file"
                },
                "token":"nodcnVkiLQ6LD4CsUEaANrabcef",
                "type":"shortcut",
                "created_time":"1679295364",
                "modified_time":"1679295364",
                "owner_id":"ou_20b31734443364ec8a1df89fdf325b44",
                "url":"https://feishu.cn/file/boxcnRPaXpD4I6Je9t8k8babcef"
            },
            {
                "name":"test docx",
                "parent_token":"fldcnCEG903UUB4fUqfysdabcef",
                "token":"doxcntan34DX4QoKJu7jJyabcef",
                "type":"docx",
                "created_time":"1679295364",
                "modified_time":"1679295364",
                "owner_id":"ou_20b31734443364ec8a1df89fdf325b44",
                "url":"https://feishu.cn/docx/doxcntan34DX4QoKJu7jJyabcef"
            },
            {
                "name":"test sheet",
                "parent_token":"fldcnCEG903UUB4fUqfysdabcef",
                "token":"shtcnOko1Ad0HU48HH8KHuabcef",
                "type":"sheet",
                "created_time":"1679295364",
                "modified_time":"1679295364",
                "owner_id":"ou_20b31734443364ec8a1df89fdf325b44",
                "url":"https://feishu.cn/sheets/shtcnOko1Ad0HU48HH8KHuabcef"
            }
        ],
        "has_more":false
    },
    "msg":"success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1FilesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}