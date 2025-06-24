// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DriveFileBitableRecordChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 多维表格记录变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Events;

/// <summary>
/// 测试 多维表格记录变更 事件体
/// <para>接口ID：7374619918313455620</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/events/bitable_record_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fevents%2fbitable_record_changed</para>
/// </summary>
[TestClass]
public class Test_DriveFileBitableRecordChangedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "drive.file.bitable_record_changed_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "file_type": "bitable",
        "file_token": "bascnItn6oHUSEL8RDUdF6abcef",
        "table_id": "tblOaqBWfGeabcef",
        "revision": 41,
        "operator_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "action_list": [
            {
                "record_id": "rec9sabcef",
                "action": "record_edited",
                "before_value": [
                    {
                        "field_id": "fld9Eabcef",
                        "field_value": "666",
                        "field_identity_value": {
                            "users": [
                                {
                                    "user_id": {
                                        "union_id": "on_8ed6aa67826108097d9ee143816345",
                                        "user_id": "e33ggbyz",
                                        "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                                    },
                                    "name": "张敏",
                                    "en_name": "Zhangmin",
                                    "avatar_url": "https://internal-api-lark-file.feishu.cn/static-resource/v1/v2_q86-fcb6-4f18-85c7-87ca8881e50j~?image_size=72x72&amp;cut_type=default-face&amp;quality=&amp;format=jpeg&amp;sticker_format=.webp"
                                }
                            ]
                        }
                    }
                ],
                "after_value": [
                    {
                        "field_id": "fld9Eabcef",
                        "field_value": "666",
                        "field_identity_value": {
                            "users": [
                                {
                                    "user_id": {
                                        "union_id": "on_8ed6aa67826108097d9ee143816345",
                                        "user_id": "e33ggbyz",
                                        "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                                    },
                                    "name": "张敏",
                                    "en_name": "Zhangmin",
                                    "avatar_url": "https://internal-api-lark-file.feishu.cn/static-resource/v1/v2_q86-fcb6-4f18-85c7-87ca8881e50j~?image_size=72x72&amp;cut_type=default-face&amp;quality=&amp;format=jpeg&amp;sticker_format=.webp"
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "subscriber_id_list": [
            {
                "union_id": "on_876b570a984d02ab1c0906a49e4abcef",
                "user_id": "638474b8",
                "open_id": "ou_9bc587355789fc049904ae7c736abcef"
            }
        ],
        "update_time": 1717040601
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Ccm.Events.DriveFileBitableRecordChangedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}