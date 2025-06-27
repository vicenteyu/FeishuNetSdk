// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DriveFileCreatedInFolderV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 文件夹下文件创建 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Events;

/// <summary>
/// 测试 文件夹下文件创建 事件体
/// <para>接口ID：7443780882928549892</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/drive-v1/event/list/created_in_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fevents%2fcreated_in_folder</para>
/// </summary>
[TestClass]
public class Test_DriveFileCreatedInFolderV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "drive.file.created_in_folder_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "file_type": "docx",
        "file_token": "TLLKdcpDro9ijQxA33ycNMabcef",
        "folder_token": "QBonfpyHVlhQMedDztWcIbabcef",
        "operator_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "subscriber_ids": [
            {
                "union_id": "on_876b570a984d02ab1c0906a49e4abcef",
                "user_id": "638474b8",
                "open_id": "ou_9bc587355789fc049904ae7c736abcef"
            }
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Ccm.Events.DriveFileCreatedInFolderV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}