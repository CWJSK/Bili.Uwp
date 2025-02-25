﻿// Copyright (c) Richasy. All rights reserved.

using System.Threading.Tasks;
using Richasy.Bili.Models.BiliBili;
using Richasy.Bili.Models.Enums.App;

namespace Richasy.Bili.Lib.Interfaces
{
    /// <summary>
    /// 提供直播相关的操作.
    /// </summary>
    public interface ILiveProvider
    {
        /// <summary>
        /// 获取直播源列表.
        /// </summary>
        /// <param name="page">页码.</param>
        /// <returns><see cref="LiveFeedResponse"/>.</returns>
        Task<LiveFeedResponse> GetLiveFeedsAsync(int page);

        /// <summary>
        /// 获取直播间分区.
        /// </summary>
        /// <returns><see cref="LiveAreaResponse"/>.</returns>
        Task<LiveAreaResponse> GetLiveAreaIndexAsync();

        /// <summary>
        /// 获取直播间详情.
        /// </summary>
        /// <param name="roomId">直播间Id.</param>
        /// <returns><see cref="LiveRoomDetail"/>.</returns>
        Task<LiveRoomDetail> GetLiveRoomDetailAsync(int roomId);

        /// <summary>
        /// 获取直播间播放数据.
        /// </summary>
        /// <param name="roomId">直播间Id.</param>
        /// <param name="quality">清晰度.</param>
        /// <returns>播放信息.</returns>
        Task<LivePlayInformation> GetLivePlayInformationAsync(int roomId, int quality);

        /// <summary>
        /// 获取直播间播放数据.
        /// </summary>
        /// <param name="roomId">直播间Id.</param>
        /// <param name="quality">清晰度.</param>
        /// <param name="audioOnly">是否仅音频.</param>
        /// <returns>播放信息.</returns>
        Task<LiveAppPlayUrlInfo> GetAppLivePlayInformation(int roomId, int quality, bool audioOnly);

        /// <summary>
        /// 进入直播间.
        /// </summary>
        /// <param name="roomId">直播间Id.</param>
        /// <returns>是否成功.</returns>
        Task<bool> EnterLiveRoomAsync(int roomId);

        /// <summary>
        /// 发送消息.
        /// </summary>
        /// <param name="roomId">直播间Id.</param>
        /// <param name="message">消息内容.</param>
        /// <param name="color">弹幕颜色.</param>
        /// <param name="isStandardSize">是否为标准字体大小.</param>
        /// <param name="location">弹幕位置.</param>
        /// <returns>是否发送成功.</returns>
        Task<bool> SendMessageAsync(int roomId, string message, string color, bool isStandardSize, DanmakuLocation location);

        /// <summary>
        /// 获取直播分区详情.
        /// </summary>
        /// <param name="areaId">分区Id.</param>
        /// <param name="parentId">父分区Id.</param>
        /// <param name="sortType">排序方式.</param>
        /// <param name="pageNumber">页码.</param>
        /// <param name="pageSize">每页容量.</param>
        /// <returns><see cref="LiveAreaDetailResponse"/>.</returns>
        Task<LiveAreaDetailResponse> GetLiveAreaDetailAsync(int areaId, int parentId, string sortType, int pageNumber, int pageSize = 40);
    }
}
