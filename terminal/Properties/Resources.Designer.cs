﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaiFeng.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HaiFeng.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Close {
            get {
                object obj = ResourceManager.GetObject("Close", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (Icon) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon HF {
            get {
                object obj = ResourceManager.GetObject("HF", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Open {
            get {
                object obj = ResourceManager.GetObject("Open", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;GB2312&quot; ?&gt;
        ///
        ///&lt;root  UpgradeURL=&quot;http://upgrade.quick7.net/q7/yhqh/real/upgrade.xml&quot;&gt;
        ///	&lt;broker BrokerID=&quot;9999&quot; BrokerName=&quot;模拟&quot;&gt;
        ///		&lt;FloatProfitAlgorithm&gt;浮盈不计，浮亏计&lt;/FloatProfitAlgorithm&gt;		
        ///		&lt;!--
        ///			&quot;浮盈浮亏都计算&quot;;
        ///			&quot;浮盈不计，浮亏计&quot;;
        ///			&quot;浮盈计，浮亏不计&quot;;
        ///			&quot;浮盈浮亏都不计算&quot;;
        ///		--&gt;
        ///		&lt;MarginAlgorithm&gt;按开仓价计算&lt;/MarginAlgorithm&gt;
        ///		&lt;!--
        ///			&quot;按前结算计算&quot;;
        ///			&quot;按最新价计算&quot;;
        ///			&quot;盘中按最新价计算, 盘后按结算价计算&quot;;
        ///			&quot;按最新均价计算&quot;;
        ///			&quot;按开仓价计算&quot;;
        ///		--&gt;		
        ///		&lt;IsDiscountCZCE&gt;1&lt;/IsDiscountCZCE&gt;		
        ///		&lt;!--
        ///			郑州组合是否优惠
        ///		--&gt;		
        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string simnow {
            get {
                return ResourceManager.GetString("simnow", resourceCulture);
            }
        }
    }
}
