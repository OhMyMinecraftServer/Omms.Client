using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Omms.Client.Views;

public sealed partial class TerminalPage : Page
{
    public TerminalPage()
    {
        this.InitializeComponent();
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        GC.Collect();
        InputBorder.Translation += new System.Numerics.Vector3(0, 0, 32);/*
        ListView.ItemsSource = """
            [11:36:06] [main/INFO]: Loading tweak class name optifine.OptiFineTweaker
            [11:36:06] [main/INFO]: Using primary tweak class name optifine.OptiFineTweaker
            [11:36:06] [main/INFO]: Calling tweak class optifine.OptiFineTweaker
            [11:36:06] [main/INFO]: [OptiFine] OptiFineTweaker: acceptOptions
            [11:36:06] [main/INFO]: [OptiFine] OptiFineTweaker: injectIntoClassLoader
            [11:36:06] [main/INFO]: [OptiFine] OptiFine ClassTransformer
            [11:36:06] [main/INFO]: [OptiFine] OptiFine ZIP file: D:\Minecraft\.minecraft\libraries\optifine\OptiFine\1.19.4_HD_U_I4\Optifine-1.19.4_HD_U_I4.jar
            [11:36:06] [main/INFO]: [OptiFine] OptiFineTweaker: getLaunchArguments
            [11:36:06] [main/INFO]: [OptiFine] OptiFineTweaker: getLaunchTarget
            [11:36:06] [main/INFO]: Launching wrapped minecraft {net.minecraft.client.main.Main}
            [11:36:08] [main/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.eventbus.api.Event$Result
            [11:36:08] [main/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeEntity.canUpdate
            [11:36:08] [main/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.logging.CrashReportExtender
            [11:36:08] [main/INFO]: [OptiFine] (Reflector) Method not present: ano.create
            [11:36:10] [Datafixer Bootstrap/INFO]: 180 Datafixer optimizations took 355 milliseconds
            [11:36:12] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.ForgeHooksClient
            [11:36:12] [Render thread/INFO]: Environment: authHost='https://skin.greenspray.cn/api/yggdrasil/authserver', accountsHost='http://127.0.0.1:61467/https/api.mojang.com', sessionHost='http://127.0.0.1:61467/https/sessionserver.mojang.com', servicesHost='http://127.0.0.1:61467/https/api.minecraftservices.com', name='PROD'
            [11:36:12] [Render thread/INFO]: Setting user: xuan2006
            [11:36:12] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.settings.KeyConflictContext
            [11:36:12] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: emf.getKeyModifier
            [11:36:12] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.settings.KeyModifier
            [11:36:12] [Render thread/INFO]: Backend library: LWJGL version 3.3.1 build 7
            [11:36:12] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.fml.loading.progress.EarlyProgressVisualization.handOffWindow
            [11:36:13] [Render thread/INFO]: [OptiFine] 
            [11:36:13] [Render thread/INFO]: [OptiFine] OptiFine_1.19.4_HD_U_I4
            [11:36:13] [Render thread/INFO]: [OptiFine] Build: 20230408-043701
            [11:36:13] [Render thread/INFO]: [OptiFine] OS: Windows 10 (amd64) version 10.0
            [11:36:13] [Render thread/INFO]: [OptiFine] Java: 17.0.4, Microsoft
            [11:36:13] [Render thread/INFO]: [OptiFine] VM: OpenJDK 64-Bit Server VM (mixed mode, sharing), Microsoft
            [11:36:13] [Render thread/INFO]: [OptiFine] LWJGL: 3.4.0 Win32 WGL Null EGL OSMesa VisualC DLL
            [11:36:13] [Render thread/INFO]: [OptiFine] OpenGL: NVIDIA GeForce MX450/PCIe/SSE2, version 3.2.0 NVIDIA 531.68, NVIDIA Corporation
            [11:36:13] [Render thread/INFO]: [OptiFine] OpenGL Version: 3.2.0
            [11:36:13] [Render thread/INFO]: [OptiFine] Maximum texture size: 32768x32768
            [11:36:13] [VersionCheck/INFO]: [OptiFine] Checking for new version
            [11:36:13] [Render thread/INFO]: [Shaders] OpenGL Version: 3.2.0 NVIDIA 531.68
            [11:36:13] [Render thread/INFO]: [Shaders] Vendor:  NVIDIA Corporation
            [11:36:13] [Render thread/INFO]: [Shaders] Renderer: NVIDIA GeForce MX450/PCIe/SSE2
            [11:36:13] [Render thread/INFO]: [Shaders] Capabilities:  2.0  2.1  3.0  3.2  - 
            [11:36:13] [Render thread/INFO]: [Shaders] GL_MAX_DRAW_BUFFERS: 8
            [11:36:13] [Render thread/INFO]: [Shaders] GL_MAX_COLOR_ATTACHMENTS: 8
            [11:36:13] [Render thread/INFO]: [Shaders] GL_MAX_TEXTURE_IMAGE_UNITS: 32
            [11:36:13] [Render thread/INFO]: [Shaders] Load shaders configuration.
            [11:36:13] [Render thread/INFO]: [Shaders] No shaderpack loaded.
            [11:36:13] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.fml.ModList
            [11:36:13] [Render thread/WARN]: [OptiFine] (Reflector) java.lang.ClassNotFoundException: sun.misc.SharedSecrets
            [11:36:13] [Render thread/WARN]: [OptiFine] (Reflector) java.lang.ClassNotFoundException: jdk.internal.misc.SharedSecrets
            [11:36:13] [Render thread/WARN]: [OptiFine] (Reflector) java.lang.ClassNotFoundException: sun.misc.VM
            [11:36:13] [Render thread/WARN]: [OptiFine] (Reflector) java.lang.reflect.InaccessibleObjectException: Unable to make public static long jdk.internal.misc.VM.maxDirectMemory() accessible: module java.base does not "exports jdk.internal.misc" to unnamed module @67933479
            [11:36:13] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.model.ForgeItemModelShaper
            [11:36:13] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.model.lighting.ForgeModelBlockRenderer
            [11:36:14] [VersionCheck/INFO]: [OptiFine] java.io.FileNotFoundException: http://optifine.net/version/1.19.4/HD_U.txt
            [11:36:14] [Render thread/INFO]: Narrator library for x64 successfully loaded
            [11:36:14] [Render thread/INFO]: Reloading ResourceManager: vanilla
            [11:36:14] [Render thread/INFO]: [OptiFine] *** Reloading textures ***
            [11:36:14] [Render thread/INFO]: [OptiFine] Resource packs: vanilla
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.gui.ModListScreen
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.gui.TitleScreenModUpdateIndicator
            [11:36:14] [Render thread/INFO]: [OptiFine] *** Reflector Forge ***
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.internal.BrandingControl
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.client.extensions.common.IClientItemExtensions.of
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.loading.ClientModLoader
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.event.level.ChunkDataEvent$Save
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.event.level.ChunkEvent$Load
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.event.level.ChunkEvent$Unload
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.ColorResolverManager
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.EntityRenderersEvent$AddLayers
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.EntityRenderersEvent$CreateSkullModels
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.event.entity.EntityLeaveLevelEvent
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.ViewportEvent$ComputeCameraAngles
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.event.entity.EntityJoinLevelEvent
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.eventbus.api.Event.getResult
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.eventbus.api.IEventBus
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: fiw.getTexture
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: fjc.getFaceData
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeBlockState.getSoundType
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeBlockState.getStateAtViewpoint
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeBlockState.shouldDisplayFluidOverlay
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeEntity.getEyeInFluidType
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeEntity.getParts
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeEntity.hasCustomOutlineRendering
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeEntity.isMultipartEntity
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeEntity.onAddedToWorld
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeEntity.onRemovedFromWorld
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeEntity.shouldRiderSit
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.common.extensions.IForgePlayer
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Field not present: aib.currentlyLoading
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.event.ForgeEventFactory
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.common.ForgeHooks
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Field not present: net.minecraftforge.common.ForgeConfig$Client.experimentalForgeLightPipelineEnabled
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Field not present: net.minecraftforge.common.ForgeConfig$Client.useCombinedDepthStencilAttachment
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Field not present: net.minecraftforge.common.ForgeConfigSpec.childConfig
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Field not present: net.minecraftforge.common.ForgeConfigSpec$ConfigValue.defaultSupplier
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Field not present: net.minecraftforge.common.ForgeConfigSpec$ConfigValue.spec
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.ForgeConfigSpec$ConfigValue.get
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: ddn.getWorldForge
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.common.extensions.IForgeItem
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.common.extensions.IForgeItemStack
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.common.ForgeI18n
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: emf.setKeyConflictContext
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: emf.setKeyModifierAndCode
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: dxr.render
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: cgm.getStyleModifier
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Field not present: ait.forceTicks
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: ait.isForceTicks
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeBlockEntity.getRenderBoundingBox
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: net.minecraftforge.common.extensions.IForgeBlockEntity.hasCustomOutlineRendering
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.extensions.IForgeDimensionSpecialEffects
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.ItemDecoratorHandler
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.model.geometry.GeometryLoaderManager
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.common.MinecraftForge
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.fml.ModContainer
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.fml.ModLoader
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.event.PlayLevelSoundEvent
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.model.pipeline.QuadBakingVertexConsumer
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.model.QuadTransformers
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.model.IQuadTransformer
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.RegisterShadersEvent
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.RenderBlockScreenEffectEvent$OverlayType
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.CustomizeGuiOverlayEvent$BossEventProgress
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.RenderItemInFrameEvent
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.RenderLivingEvent$Pre
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.RenderLivingEvent$Post
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.RenderNameTagEvent
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.client.event.ScreenshotEvent
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.server.ServerLifecycleHooks
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Method not present: fgx.updateSprite
            [11:36:14] [Render thread/INFO]: [OptiFine] (Reflector) Class not present: net.minecraftforge.event.level.LevelEvent$Load
            [11:36:14] [Render thread/INFO]: [OptiFine] *** Reflector Vanilla ***
            [11:36:14] [Worker-Main-1/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/banner_patterns.png
            [11:36:14] [Worker-Main-6/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/signs.png
            [11:36:14] [Worker-Main-6/INFO]: [OptiFine] Multitexture: false
            [11:36:14] [Worker-Main-1/INFO]: [OptiFine] Multitexture: false
            [11:36:14] [Worker-Main-7/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/shield_patterns.png
            [11:36:14] [Worker-Main-7/INFO]: [OptiFine] Multitexture: false
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/blocks.png
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] Multitexture: false
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/00_glass_white/glass_pane_white.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/00_glass_white/glass_white.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/01_glass_orange/glass_orange.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/01_glass_orange/glass_pane_orange.properties
            [11:36:14] [Worker-Main-3/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/armor_trims.png
            [11:36:14] [Worker-Main-3/INFO]: [OptiFine] Multitexture: false
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/02_glass_magenta/glass_magenta.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/02_glass_magenta/glass_pane_magenta.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/03_glass_light_blue/glass_light_blue.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/03_glass_light_blue/glass_pane_light_blue.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/04_glass_yellow/glass_pane_yellow.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/04_glass_yellow/glass_yellow.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/05_glass_lime/glass_lime.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/05_glass_lime/glass_pane_lime.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/06_glass_pink/glass_pane_pink.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/06_glass_pink/glass_pink.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/07_glass_gray/glass_gray.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/07_glass_gray/glass_pane_gray.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/08_glass_light_gray/glass_light_gray.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/08_glass_light_gray/glass_pane_light_gray.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/09_glass_cyan/glass_cyan.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/09_glass_cyan/glass_pane_cyan.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/10_glass_purple/glass_pane_purple.properties
            [11:36:14] [Worker-Main-3/INFO]: [OptiFine] Mipmap levels: 4
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/10_glass_purple/glass_purple.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/11_glass_blue/glass_blue.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/11_glass_blue/glass_pane_blue.properties
            [11:36:14] [Worker-Main-6/INFO]: [OptiFine] Sprite size: 64
            [11:36:14] [Worker-Main-6/INFO]: [OptiFine] Mipmap levels: 6
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/12_glass_brown/glass_brown.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/12_glass_brown/glass_pane_brown.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/13_glass_green/glass_green.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/13_glass_green/glass_pane_green.properties
            [11:36:14] [Worker-Main-6/INFO]: [OptiFine] Scaled too small texture: minecraft:missingno, 16 -> 64
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/14_glass_red/glass_pane_red.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/14_glass_red/glass_red.properties
            [11:36:14] [Worker-Main-1/INFO]: [OptiFine] Sprite size: 64
            [11:36:14] [Worker-Main-1/INFO]: [OptiFine] Mipmap levels: 6
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/15_glass_black/glass_black.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/15_glass_black/glass_pane_black.properties
            [11:36:14] [Worker-Main-7/INFO]: [OptiFine] Sprite size: 64
            [11:36:14] [Worker-Main-7/INFO]: [OptiFine] Mipmap levels: 6
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/20_glass/glass.properties
            [11:36:14] [Worker-Main-1/INFO]: [OptiFine] Scaled too small texture: minecraft:missingno, 16 -> 64
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/20_glass/glass_pane.properties
            [11:36:14] [Worker-Main-7/INFO]: [OptiFine] Scaled too small texture: minecraft:missingno, 16 -> 64
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/21_tinted_glass/tinted_glass.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/30_bookshelf/bookshelf.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/40_sandstone/sandstone.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] ConnectedTextures: optifine/ctm/default/41_red_sandstone/red_sandstone.properties
            [11:36:14] [Worker-Main-2/INFO]: [OptiFine] Multipass connected textures: false
            [11:36:14] [Worker-Main-7/INFO]: [OptiFine] Scaled too small texture: minecraft:optifine/ctm/default/empty, 16 -> 64
            [11:36:14] [Worker-Main-1/INFO]: [OptiFine] Scaled too small texture: minecraft:optifine/ctm/default/empty, 16 -> 64
            [11:36:14] [Worker-Main-6/INFO]: [OptiFine] Scaled too small texture: minecraft:optifine/ctm/default/empty, 16 -> 64
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/chest.png
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Multitexture: false
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Sprite size: 64
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Mipmap levels: 6
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Scaled too small texture: minecraft:missingno, 16 -> 64
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Scaled too small texture: minecraft:optifine/ctm/default/empty, 16 -> 64
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/decorated_pot.png
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Multitexture: false
            [11:36:15] [Worker-Main-1/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/shulker_boxes.png
            [11:36:15] [Worker-Main-1/INFO]: [OptiFine] Multitexture: false
            [11:36:15] [Worker-Main-7/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/beds.png
            [11:36:15] [Worker-Main-7/INFO]: [OptiFine] Multitexture: false
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Mipmap levels: 4
            [11:36:15] [Worker-Main-1/INFO]: [OptiFine] Sprite size: 64
            [11:36:15] [Worker-Main-1/INFO]: [OptiFine] Mipmap levels: 6
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/particles.png
            [11:36:15] [Worker-Main-6/INFO]: [OptiFine] Multitexture: false
            [11:36:15] [Worker-Main-1/INFO]: [OptiFine] Scaled too small texture: minecraft:missingno, 16 -> 64
            [11:36:15] [Worker-Main-1/INFO]: [OptiFine] Scaled too small texture: minecraft:optifine/ctm/default/empty, 16 -> 64
            [11:36:15] [Worker-Main-3/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/paintings.png
            [11:36:15] [Worker-Main-3/INFO]: [OptiFine] Multitexture: false
            [11:36:15] [Worker-Main-1/INFO]: [OptiFine] Pre-stitch: minecraft:textures/atlas/mob_effects.png
            [11:36:15] [Worker-Main-1/INFO]: [OptiFine] Multitexture: false
            [11:36:15] [Worker-Main-7/INFO]: [OptiFine] Sprite size: 64
            [11:36:15] [Worker-Main-7/INFO]: [OptiFine] Mipmap levels: 6
            [11:36:15] [Worker-Main-7/INFO]: [OptiFine] Scaled too small texture: minecraft:missingno, 16 -> 64
            [11:36:15] [Worker-Main-7/INFO]: [OptiFine] Scaled too small texture: minecraft:optifine/ctm/default/empty, 16 -> 64
            [11:36:16] [Realms Notification Availability checker #1/INFO]: Could not authorize you against Realms server: Invalid session id
            [11:36:16] [Worker-Main-2/INFO]: [OptiFine] BetterGrass: Parsing default configuration optifine/bettergrass.properties
            [11:36:18] [Worker-Main-2/INFO]: [OptiFine] Mipmap levels: 4
            [11:36:20] [Render thread/WARN]: Missing sound for event: minecraft:item.brush.brushing
            [11:36:20] [Render thread/WARN]: Missing sound for event: minecraft:item.brush.brush_sand_completed
            [11:36:20] [Render thread/WARN]: Missing sound for event: minecraft:item.goat_horn.play
            [11:36:20] [Render thread/WARN]: Missing sound for event: minecraft:entity.goat.screaming.horn_break
            [11:36:20] [Render thread/WARN]: Missing sound for event: minecraft:music.overworld.cherry_grove
            [11:36:20] [Render thread/INFO]: OpenAL initialized on device OpenAL Soft on 扬声器 (Realtek(R) Audio)
            [11:36:20] [Render thread/INFO]: Sound engine started
            [11:36:20] [Render thread/INFO]: Created: 1024x1024x4 minecraft:textures/atlas/blocks.png-atlas
            [11:36:20] [Render thread/INFO]: [OptiFine] Animated sprites: 51
            [11:36:20] [Render thread/INFO]: Created: 256x256x4 minecraft:textures/atlas/signs.png-atlas
            [11:36:20] [Render thread/INFO]: [OptiFine] Animated sprites: 0
            [11:36:20] [Render thread/INFO]: Created: 512x512x4 minecraft:textures/atlas/banner_patterns.png-atlas
            [11:36:20] [Render thread/INFO]: [OptiFine] Animated sprites: 0
            [11:36:20] [Render thread/INFO]: Created: 512x512x4 minecraft:textures/atlas/shield_patterns.png-atlas
            [11:36:20] [Render thread/INFO]: [OptiFine] Animated sprites: 0
            [11:36:20] [Render thread/INFO]: Created: 1024x1024x4 minecraft:textures/atlas/armor_trims.png-atlas
            [11:36:20] [Render thread/INFO]: [OptiFine] Animated sprites: 0
            
            """.Split("\r\n");*/
    }
}
