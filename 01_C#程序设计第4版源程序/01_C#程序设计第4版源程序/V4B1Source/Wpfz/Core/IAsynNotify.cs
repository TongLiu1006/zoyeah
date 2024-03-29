﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wpfz
{
    /// <summary>
    /// 异步通知消息
    /// </summary>
    public interface IAsyncNotify
    {
        /// <summary>
        /// 消息
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// 计时消息，格式如：已用时：4分5秒 估计剩余时间3分20秒
        /// </summary>
        string TimeMessage { get; set; }

        /// <summary>
        /// 已用时间秒数
        /// </summary>
        long UsedSecond { get; }

        /// <summary>
        /// 是否启用计时器，默认ture启用。
        /// 只有启用后计时器UsedSecond、计时消息TimeMessage才生效。
        /// </summary>
        bool IsTimerEnable { get; set; }

        /// <summary>
        /// 总任务刻度
        /// </summary>
        double Total { get; }

        /// <summary>
        /// 已完成数量
        /// </summary>
        double Completed { get; }

        /// <summary>
        /// 是否完成
        /// </summary>
        bool IsCompleted { get; }

        /// <summary>
        /// 完成百分比
        /// </summary>
        double Percent { get; }

        /// <summary>
        /// 是否执行成功，默认执行成功。若失败则Message会输出错误消息
        /// </summary>
        bool IsSuccess { get; set; }

        #region Methods

        /// <summary>
        /// 开始,total为刻度总数
        /// </summary>
        void Start(double total);

        /// <summary>
        /// 暂停时间计算
        /// </summary>
        void PauseTime();

        /// <summary>
        /// 继续计算时间
        /// </summary>
        void Continue();

        /// <summary>
        /// 执行进度，work为更新的刻度（增量刻度值）
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        void Advance(double work, string message = "");

        /// <summary>
        /// 设置实际进度。
        /// 该方法与Advance不同，Advance是累加进度，而该方法是直接设置进度
        /// 混合使用时，需要更多的控制。
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        void SetProgress(double currProgress, string message = "");

        /// <summary>
        /// 完成（手动或自动调用）
        /// </summary>
        void Complete();

        /// <summary>
        /// 取消操作，若已完成则不处理。
        /// message：界面输出的取消提示信息
        /// </summary>
        void Cancel(string message = "用户取消了当前操作");

        /// <summary>
        /// 重置
        /// </summary>
        void Reset();

        #endregion


        #region Events

        /// <summary>
        /// 当执行经度时的通知操作
        /// </summary>
        AsynNotifyAdvanceEventHandler OnAdvance { get; set; }

        /// <summary>
        /// 完成时的通知操作
        /// </summary>
        Action OnCompleted { get; set; }

        #endregion
    }

    /// <summary>
    /// 异步操作通知消息事件委托
    /// </summary>
    /// <param name="work">更新的刻度（增量刻度值）</param>
    /// <param name="message">消息</param>
    public delegate void AsynNotifyAdvanceEventHandler(double work, string message = "");
}
