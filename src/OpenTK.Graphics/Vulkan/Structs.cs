// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecsCommon;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1stdDecode;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public unsafe struct VkBaseOutStructure
    {
        public VkStructureType sType;
        public VkBaseOutStructure* pNext;
        public VkBaseOutStructure(VkStructureType sType, VkBaseOutStructure* pNext)
        {
            this.sType = sType;
            this.pNext = pNext;
        }
    }
    public unsafe struct VkBaseInStructure
    {
        public VkStructureType sType;
        public VkBaseInStructure* pNext;
        public VkBaseInStructure(VkStructureType sType, VkBaseInStructure* pNext)
        {
            this.sType = sType;
            this.pNext = pNext;
        }
    }
    public unsafe struct VkOffset2D
    {
        public int x;
        public int y;
        public VkOffset2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public unsafe struct VkOffset3D
    {
        public int x;
        public int y;
        public int z;
        public VkOffset3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    public unsafe struct VkExtent2D
    {
        public uint width;
        public uint height;
        public VkExtent2D(uint width, uint height)
        {
            this.width = width;
            this.height = height;
        }
    }
    public unsafe struct VkExtent3D
    {
        public uint width;
        public uint height;
        public uint depth;
        public VkExtent3D(uint width, uint height, uint depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }
    public unsafe struct VkViewport
    {
        public float x;
        public float y;
        public float width;
        public float height;
        public float minDepth;
        public float maxDepth;
        public VkViewport(float x, float y, float width, float height, float minDepth, float maxDepth)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.minDepth = minDepth;
            this.maxDepth = maxDepth;
        }
    }
    public unsafe struct VkRect2D
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
        public VkRect2D(VkOffset2D offset, VkExtent2D extent)
        {
            this.offset = offset;
            this.extent = extent;
        }
    }
    public unsafe struct VkClearRect
    {
        public VkRect2D rect;
        public uint baseArrayLayer;
        public uint layerCount;
        public VkClearRect(VkRect2D rect, uint baseArrayLayer, uint layerCount)
        {
            this.rect = rect;
            this.baseArrayLayer = baseArrayLayer;
            this.layerCount = layerCount;
        }
    }
    public unsafe struct VkComponentMapping
    {
        public VkComponentSwizzle r;
        public VkComponentSwizzle g;
        public VkComponentSwizzle b;
        public VkComponentSwizzle a;
        public VkComponentMapping(VkComponentSwizzle r, VkComponentSwizzle g, VkComponentSwizzle b, VkComponentSwizzle a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
    }
    public unsafe struct VkPhysicalDeviceProperties
    {
        public uint apiVersion;
        public uint driverVersion;
        public uint vendorID;
        public uint deviceID;
        public VkPhysicalDeviceType deviceType;
        [InlineArray(256)]
        public struct deviceNameInlineArray1
        {
            public byte element;
        }
        public deviceNameInlineArray1 deviceName;
        public fixed byte pipelineCacheUUID[16];
        public VkPhysicalDeviceLimits limits;
        public VkPhysicalDeviceSparseProperties sparseProperties;
    }
    public unsafe struct VkExtensionProperties
    {
        [InlineArray(256)]
        public struct extensionNameInlineArray1
        {
            public byte element;
        }
        public extensionNameInlineArray1 extensionName;
        public uint specVersion;
    }
    public unsafe struct VkLayerProperties
    {
        [InlineArray(256)]
        public struct layerNameInlineArray1
        {
            public byte element;
        }
        public layerNameInlineArray1 layerName;
        public uint specVersion;
        public uint implementationVersion;
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
    }
    public unsafe struct VkApplicationInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeApplicationInfo;
        public void* pNext;
        public byte* pApplicationName;
        public uint applicationVersion;
        public byte* pEngineName;
        public uint engineVersion;
        public uint apiVersion;
        public VkApplicationInfo(VkStructureType sType, void* pNext, byte* pApplicationName, uint applicationVersion, byte* pEngineName, uint engineVersion, uint apiVersion)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pApplicationName = pApplicationName;
            this.applicationVersion = applicationVersion;
            this.pEngineName = pEngineName;
            this.engineVersion = engineVersion;
            this.apiVersion = apiVersion;
        }
    }
    public unsafe struct VkAllocationCallbacks
    {
        public void* pUserData;
        public delegate* unmanaged[Cdecl]<void*, nuint, nuint, VkSystemAllocationScope, void*> pfnAllocation;
        public delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> pfnReallocation;
        public delegate* unmanaged[Cdecl]<void*, void*, void> pfnFree;
        public delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalAllocation;
        public delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalFree;
        public VkAllocationCallbacks(void* pUserData, delegate* unmanaged[Cdecl]<void*, nuint, nuint, VkSystemAllocationScope, void*> pfnAllocation, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> pfnReallocation, delegate* unmanaged[Cdecl]<void*, void*, void> pfnFree, delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalAllocation, delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalFree)
        {
            this.pUserData = pUserData;
            this.pfnAllocation = pfnAllocation;
            this.pfnReallocation = pfnReallocation;
            this.pfnFree = pfnFree;
            this.pfnInternalAllocation = pfnInternalAllocation;
            this.pfnInternalFree = pfnInternalFree;
        }
    }
    public unsafe struct VkDeviceQueueCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceQueueCreateInfo;
        public void* pNext;
        public VkDeviceQueueCreateFlagBits flags;
        public uint queueFamilyIndex;
        public uint queueCount;
        public float* pQueuePriorities;
        public VkDeviceQueueCreateInfo(VkStructureType sType, void* pNext, VkDeviceQueueCreateFlagBits flags, uint queueFamilyIndex, uint queueCount, float* pQueuePriorities)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.queueFamilyIndex = queueFamilyIndex;
            this.queueCount = queueCount;
            this.pQueuePriorities = pQueuePriorities;
        }
    }
    public unsafe struct VkDeviceCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceCreateInfo;
        public void* pNext;
        public VkDeviceCreateFlags flags;
        public uint queueCreateInfoCount;
        public VkDeviceQueueCreateInfo* pQueueCreateInfos;
        public uint enabledLayerCount;
        public byte** ppEnabledLayerNames;
        public uint enabledExtensionCount;
        public byte** ppEnabledExtensionNames;
        public VkPhysicalDeviceFeatures* pEnabledFeatures;
        public VkDeviceCreateInfo(VkStructureType sType, void* pNext, VkDeviceCreateFlags flags, uint queueCreateInfoCount, VkDeviceQueueCreateInfo* pQueueCreateInfos, uint enabledLayerCount, byte** ppEnabledLayerNames, uint enabledExtensionCount, byte** ppEnabledExtensionNames, VkPhysicalDeviceFeatures* pEnabledFeatures)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.queueCreateInfoCount = queueCreateInfoCount;
            this.pQueueCreateInfos = pQueueCreateInfos;
            this.enabledLayerCount = enabledLayerCount;
            this.ppEnabledLayerNames = ppEnabledLayerNames;
            this.enabledExtensionCount = enabledExtensionCount;
            this.ppEnabledExtensionNames = ppEnabledExtensionNames;
            this.pEnabledFeatures = pEnabledFeatures;
        }
    }
    public unsafe struct VkInstanceCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeInstanceCreateInfo;
        public void* pNext;
        public VkInstanceCreateFlagBits flags;
        public VkApplicationInfo* pApplicationInfo;
        public uint enabledLayerCount;
        public byte** ppEnabledLayerNames;
        public uint enabledExtensionCount;
        public byte** ppEnabledExtensionNames;
        public VkInstanceCreateInfo(VkStructureType sType, void* pNext, VkInstanceCreateFlagBits flags, VkApplicationInfo* pApplicationInfo, uint enabledLayerCount, byte** ppEnabledLayerNames, uint enabledExtensionCount, byte** ppEnabledExtensionNames)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pApplicationInfo = pApplicationInfo;
            this.enabledLayerCount = enabledLayerCount;
            this.ppEnabledLayerNames = ppEnabledLayerNames;
            this.enabledExtensionCount = enabledExtensionCount;
            this.ppEnabledExtensionNames = ppEnabledExtensionNames;
        }
    }
    public unsafe struct VkQueueFamilyProperties
    {
        public VkQueueFlagBits queueFlags;
        public uint queueCount;
        public uint timestampValidBits;
        public VkExtent3D minImageTransferGranularity;
        public VkQueueFamilyProperties(VkQueueFlagBits queueFlags, uint queueCount, uint timestampValidBits, VkExtent3D minImageTransferGranularity)
        {
            this.queueFlags = queueFlags;
            this.queueCount = queueCount;
            this.timestampValidBits = timestampValidBits;
            this.minImageTransferGranularity = minImageTransferGranularity;
        }
    }
    public unsafe struct VkPhysicalDeviceMemoryProperties
    {
        public uint memoryTypeCount;
        [InlineArray(32)]
        public struct memoryTypesInlineArray1
        {
            public VkMemoryType element;
        }
        public memoryTypesInlineArray1 memoryTypes;
        public uint memoryHeapCount;
        [InlineArray(16)]
        public struct memoryHeapsInlineArray1
        {
            public VkMemoryHeap element;
        }
        public memoryHeapsInlineArray1 memoryHeaps;
    }
    public unsafe struct VkMemoryAllocateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryAllocateInfo;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeIndex;
        public VkMemoryAllocateInfo(VkStructureType sType, void* pNext, ulong allocationSize, uint memoryTypeIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.allocationSize = allocationSize;
            this.memoryTypeIndex = memoryTypeIndex;
        }
    }
    public unsafe struct VkMemoryRequirements
    {
        public ulong size;
        public ulong alignment;
        public uint memoryTypeBits;
        public VkMemoryRequirements(ulong size, ulong alignment, uint memoryTypeBits)
        {
            this.size = size;
            this.alignment = alignment;
            this.memoryTypeBits = memoryTypeBits;
        }
    }
    public unsafe struct VkSparseImageFormatProperties
    {
        public VkImageAspectFlagBits aspectMask;
        public VkExtent3D imageGranularity;
        public VkSparseImageFormatFlagBits flags;
        public VkSparseImageFormatProperties(VkImageAspectFlagBits aspectMask, VkExtent3D imageGranularity, VkSparseImageFormatFlagBits flags)
        {
            this.aspectMask = aspectMask;
            this.imageGranularity = imageGranularity;
            this.flags = flags;
        }
    }
    public unsafe struct VkSparseImageMemoryRequirements
    {
        public VkSparseImageFormatProperties formatProperties;
        public uint imageMipTailFirstLod;
        public ulong imageMipTailSize;
        public ulong imageMipTailOffset;
        public ulong imageMipTailStride;
        public VkSparseImageMemoryRequirements(VkSparseImageFormatProperties formatProperties, uint imageMipTailFirstLod, ulong imageMipTailSize, ulong imageMipTailOffset, ulong imageMipTailStride)
        {
            this.formatProperties = formatProperties;
            this.imageMipTailFirstLod = imageMipTailFirstLod;
            this.imageMipTailSize = imageMipTailSize;
            this.imageMipTailOffset = imageMipTailOffset;
            this.imageMipTailStride = imageMipTailStride;
        }
    }
    public unsafe struct VkMemoryType
    {
        public VkMemoryPropertyFlagBits propertyFlags;
        public uint heapIndex;
        public VkMemoryType(VkMemoryPropertyFlagBits propertyFlags, uint heapIndex)
        {
            this.propertyFlags = propertyFlags;
            this.heapIndex = heapIndex;
        }
    }
    public unsafe struct VkMemoryHeap
    {
        public ulong size;
        public VkMemoryHeapFlagBits flags;
        public VkMemoryHeap(ulong size, VkMemoryHeapFlagBits flags)
        {
            this.size = size;
            this.flags = flags;
        }
    }
    public unsafe struct VkMappedMemoryRange
    {
        public VkStructureType sType = VkStructureType.StructureTypeMappedMemoryRange;
        public void* pNext;
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
        public VkMappedMemoryRange(VkStructureType sType, void* pNext, VkDeviceMemory memory, ulong offset, ulong size)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memory = memory;
            this.offset = offset;
            this.size = size;
        }
    }
    public unsafe struct VkFormatProperties
    {
        public VkFormatFeatureFlagBits linearTilingFeatures;
        public VkFormatFeatureFlagBits optimalTilingFeatures;
        public VkFormatFeatureFlagBits bufferFeatures;
        public VkFormatProperties(VkFormatFeatureFlagBits linearTilingFeatures, VkFormatFeatureFlagBits optimalTilingFeatures, VkFormatFeatureFlagBits bufferFeatures)
        {
            this.linearTilingFeatures = linearTilingFeatures;
            this.optimalTilingFeatures = optimalTilingFeatures;
            this.bufferFeatures = bufferFeatures;
        }
    }
    public unsafe struct VkImageFormatProperties
    {
        public VkExtent3D maxExtent;
        public uint maxMipLevels;
        public uint maxArrayLayers;
        public VkSampleCountFlagBits sampleCounts;
        public ulong maxResourceSize;
        public VkImageFormatProperties(VkExtent3D maxExtent, uint maxMipLevels, uint maxArrayLayers, VkSampleCountFlagBits sampleCounts, ulong maxResourceSize)
        {
            this.maxExtent = maxExtent;
            this.maxMipLevels = maxMipLevels;
            this.maxArrayLayers = maxArrayLayers;
            this.sampleCounts = sampleCounts;
            this.maxResourceSize = maxResourceSize;
        }
    }
    public unsafe struct VkDescriptorBufferInfo
    {
        public VkBuffer buffer;
        public ulong offset;
        public ulong range;
        public VkDescriptorBufferInfo(VkBuffer buffer, ulong offset, ulong range)
        {
            this.buffer = buffer;
            this.offset = offset;
            this.range = range;
        }
    }
    public unsafe struct VkDescriptorImageInfo
    {
        public VkSampler sampler;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public VkDescriptorImageInfo(VkSampler sampler, VkImageView imageView, VkImageLayout imageLayout)
        {
            this.sampler = sampler;
            this.imageView = imageView;
            this.imageLayout = imageLayout;
        }
    }
    public unsafe struct VkWriteDescriptorSet
    {
        public VkStructureType sType = VkStructureType.StructureTypeWriteDescriptorSet;
        public void* pNext;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkDescriptorType descriptorType;
        public VkDescriptorImageInfo* pImageInfo;
        public VkDescriptorBufferInfo* pBufferInfo;
        public VkBufferView* pTexelBufferView;
        public VkWriteDescriptorSet(VkStructureType sType, void* pNext, VkDescriptorSet dstSet, uint dstBinding, uint dstArrayElement, uint descriptorCount, VkDescriptorType descriptorType, VkDescriptorImageInfo* pImageInfo, VkDescriptorBufferInfo* pBufferInfo, VkBufferView* pTexelBufferView)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dstSet = dstSet;
            this.dstBinding = dstBinding;
            this.dstArrayElement = dstArrayElement;
            this.descriptorCount = descriptorCount;
            this.descriptorType = descriptorType;
            this.pImageInfo = pImageInfo;
            this.pBufferInfo = pBufferInfo;
            this.pTexelBufferView = pTexelBufferView;
        }
    }
    public unsafe struct VkCopyDescriptorSet
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyDescriptorSet;
        public void* pNext;
        public VkDescriptorSet srcSet;
        public uint srcBinding;
        public uint srcArrayElement;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkCopyDescriptorSet(VkStructureType sType, void* pNext, VkDescriptorSet srcSet, uint srcBinding, uint srcArrayElement, VkDescriptorSet dstSet, uint dstBinding, uint dstArrayElement, uint descriptorCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcSet = srcSet;
            this.srcBinding = srcBinding;
            this.srcArrayElement = srcArrayElement;
            this.dstSet = dstSet;
            this.dstBinding = dstBinding;
            this.dstArrayElement = dstArrayElement;
            this.descriptorCount = descriptorCount;
        }
    }
    public unsafe struct VkBufferUsageFlags2CreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferUsageFlags2CreateInfoKhr;
        public void* pNext;
        public VkBufferUsageFlagBits2KHR usage;
        public VkBufferUsageFlags2CreateInfoKHR(VkStructureType sType, void* pNext, VkBufferUsageFlagBits2KHR usage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.usage = usage;
        }
    }
    public unsafe struct VkBufferCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferCreateInfo;
        public void* pNext;
        public VkBufferCreateFlagBits flags;
        public ulong size;
        public VkBufferUsageFlagBits usage;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkBufferCreateInfo(VkStructureType sType, void* pNext, VkBufferCreateFlagBits flags, ulong size, VkBufferUsageFlagBits usage, VkSharingMode sharingMode, uint queueFamilyIndexCount, uint* pQueueFamilyIndices)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.size = size;
            this.usage = usage;
            this.sharingMode = sharingMode;
            this.queueFamilyIndexCount = queueFamilyIndexCount;
            this.pQueueFamilyIndices = pQueueFamilyIndices;
        }
    }
    public unsafe struct VkBufferViewCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferViewCreateInfo;
        public void* pNext;
        public VkBufferViewCreateFlags flags;
        public VkBuffer buffer;
        public VkFormat format;
        public ulong offset;
        public ulong range;
        public VkBufferViewCreateInfo(VkStructureType sType, void* pNext, VkBufferViewCreateFlags flags, VkBuffer buffer, VkFormat format, ulong offset, ulong range)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.buffer = buffer;
            this.format = format;
            this.offset = offset;
            this.range = range;
        }
    }
    public unsafe struct VkImageSubresource
    {
        public VkImageAspectFlagBits aspectMask;
        public uint mipLevel;
        public uint arrayLayer;
        public VkImageSubresource(VkImageAspectFlagBits aspectMask, uint mipLevel, uint arrayLayer)
        {
            this.aspectMask = aspectMask;
            this.mipLevel = mipLevel;
            this.arrayLayer = arrayLayer;
        }
    }
    public unsafe struct VkImageSubresourceLayers
    {
        public VkImageAspectFlagBits aspectMask;
        public uint mipLevel;
        public uint baseArrayLayer;
        public uint layerCount;
        public VkImageSubresourceLayers(VkImageAspectFlagBits aspectMask, uint mipLevel, uint baseArrayLayer, uint layerCount)
        {
            this.aspectMask = aspectMask;
            this.mipLevel = mipLevel;
            this.baseArrayLayer = baseArrayLayer;
            this.layerCount = layerCount;
        }
    }
    public unsafe struct VkImageSubresourceRange
    {
        public VkImageAspectFlagBits aspectMask;
        public uint baseMipLevel;
        public uint levelCount;
        public uint baseArrayLayer;
        public uint layerCount;
        public VkImageSubresourceRange(VkImageAspectFlagBits aspectMask, uint baseMipLevel, uint levelCount, uint baseArrayLayer, uint layerCount)
        {
            this.aspectMask = aspectMask;
            this.baseMipLevel = baseMipLevel;
            this.levelCount = levelCount;
            this.baseArrayLayer = baseArrayLayer;
            this.layerCount = layerCount;
        }
    }
    public unsafe struct VkMemoryBarrier
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryBarrier;
        public void* pNext;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
        public VkMemoryBarrier(VkStructureType sType, void* pNext, VkAccessFlagBits srcAccessMask, VkAccessFlagBits dstAccessMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcAccessMask = srcAccessMask;
            this.dstAccessMask = dstAccessMask;
        }
    }
    public unsafe struct VkBufferMemoryBarrier
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferMemoryBarrier;
        public void* pNext;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public VkBufferMemoryBarrier(VkStructureType sType, void* pNext, VkAccessFlagBits srcAccessMask, VkAccessFlagBits dstAccessMask, uint srcQueueFamilyIndex, uint dstQueueFamilyIndex, VkBuffer buffer, ulong offset, ulong size)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcAccessMask = srcAccessMask;
            this.dstAccessMask = dstAccessMask;
            this.srcQueueFamilyIndex = srcQueueFamilyIndex;
            this.dstQueueFamilyIndex = dstQueueFamilyIndex;
            this.buffer = buffer;
            this.offset = offset;
            this.size = size;
        }
    }
    public unsafe struct VkImageMemoryBarrier
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageMemoryBarrier;
        public void* pNext;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkImage image;
        public VkImageSubresourceRange subresourceRange;
        public VkImageMemoryBarrier(VkStructureType sType, void* pNext, VkAccessFlagBits srcAccessMask, VkAccessFlagBits dstAccessMask, VkImageLayout oldLayout, VkImageLayout newLayout, uint srcQueueFamilyIndex, uint dstQueueFamilyIndex, VkImage image, VkImageSubresourceRange subresourceRange)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcAccessMask = srcAccessMask;
            this.dstAccessMask = dstAccessMask;
            this.oldLayout = oldLayout;
            this.newLayout = newLayout;
            this.srcQueueFamilyIndex = srcQueueFamilyIndex;
            this.dstQueueFamilyIndex = dstQueueFamilyIndex;
            this.image = image;
            this.subresourceRange = subresourceRange;
        }
    }
    public unsafe struct VkImageCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageCreateInfo;
        public void* pNext;
        public VkImageCreateFlagBits flags;
        public VkImageType imageType;
        public VkFormat format;
        public VkExtent3D extent;
        public uint mipLevels;
        public uint arrayLayers;
        public VkSampleCountFlagBits samples;
        public VkImageTiling tiling;
        public VkImageUsageFlagBits usage;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkImageLayout initialLayout;
        public VkImageCreateInfo(VkStructureType sType, void* pNext, VkImageCreateFlagBits flags, VkImageType imageType, VkFormat format, VkExtent3D extent, uint mipLevels, uint arrayLayers, VkSampleCountFlagBits samples, VkImageTiling tiling, VkImageUsageFlagBits usage, VkSharingMode sharingMode, uint queueFamilyIndexCount, uint* pQueueFamilyIndices, VkImageLayout initialLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.imageType = imageType;
            this.format = format;
            this.extent = extent;
            this.mipLevels = mipLevels;
            this.arrayLayers = arrayLayers;
            this.samples = samples;
            this.tiling = tiling;
            this.usage = usage;
            this.sharingMode = sharingMode;
            this.queueFamilyIndexCount = queueFamilyIndexCount;
            this.pQueueFamilyIndices = pQueueFamilyIndices;
            this.initialLayout = initialLayout;
        }
    }
    public unsafe struct VkSubresourceLayout
    {
        public ulong offset;
        public ulong size;
        public ulong rowPitch;
        public ulong arrayPitch;
        public ulong depthPitch;
        public VkSubresourceLayout(ulong offset, ulong size, ulong rowPitch, ulong arrayPitch, ulong depthPitch)
        {
            this.offset = offset;
            this.size = size;
            this.rowPitch = rowPitch;
            this.arrayPitch = arrayPitch;
            this.depthPitch = depthPitch;
        }
    }
    public unsafe struct VkImageViewCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageViewCreateInfo;
        public void* pNext;
        public VkImageViewCreateFlagBits flags;
        public VkImage image;
        public VkImageViewType viewType;
        public VkFormat format;
        public VkComponentMapping components;
        public VkImageSubresourceRange subresourceRange;
        public VkImageViewCreateInfo(VkStructureType sType, void* pNext, VkImageViewCreateFlagBits flags, VkImage image, VkImageViewType viewType, VkFormat format, VkComponentMapping components, VkImageSubresourceRange subresourceRange)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.image = image;
            this.viewType = viewType;
            this.format = format;
            this.components = components;
            this.subresourceRange = subresourceRange;
        }
    }
    public unsafe struct VkBufferCopy
    {
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
        public VkBufferCopy(ulong srcOffset, ulong dstOffset, ulong size)
        {
            this.srcOffset = srcOffset;
            this.dstOffset = dstOffset;
            this.size = size;
        }
    }
    public unsafe struct VkSparseMemoryBind
    {
        public ulong resourceOffset;
        public ulong size;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkSparseMemoryBindFlagBits flags;
        public VkSparseMemoryBind(ulong resourceOffset, ulong size, VkDeviceMemory memory, ulong memoryOffset, VkSparseMemoryBindFlagBits flags)
        {
            this.resourceOffset = resourceOffset;
            this.size = size;
            this.memory = memory;
            this.memoryOffset = memoryOffset;
            this.flags = flags;
        }
    }
    public unsafe struct VkSparseImageMemoryBind
    {
        public VkImageSubresource subresource;
        public VkOffset3D offset;
        public VkExtent3D extent;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkSparseMemoryBindFlagBits flags;
        public VkSparseImageMemoryBind(VkImageSubresource subresource, VkOffset3D offset, VkExtent3D extent, VkDeviceMemory memory, ulong memoryOffset, VkSparseMemoryBindFlagBits flags)
        {
            this.subresource = subresource;
            this.offset = offset;
            this.extent = extent;
            this.memory = memory;
            this.memoryOffset = memoryOffset;
            this.flags = flags;
        }
    }
    public unsafe struct VkSparseBufferMemoryBindInfo
    {
        public VkBuffer buffer;
        public uint bindCount;
        public VkSparseMemoryBind* pBinds;
        public VkSparseBufferMemoryBindInfo(VkBuffer buffer, uint bindCount, VkSparseMemoryBind* pBinds)
        {
            this.buffer = buffer;
            this.bindCount = bindCount;
            this.pBinds = pBinds;
        }
    }
    public unsafe struct VkSparseImageOpaqueMemoryBindInfo
    {
        public VkImage image;
        public uint bindCount;
        public VkSparseMemoryBind* pBinds;
        public VkSparseImageOpaqueMemoryBindInfo(VkImage image, uint bindCount, VkSparseMemoryBind* pBinds)
        {
            this.image = image;
            this.bindCount = bindCount;
            this.pBinds = pBinds;
        }
    }
    public unsafe struct VkSparseImageMemoryBindInfo
    {
        public VkImage image;
        public uint bindCount;
        public VkSparseImageMemoryBind* pBinds;
        public VkSparseImageMemoryBindInfo(VkImage image, uint bindCount, VkSparseImageMemoryBind* pBinds)
        {
            this.image = image;
            this.bindCount = bindCount;
            this.pBinds = pBinds;
        }
    }
    public unsafe struct VkBindSparseInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindSparseInfo;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public uint bufferBindCount;
        public VkSparseBufferMemoryBindInfo* pBufferBinds;
        public uint imageOpaqueBindCount;
        public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
        public uint imageBindCount;
        public VkSparseImageMemoryBindInfo* pImageBinds;
        public uint signalSemaphoreCount;
        public VkSemaphore* pSignalSemaphores;
        public VkBindSparseInfo(VkStructureType sType, void* pNext, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, uint bufferBindCount, VkSparseBufferMemoryBindInfo* pBufferBinds, uint imageOpaqueBindCount, VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds, uint imageBindCount, VkSparseImageMemoryBindInfo* pImageBinds, uint signalSemaphoreCount, VkSemaphore* pSignalSemaphores)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.waitSemaphoreCount = waitSemaphoreCount;
            this.pWaitSemaphores = pWaitSemaphores;
            this.bufferBindCount = bufferBindCount;
            this.pBufferBinds = pBufferBinds;
            this.imageOpaqueBindCount = imageOpaqueBindCount;
            this.pImageOpaqueBinds = pImageOpaqueBinds;
            this.imageBindCount = imageBindCount;
            this.pImageBinds = pImageBinds;
            this.signalSemaphoreCount = signalSemaphoreCount;
            this.pSignalSemaphores = pSignalSemaphores;
        }
    }
    public unsafe struct VkImageCopy
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
        public VkImageCopy(VkImageSubresourceLayers srcSubresource, VkOffset3D srcOffset, VkImageSubresourceLayers dstSubresource, VkOffset3D dstOffset, VkExtent3D extent)
        {
            this.srcSubresource = srcSubresource;
            this.srcOffset = srcOffset;
            this.dstSubresource = dstSubresource;
            this.dstOffset = dstOffset;
            this.extent = extent;
        }
    }
    public unsafe struct VkImageBlit
    {
        public VkImageSubresourceLayers srcSubresource;
        [InlineArray(2)]
        public struct srcOffsetsInlineArray1
        {
            public VkOffset3D element;
        }
        public srcOffsetsInlineArray1 srcOffsets;
        public VkImageSubresourceLayers dstSubresource;
        [InlineArray(2)]
        public struct dstOffsetsInlineArray1
        {
            public VkOffset3D element;
        }
        public dstOffsetsInlineArray1 dstOffsets;
    }
    public unsafe struct VkBufferImageCopy
    {
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        public VkBufferImageCopy(ulong bufferOffset, uint bufferRowLength, uint bufferImageHeight, VkImageSubresourceLayers imageSubresource, VkOffset3D imageOffset, VkExtent3D imageExtent)
        {
            this.bufferOffset = bufferOffset;
            this.bufferRowLength = bufferRowLength;
            this.bufferImageHeight = bufferImageHeight;
            this.imageSubresource = imageSubresource;
            this.imageOffset = imageOffset;
            this.imageExtent = imageExtent;
        }
    }
    public unsafe struct VkCopyMemoryIndirectCommandNV
    {
        public ulong srcAddress;
        public ulong dstAddress;
        public ulong size;
        public VkCopyMemoryIndirectCommandNV(ulong srcAddress, ulong dstAddress, ulong size)
        {
            this.srcAddress = srcAddress;
            this.dstAddress = dstAddress;
            this.size = size;
        }
    }
    public unsafe struct VkCopyMemoryToImageIndirectCommandNV
    {
        public ulong srcAddress;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        public VkCopyMemoryToImageIndirectCommandNV(ulong srcAddress, uint bufferRowLength, uint bufferImageHeight, VkImageSubresourceLayers imageSubresource, VkOffset3D imageOffset, VkExtent3D imageExtent)
        {
            this.srcAddress = srcAddress;
            this.bufferRowLength = bufferRowLength;
            this.bufferImageHeight = bufferImageHeight;
            this.imageSubresource = imageSubresource;
            this.imageOffset = imageOffset;
            this.imageExtent = imageExtent;
        }
    }
    public unsafe struct VkImageResolve
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
        public VkImageResolve(VkImageSubresourceLayers srcSubresource, VkOffset3D srcOffset, VkImageSubresourceLayers dstSubresource, VkOffset3D dstOffset, VkExtent3D extent)
        {
            this.srcSubresource = srcSubresource;
            this.srcOffset = srcOffset;
            this.dstSubresource = dstSubresource;
            this.dstOffset = dstOffset;
            this.extent = extent;
        }
    }
    public unsafe struct VkShaderModuleCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeShaderModuleCreateInfo;
        public void* pNext;
        public VkShaderModuleCreateFlags flags;
        public nuint codeSize;
        public uint* pCode;
        public VkShaderModuleCreateInfo(VkStructureType sType, void* pNext, VkShaderModuleCreateFlags flags, nuint codeSize, uint* pCode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.codeSize = codeSize;
            this.pCode = pCode;
        }
    }
    public unsafe struct VkDescriptorSetLayoutBinding
    {
        public uint binding;
        public VkDescriptorType descriptorType;
        public uint descriptorCount;
        public VkShaderStageFlagBits stageFlags;
        public VkSampler* pImmutableSamplers;
        public VkDescriptorSetLayoutBinding(uint binding, VkDescriptorType descriptorType, uint descriptorCount, VkShaderStageFlagBits stageFlags, VkSampler* pImmutableSamplers)
        {
            this.binding = binding;
            this.descriptorType = descriptorType;
            this.descriptorCount = descriptorCount;
            this.stageFlags = stageFlags;
            this.pImmutableSamplers = pImmutableSamplers;
        }
    }
    public unsafe struct VkDescriptorSetLayoutCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorSetLayoutCreateInfo;
        public void* pNext;
        public VkDescriptorSetLayoutCreateFlagBits flags;
        public uint bindingCount;
        public VkDescriptorSetLayoutBinding* pBindings;
        public VkDescriptorSetLayoutCreateInfo(VkStructureType sType, void* pNext, VkDescriptorSetLayoutCreateFlagBits flags, uint bindingCount, VkDescriptorSetLayoutBinding* pBindings)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.bindingCount = bindingCount;
            this.pBindings = pBindings;
        }
    }
    public unsafe struct VkDescriptorPoolSize
    {
        public VkDescriptorType type;
        public uint descriptorCount;
        public VkDescriptorPoolSize(VkDescriptorType type, uint descriptorCount)
        {
            this.type = type;
            this.descriptorCount = descriptorCount;
        }
    }
    public unsafe struct VkDescriptorPoolCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorPoolCreateInfo;
        public void* pNext;
        public VkDescriptorPoolCreateFlagBits flags;
        public uint maxSets;
        public uint poolSizeCount;
        public VkDescriptorPoolSize* pPoolSizes;
        public VkDescriptorPoolCreateInfo(VkStructureType sType, void* pNext, VkDescriptorPoolCreateFlagBits flags, uint maxSets, uint poolSizeCount, VkDescriptorPoolSize* pPoolSizes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.maxSets = maxSets;
            this.poolSizeCount = poolSizeCount;
            this.pPoolSizes = pPoolSizes;
        }
    }
    public unsafe struct VkDescriptorSetAllocateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorSetAllocateInfo;
        public void* pNext;
        public VkDescriptorPool descriptorPool;
        public uint descriptorSetCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public VkDescriptorSetAllocateInfo(VkStructureType sType, void* pNext, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSetLayout* pSetLayouts)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.descriptorPool = descriptorPool;
            this.descriptorSetCount = descriptorSetCount;
            this.pSetLayouts = pSetLayouts;
        }
    }
    public unsafe struct VkSpecializationMapEntry
    {
        public uint constantID;
        public uint offset;
        public nuint size;
        public VkSpecializationMapEntry(uint constantID, uint offset, nuint size)
        {
            this.constantID = constantID;
            this.offset = offset;
            this.size = size;
        }
    }
    public unsafe struct VkSpecializationInfo
    {
        public uint mapEntryCount;
        public VkSpecializationMapEntry* pMapEntries;
        public nuint dataSize;
        public void* pData;
        public VkSpecializationInfo(uint mapEntryCount, VkSpecializationMapEntry* pMapEntries, nuint dataSize, void* pData)
        {
            this.mapEntryCount = mapEntryCount;
            this.pMapEntries = pMapEntries;
            this.dataSize = dataSize;
            this.pData = pData;
        }
    }
    public unsafe struct VkPipelineShaderStageCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineShaderStageCreateInfo;
        public void* pNext;
        public VkPipelineShaderStageCreateFlagBits flags;
        public VkShaderStageFlagBits stage;
        public VkShaderModule module;
        public byte* pName;
        public VkSpecializationInfo* pSpecializationInfo;
        public VkPipelineShaderStageCreateInfo(VkStructureType sType, void* pNext, VkPipelineShaderStageCreateFlagBits flags, VkShaderStageFlagBits stage, VkShaderModule module, byte* pName, VkSpecializationInfo* pSpecializationInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.stage = stage;
            this.module = module;
            this.pName = pName;
            this.pSpecializationInfo = pSpecializationInfo;
        }
    }
    public unsafe struct VkComputePipelineCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeComputePipelineCreateInfo;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public VkPipelineShaderStageCreateInfo stage;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public VkComputePipelineCreateInfo(VkStructureType sType, void* pNext, VkPipelineCreateFlagBits flags, VkPipelineShaderStageCreateInfo stage, VkPipelineLayout layout, VkPipeline basePipelineHandle, int basePipelineIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.stage = stage;
            this.layout = layout;
            this.basePipelineHandle = basePipelineHandle;
            this.basePipelineIndex = basePipelineIndex;
        }
    }
    public unsafe struct VkComputePipelineIndirectBufferInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeComputePipelineIndirectBufferInfoNv;
        public void* pNext;
        public ulong deviceAddress;
        public ulong size;
        public ulong pipelineDeviceAddressCaptureReplay;
        public VkComputePipelineIndirectBufferInfoNV(VkStructureType sType, void* pNext, ulong deviceAddress, ulong size, ulong pipelineDeviceAddressCaptureReplay)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceAddress = deviceAddress;
            this.size = size;
            this.pipelineDeviceAddressCaptureReplay = pipelineDeviceAddressCaptureReplay;
        }
    }
    public unsafe struct VkPipelineCreateFlags2CreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineCreateFlags2CreateInfoKhr;
        public void* pNext;
        public VkPipelineCreateFlagBits2KHR flags;
        public VkPipelineCreateFlags2CreateInfoKHR(VkStructureType sType, void* pNext, VkPipelineCreateFlagBits2KHR flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkVertexInputBindingDescription
    {
        public uint binding;
        public uint stride;
        public VkVertexInputRate inputRate;
        public VkVertexInputBindingDescription(uint binding, uint stride, VkVertexInputRate inputRate)
        {
            this.binding = binding;
            this.stride = stride;
            this.inputRate = inputRate;
        }
    }
    public unsafe struct VkVertexInputAttributeDescription
    {
        public uint location;
        public uint binding;
        public VkFormat format;
        public uint offset;
        public VkVertexInputAttributeDescription(uint location, uint binding, VkFormat format, uint offset)
        {
            this.location = location;
            this.binding = binding;
            this.format = format;
            this.offset = offset;
        }
    }
    public unsafe struct VkPipelineVertexInputStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineVertexInputStateCreateInfo;
        public void* pNext;
        public VkPipelineVertexInputStateCreateFlags flags;
        public uint vertexBindingDescriptionCount;
        public VkVertexInputBindingDescription* pVertexBindingDescriptions;
        public uint vertexAttributeDescriptionCount;
        public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
        public VkPipelineVertexInputStateCreateInfo(VkStructureType sType, void* pNext, VkPipelineVertexInputStateCreateFlags flags, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription* pVertexAttributeDescriptions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.vertexBindingDescriptionCount = vertexBindingDescriptionCount;
            this.pVertexBindingDescriptions = pVertexBindingDescriptions;
            this.vertexAttributeDescriptionCount = vertexAttributeDescriptionCount;
            this.pVertexAttributeDescriptions = pVertexAttributeDescriptions;
        }
    }
    public unsafe struct VkPipelineInputAssemblyStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineInputAssemblyStateCreateInfo;
        public void* pNext;
        public VkPipelineInputAssemblyStateCreateFlags flags;
        public VkPrimitiveTopology topology;
        public int primitiveRestartEnable;
        public VkPipelineInputAssemblyStateCreateInfo(VkStructureType sType, void* pNext, VkPipelineInputAssemblyStateCreateFlags flags, VkPrimitiveTopology topology, int primitiveRestartEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.topology = topology;
            this.primitiveRestartEnable = primitiveRestartEnable;
        }
    }
    public unsafe struct VkPipelineTessellationStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineTessellationStateCreateInfo;
        public void* pNext;
        public VkPipelineTessellationStateCreateFlags flags;
        public uint patchControlPoints;
        public VkPipelineTessellationStateCreateInfo(VkStructureType sType, void* pNext, VkPipelineTessellationStateCreateFlags flags, uint patchControlPoints)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.patchControlPoints = patchControlPoints;
        }
    }
    public unsafe struct VkPipelineViewportStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineViewportStateCreateInfo;
        public void* pNext;
        public VkPipelineViewportStateCreateFlags flags;
        public uint viewportCount;
        public VkViewport* pViewports;
        public uint scissorCount;
        public VkRect2D* pScissors;
        public VkPipelineViewportStateCreateInfo(VkStructureType sType, void* pNext, VkPipelineViewportStateCreateFlags flags, uint viewportCount, VkViewport* pViewports, uint scissorCount, VkRect2D* pScissors)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.viewportCount = viewportCount;
            this.pViewports = pViewports;
            this.scissorCount = scissorCount;
            this.pScissors = pScissors;
        }
    }
    public unsafe struct VkPipelineRasterizationStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRasterizationStateCreateInfo;
        public void* pNext;
        public VkPipelineRasterizationStateCreateFlags flags;
        public int depthClampEnable;
        public int rasterizerDiscardEnable;
        public VkPolygonMode polygonMode;
        public VkCullModeFlagBits cullMode;
        public VkFrontFace frontFace;
        public int depthBiasEnable;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        public float lineWidth;
        public VkPipelineRasterizationStateCreateInfo(VkStructureType sType, void* pNext, VkPipelineRasterizationStateCreateFlags flags, int depthClampEnable, int rasterizerDiscardEnable, VkPolygonMode polygonMode, VkCullModeFlagBits cullMode, VkFrontFace frontFace, int depthBiasEnable, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor, float lineWidth)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.depthClampEnable = depthClampEnable;
            this.rasterizerDiscardEnable = rasterizerDiscardEnable;
            this.polygonMode = polygonMode;
            this.cullMode = cullMode;
            this.frontFace = frontFace;
            this.depthBiasEnable = depthBiasEnable;
            this.depthBiasConstantFactor = depthBiasConstantFactor;
            this.depthBiasClamp = depthBiasClamp;
            this.depthBiasSlopeFactor = depthBiasSlopeFactor;
            this.lineWidth = lineWidth;
        }
    }
    public unsafe struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineMultisampleStateCreateInfo;
        public void* pNext;
        public VkPipelineMultisampleStateCreateFlags flags;
        public VkSampleCountFlagBits rasterizationSamples;
        public int sampleShadingEnable;
        public float minSampleShading;
        public uint* pSampleMask;
        public int alphaToCoverageEnable;
        public int alphaToOneEnable;
        public VkPipelineMultisampleStateCreateInfo(VkStructureType sType, void* pNext, VkPipelineMultisampleStateCreateFlags flags, VkSampleCountFlagBits rasterizationSamples, int sampleShadingEnable, float minSampleShading, uint* pSampleMask, int alphaToCoverageEnable, int alphaToOneEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.rasterizationSamples = rasterizationSamples;
            this.sampleShadingEnable = sampleShadingEnable;
            this.minSampleShading = minSampleShading;
            this.pSampleMask = pSampleMask;
            this.alphaToCoverageEnable = alphaToCoverageEnable;
            this.alphaToOneEnable = alphaToOneEnable;
        }
    }
    public unsafe struct VkPipelineColorBlendAttachmentState
    {
        public int blendEnable;
        public VkBlendFactor srcColorBlendFactor;
        public VkBlendFactor dstColorBlendFactor;
        public VkBlendOp colorBlendOp;
        public VkBlendFactor srcAlphaBlendFactor;
        public VkBlendFactor dstAlphaBlendFactor;
        public VkBlendOp alphaBlendOp;
        public VkColorComponentFlagBits colorWriteMask;
        public VkPipelineColorBlendAttachmentState(int blendEnable, VkBlendFactor srcColorBlendFactor, VkBlendFactor dstColorBlendFactor, VkBlendOp colorBlendOp, VkBlendFactor srcAlphaBlendFactor, VkBlendFactor dstAlphaBlendFactor, VkBlendOp alphaBlendOp, VkColorComponentFlagBits colorWriteMask)
        {
            this.blendEnable = blendEnable;
            this.srcColorBlendFactor = srcColorBlendFactor;
            this.dstColorBlendFactor = dstColorBlendFactor;
            this.colorBlendOp = colorBlendOp;
            this.srcAlphaBlendFactor = srcAlphaBlendFactor;
            this.dstAlphaBlendFactor = dstAlphaBlendFactor;
            this.alphaBlendOp = alphaBlendOp;
            this.colorWriteMask = colorWriteMask;
        }
    }
    public unsafe struct VkPipelineColorBlendStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineColorBlendStateCreateInfo;
        public void* pNext;
        public VkPipelineColorBlendStateCreateFlagBits flags;
        public int logicOpEnable;
        public VkLogicOp logicOp;
        public uint attachmentCount;
        public VkPipelineColorBlendAttachmentState* pAttachments;
        public fixed float blendConstants[4];
        public VkPipelineColorBlendStateCreateInfo(){ }
    }
    public unsafe struct VkPipelineDynamicStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineDynamicStateCreateInfo;
        public void* pNext;
        public VkPipelineDynamicStateCreateFlags flags;
        public uint dynamicStateCount;
        public VkDynamicState* pDynamicStates;
        public VkPipelineDynamicStateCreateInfo(VkStructureType sType, void* pNext, VkPipelineDynamicStateCreateFlags flags, uint dynamicStateCount, VkDynamicState* pDynamicStates)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.dynamicStateCount = dynamicStateCount;
            this.pDynamicStates = pDynamicStates;
        }
    }
    public unsafe struct VkStencilOpState
    {
        public VkStencilOp failOp;
        public VkStencilOp passOp;
        public VkStencilOp depthFailOp;
        public VkCompareOp compareOp;
        public uint compareMask;
        public uint writeMask;
        public uint reference;
        public VkStencilOpState(VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp, uint compareMask, uint writeMask, uint reference)
        {
            this.failOp = failOp;
            this.passOp = passOp;
            this.depthFailOp = depthFailOp;
            this.compareOp = compareOp;
            this.compareMask = compareMask;
            this.writeMask = writeMask;
            this.reference = reference;
        }
    }
    public unsafe struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineDepthStencilStateCreateInfo;
        public void* pNext;
        public VkPipelineDepthStencilStateCreateFlagBits flags;
        public int depthTestEnable;
        public int depthWriteEnable;
        public VkCompareOp depthCompareOp;
        public int depthBoundsTestEnable;
        public int stencilTestEnable;
        public VkStencilOpState front;
        public VkStencilOpState back;
        public float minDepthBounds;
        public float maxDepthBounds;
        public VkPipelineDepthStencilStateCreateInfo(VkStructureType sType, void* pNext, VkPipelineDepthStencilStateCreateFlagBits flags, int depthTestEnable, int depthWriteEnable, VkCompareOp depthCompareOp, int depthBoundsTestEnable, int stencilTestEnable, VkStencilOpState front, VkStencilOpState back, float minDepthBounds, float maxDepthBounds)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.depthTestEnable = depthTestEnable;
            this.depthWriteEnable = depthWriteEnable;
            this.depthCompareOp = depthCompareOp;
            this.depthBoundsTestEnable = depthBoundsTestEnable;
            this.stencilTestEnable = stencilTestEnable;
            this.front = front;
            this.back = back;
            this.minDepthBounds = minDepthBounds;
            this.maxDepthBounds = maxDepthBounds;
        }
    }
    public unsafe struct VkGraphicsPipelineCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeGraphicsPipelineCreateInfo;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
        public VkPipelineViewportStateCreateInfo* pViewportState;
        public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
        public VkPipelineMultisampleStateCreateInfo* pMultisampleState;
        public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
        public VkPipelineColorBlendStateCreateInfo* pColorBlendState;
        public VkPipelineDynamicStateCreateInfo* pDynamicState;
        public VkPipelineLayout layout;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public VkGraphicsPipelineCreateInfo(VkStructureType sType, void* pNext, VkPipelineCreateFlagBits flags, uint stageCount, VkPipelineShaderStageCreateInfo* pStages, VkPipelineVertexInputStateCreateInfo* pVertexInputState, VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState, VkPipelineTessellationStateCreateInfo* pTessellationState, VkPipelineViewportStateCreateInfo* pViewportState, VkPipelineRasterizationStateCreateInfo* pRasterizationState, VkPipelineMultisampleStateCreateInfo* pMultisampleState, VkPipelineDepthStencilStateCreateInfo* pDepthStencilState, VkPipelineColorBlendStateCreateInfo* pColorBlendState, VkPipelineDynamicStateCreateInfo* pDynamicState, VkPipelineLayout layout, VkRenderPass renderPass, uint subpass, VkPipeline basePipelineHandle, int basePipelineIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.stageCount = stageCount;
            this.pStages = pStages;
            this.pVertexInputState = pVertexInputState;
            this.pInputAssemblyState = pInputAssemblyState;
            this.pTessellationState = pTessellationState;
            this.pViewportState = pViewportState;
            this.pRasterizationState = pRasterizationState;
            this.pMultisampleState = pMultisampleState;
            this.pDepthStencilState = pDepthStencilState;
            this.pColorBlendState = pColorBlendState;
            this.pDynamicState = pDynamicState;
            this.layout = layout;
            this.renderPass = renderPass;
            this.subpass = subpass;
            this.basePipelineHandle = basePipelineHandle;
            this.basePipelineIndex = basePipelineIndex;
        }
    }
    public unsafe struct VkPipelineCacheCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineCacheCreateInfo;
        public void* pNext;
        public VkPipelineCacheCreateFlagBits flags;
        public nuint initialDataSize;
        public void* pInitialData;
        public VkPipelineCacheCreateInfo(VkStructureType sType, void* pNext, VkPipelineCacheCreateFlagBits flags, nuint initialDataSize, void* pInitialData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.initialDataSize = initialDataSize;
            this.pInitialData = pInitialData;
        }
    }
    public unsafe struct VkPipelineCacheHeaderVersionOne
    {
        public uint headerSize;
        public VkPipelineCacheHeaderVersion headerVersion;
        public uint vendorID;
        public uint deviceID;
        public fixed byte pipelineCacheUUID[16];
    }
    public unsafe struct VkPipelineCacheStageValidationIndexEntry
    {
        public ulong codeSize;
        public ulong codeOffset;
        public VkPipelineCacheStageValidationIndexEntry(ulong codeSize, ulong codeOffset)
        {
            this.codeSize = codeSize;
            this.codeOffset = codeOffset;
        }
    }
    public unsafe struct VkPipelineCacheSafetyCriticalIndexEntry
    {
        public fixed byte pipelineIdentifier[16];
        public ulong pipelineMemorySize;
        public ulong jsonSize;
        public ulong jsonOffset;
        public uint stageIndexCount;
        public uint stageIndexStride;
        public ulong stageIndexOffset;
    }
    public unsafe struct VkPipelineCacheHeaderVersionSafetyCriticalOne
    {
        public VkPipelineCacheHeaderVersionOne headerVersionOne;
        public VkPipelineCacheValidationVersion validationVersion;
        public uint implementationData;
        public uint pipelineIndexCount;
        public uint pipelineIndexStride;
        public ulong pipelineIndexOffset;
        public VkPipelineCacheHeaderVersionSafetyCriticalOne(VkPipelineCacheHeaderVersionOne headerVersionOne, VkPipelineCacheValidationVersion validationVersion, uint implementationData, uint pipelineIndexCount, uint pipelineIndexStride, ulong pipelineIndexOffset)
        {
            this.headerVersionOne = headerVersionOne;
            this.validationVersion = validationVersion;
            this.implementationData = implementationData;
            this.pipelineIndexCount = pipelineIndexCount;
            this.pipelineIndexStride = pipelineIndexStride;
            this.pipelineIndexOffset = pipelineIndexOffset;
        }
    }
    public unsafe struct VkPushConstantRange
    {
        public VkShaderStageFlagBits stageFlags;
        public uint offset;
        public uint size;
        public VkPushConstantRange(VkShaderStageFlagBits stageFlags, uint offset, uint size)
        {
            this.stageFlags = stageFlags;
            this.offset = offset;
            this.size = size;
        }
    }
    public unsafe struct VkPipelineLayoutCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineLayoutCreateInfo;
        public void* pNext;
        public VkPipelineLayoutCreateFlagBits flags;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
        public VkPipelineLayoutCreateInfo(VkStructureType sType, void* pNext, VkPipelineLayoutCreateFlagBits flags, uint setLayoutCount, VkDescriptorSetLayout* pSetLayouts, uint pushConstantRangeCount, VkPushConstantRange* pPushConstantRanges)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.setLayoutCount = setLayoutCount;
            this.pSetLayouts = pSetLayouts;
            this.pushConstantRangeCount = pushConstantRangeCount;
            this.pPushConstantRanges = pPushConstantRanges;
        }
    }
    public unsafe struct VkSamplerCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerCreateInfo;
        public void* pNext;
        public VkSamplerCreateFlagBits flags;
        public VkFilter magFilter;
        public VkFilter minFilter;
        public VkSamplerMipmapMode mipmapMode;
        public VkSamplerAddressMode addressModeU;
        public VkSamplerAddressMode addressModeV;
        public VkSamplerAddressMode addressModeW;
        public float mipLodBias;
        public int anisotropyEnable;
        public float maxAnisotropy;
        public int compareEnable;
        public VkCompareOp compareOp;
        public float minLod;
        public float maxLod;
        public VkBorderColor borderColor;
        public int unnormalizedCoordinates;
        public VkSamplerCreateInfo(VkStructureType sType, void* pNext, VkSamplerCreateFlagBits flags, VkFilter magFilter, VkFilter minFilter, VkSamplerMipmapMode mipmapMode, VkSamplerAddressMode addressModeU, VkSamplerAddressMode addressModeV, VkSamplerAddressMode addressModeW, float mipLodBias, int anisotropyEnable, float maxAnisotropy, int compareEnable, VkCompareOp compareOp, float minLod, float maxLod, VkBorderColor borderColor, int unnormalizedCoordinates)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.magFilter = magFilter;
            this.minFilter = minFilter;
            this.mipmapMode = mipmapMode;
            this.addressModeU = addressModeU;
            this.addressModeV = addressModeV;
            this.addressModeW = addressModeW;
            this.mipLodBias = mipLodBias;
            this.anisotropyEnable = anisotropyEnable;
            this.maxAnisotropy = maxAnisotropy;
            this.compareEnable = compareEnable;
            this.compareOp = compareOp;
            this.minLod = minLod;
            this.maxLod = maxLod;
            this.borderColor = borderColor;
            this.unnormalizedCoordinates = unnormalizedCoordinates;
        }
    }
    public unsafe struct VkCommandPoolCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeCommandPoolCreateInfo;
        public void* pNext;
        public VkCommandPoolCreateFlagBits flags;
        public uint queueFamilyIndex;
        public VkCommandPoolCreateInfo(VkStructureType sType, void* pNext, VkCommandPoolCreateFlagBits flags, uint queueFamilyIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.queueFamilyIndex = queueFamilyIndex;
        }
    }
    public unsafe struct VkCommandBufferAllocateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeCommandBufferAllocateInfo;
        public void* pNext;
        public VkCommandPool commandPool;
        public VkCommandBufferLevel level;
        public uint commandBufferCount;
        public VkCommandBufferAllocateInfo(VkStructureType sType, void* pNext, VkCommandPool commandPool, VkCommandBufferLevel level, uint commandBufferCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.commandPool = commandPool;
            this.level = level;
            this.commandBufferCount = commandBufferCount;
        }
    }
    public unsafe struct VkCommandBufferInheritanceInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeCommandBufferInheritanceInfo;
        public void* pNext;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkFramebuffer framebuffer;
        public int occlusionQueryEnable;
        public VkQueryControlFlagBits queryFlags;
        public VkQueryPipelineStatisticFlagBits pipelineStatistics;
        public VkCommandBufferInheritanceInfo(VkStructureType sType, void* pNext, VkRenderPass renderPass, uint subpass, VkFramebuffer framebuffer, int occlusionQueryEnable, VkQueryControlFlagBits queryFlags, VkQueryPipelineStatisticFlagBits pipelineStatistics)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.renderPass = renderPass;
            this.subpass = subpass;
            this.framebuffer = framebuffer;
            this.occlusionQueryEnable = occlusionQueryEnable;
            this.queryFlags = queryFlags;
            this.pipelineStatistics = pipelineStatistics;
        }
    }
    public unsafe struct VkCommandBufferBeginInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeCommandBufferBeginInfo;
        public void* pNext;
        public VkCommandBufferUsageFlagBits flags;
        public VkCommandBufferInheritanceInfo* pInheritanceInfo;
        public VkCommandBufferBeginInfo(VkStructureType sType, void* pNext, VkCommandBufferUsageFlagBits flags, VkCommandBufferInheritanceInfo* pInheritanceInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pInheritanceInfo = pInheritanceInfo;
        }
    }
    public unsafe struct VkRenderPassBeginInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassBeginInfo;
        public void* pNext;
        public VkRenderPass renderPass;
        public VkFramebuffer framebuffer;
        public VkRect2D renderArea;
        public uint clearValueCount;
        public VkClearValue* pClearValues;
        public VkRenderPassBeginInfo(VkStructureType sType, void* pNext, VkRenderPass renderPass, VkFramebuffer framebuffer, VkRect2D renderArea, uint clearValueCount, VkClearValue* pClearValues)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.renderPass = renderPass;
            this.framebuffer = framebuffer;
            this.renderArea = renderArea;
            this.clearValueCount = clearValueCount;
            this.pClearValues = pClearValues;
        }
    }
    /// <summary>Union allowing specification of floating-point, integer, or unsigned integer color data. Actual value selected is based on image/attachment being cleared.</summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkClearColorValue
    {
        [FieldOffset(0)]
        public fixed float float32[4];
        [FieldOffset(0)]
        public fixed int int32[4];
        [FieldOffset(0)]
        public fixed uint uint32[4];
    }
    public unsafe struct VkClearDepthStencilValue
    {
        public float depth;
        public uint stencil;
        public VkClearDepthStencilValue(float depth, uint stencil)
        {
            this.depth = depth;
            this.stencil = stencil;
        }
    }
    /// <summary>Union allowing specification of color or depth and stencil values. Actual value selected is based on attachment being cleared.</summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkClearValue
    {
        [FieldOffset(0)]
        public VkClearColorValue color;
        [FieldOffset(0)]
        public VkClearDepthStencilValue depthStencil;
    }
    public unsafe struct VkClearAttachment
    {
        public VkImageAspectFlagBits aspectMask;
        public uint colorAttachment;
        public VkClearValue clearValue;
        public VkClearAttachment(VkImageAspectFlagBits aspectMask, uint colorAttachment, VkClearValue clearValue)
        {
            this.aspectMask = aspectMask;
            this.colorAttachment = colorAttachment;
            this.clearValue = clearValue;
        }
    }
    public unsafe struct VkAttachmentDescription
    {
        public VkAttachmentDescriptionFlagBits flags;
        public VkFormat format;
        public VkSampleCountFlagBits samples;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkAttachmentLoadOp stencilLoadOp;
        public VkAttachmentStoreOp stencilStoreOp;
        public VkImageLayout initialLayout;
        public VkImageLayout finalLayout;
        public VkAttachmentDescription(VkAttachmentDescriptionFlagBits flags, VkFormat format, VkSampleCountFlagBits samples, VkAttachmentLoadOp loadOp, VkAttachmentStoreOp storeOp, VkAttachmentLoadOp stencilLoadOp, VkAttachmentStoreOp stencilStoreOp, VkImageLayout initialLayout, VkImageLayout finalLayout)
        {
            this.flags = flags;
            this.format = format;
            this.samples = samples;
            this.loadOp = loadOp;
            this.storeOp = storeOp;
            this.stencilLoadOp = stencilLoadOp;
            this.stencilStoreOp = stencilStoreOp;
            this.initialLayout = initialLayout;
            this.finalLayout = finalLayout;
        }
    }
    public unsafe struct VkAttachmentReference
    {
        public uint attachment;
        public VkImageLayout layout;
        public VkAttachmentReference(uint attachment, VkImageLayout layout)
        {
            this.attachment = attachment;
            this.layout = layout;
        }
    }
    public unsafe struct VkSubpassDescription
    {
        public VkSubpassDescriptionFlagBits flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint inputAttachmentCount;
        public VkAttachmentReference* pInputAttachments;
        public uint colorAttachmentCount;
        public VkAttachmentReference* pColorAttachments;
        public VkAttachmentReference* pResolveAttachments;
        public VkAttachmentReference* pDepthStencilAttachment;
        public uint preserveAttachmentCount;
        public uint* pPreserveAttachments;
        public VkSubpassDescription(VkSubpassDescriptionFlagBits flags, VkPipelineBindPoint pipelineBindPoint, uint inputAttachmentCount, VkAttachmentReference* pInputAttachments, uint colorAttachmentCount, VkAttachmentReference* pColorAttachments, VkAttachmentReference* pResolveAttachments, VkAttachmentReference* pDepthStencilAttachment, uint preserveAttachmentCount, uint* pPreserveAttachments)
        {
            this.flags = flags;
            this.pipelineBindPoint = pipelineBindPoint;
            this.inputAttachmentCount = inputAttachmentCount;
            this.pInputAttachments = pInputAttachments;
            this.colorAttachmentCount = colorAttachmentCount;
            this.pColorAttachments = pColorAttachments;
            this.pResolveAttachments = pResolveAttachments;
            this.pDepthStencilAttachment = pDepthStencilAttachment;
            this.preserveAttachmentCount = preserveAttachmentCount;
            this.pPreserveAttachments = pPreserveAttachments;
        }
    }
    public unsafe struct VkSubpassDependency
    {
        public uint srcSubpass;
        public uint dstSubpass;
        public VkPipelineStageFlagBits srcStageMask;
        public VkPipelineStageFlagBits dstStageMask;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
        public VkDependencyFlagBits dependencyFlags;
        public VkSubpassDependency(uint srcSubpass, uint dstSubpass, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, VkAccessFlagBits srcAccessMask, VkAccessFlagBits dstAccessMask, VkDependencyFlagBits dependencyFlags)
        {
            this.srcSubpass = srcSubpass;
            this.dstSubpass = dstSubpass;
            this.srcStageMask = srcStageMask;
            this.dstStageMask = dstStageMask;
            this.srcAccessMask = srcAccessMask;
            this.dstAccessMask = dstAccessMask;
            this.dependencyFlags = dependencyFlags;
        }
    }
    public unsafe struct VkRenderPassCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassCreateInfo;
        public void* pNext;
        public VkRenderPassCreateFlagBits flags;
        public uint attachmentCount;
        public VkAttachmentDescription* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency* pDependencies;
        public VkRenderPassCreateInfo(VkStructureType sType, void* pNext, VkRenderPassCreateFlagBits flags, uint attachmentCount, VkAttachmentDescription* pAttachments, uint subpassCount, VkSubpassDescription* pSubpasses, uint dependencyCount, VkSubpassDependency* pDependencies)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.attachmentCount = attachmentCount;
            this.pAttachments = pAttachments;
            this.subpassCount = subpassCount;
            this.pSubpasses = pSubpasses;
            this.dependencyCount = dependencyCount;
            this.pDependencies = pDependencies;
        }
    }
    public unsafe struct VkEventCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeEventCreateInfo;
        public void* pNext;
        public VkEventCreateFlagBits flags;
        public VkEventCreateInfo(VkStructureType sType, void* pNext, VkEventCreateFlagBits flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkFenceCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeFenceCreateInfo;
        public void* pNext;
        public VkFenceCreateFlagBits flags;
        public VkFenceCreateInfo(VkStructureType sType, void* pNext, VkFenceCreateFlagBits flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkPhysicalDeviceFeatures
    {
        public int robustBufferAccess;
        public int fullDrawIndexUint32;
        public int imageCubeArray;
        public int independentBlend;
        public int geometryShader;
        public int tessellationShader;
        public int sampleRateShading;
        public int dualSrcBlend;
        public int logicOp;
        public int multiDrawIndirect;
        public int drawIndirectFirstInstance;
        public int depthClamp;
        public int depthBiasClamp;
        public int fillModeNonSolid;
        public int depthBounds;
        public int wideLines;
        public int largePoints;
        public int alphaToOne;
        public int multiViewport;
        public int samplerAnisotropy;
        public int textureCompressionETC2;
        public int textureCompressionASTC_LDR;
        public int textureCompressionBC;
        public int occlusionQueryPrecise;
        public int pipelineStatisticsQuery;
        public int vertexPipelineStoresAndAtomics;
        public int fragmentStoresAndAtomics;
        public int shaderTessellationAndGeometryPointSize;
        public int shaderImageGatherExtended;
        public int shaderStorageImageExtendedFormats;
        public int shaderStorageImageMultisample;
        public int shaderStorageImageReadWithoutFormat;
        public int shaderStorageImageWriteWithoutFormat;
        public int shaderUniformBufferArrayDynamicIndexing;
        public int shaderSampledImageArrayDynamicIndexing;
        public int shaderStorageBufferArrayDynamicIndexing;
        public int shaderStorageImageArrayDynamicIndexing;
        public int shaderClipDistance;
        public int shaderCullDistance;
        public int shaderFloat64;
        public int shaderInt64;
        public int shaderInt16;
        public int shaderResourceResidency;
        public int shaderResourceMinLod;
        public int sparseBinding;
        public int sparseResidencyBuffer;
        public int sparseResidencyImage2D;
        public int sparseResidencyImage3D;
        public int sparseResidency2Samples;
        public int sparseResidency4Samples;
        public int sparseResidency8Samples;
        public int sparseResidency16Samples;
        public int sparseResidencyAliased;
        public int variableMultisampleRate;
        public int inheritedQueries;
        public VkPhysicalDeviceFeatures(int robustBufferAccess, int fullDrawIndexUint32, int imageCubeArray, int independentBlend, int geometryShader, int tessellationShader, int sampleRateShading, int dualSrcBlend, int logicOp, int multiDrawIndirect, int drawIndirectFirstInstance, int depthClamp, int depthBiasClamp, int fillModeNonSolid, int depthBounds, int wideLines, int largePoints, int alphaToOne, int multiViewport, int samplerAnisotropy, int textureCompressionETC2, int textureCompressionASTC_LDR, int textureCompressionBC, int occlusionQueryPrecise, int pipelineStatisticsQuery, int vertexPipelineStoresAndAtomics, int fragmentStoresAndAtomics, int shaderTessellationAndGeometryPointSize, int shaderImageGatherExtended, int shaderStorageImageExtendedFormats, int shaderStorageImageMultisample, int shaderStorageImageReadWithoutFormat, int shaderStorageImageWriteWithoutFormat, int shaderUniformBufferArrayDynamicIndexing, int shaderSampledImageArrayDynamicIndexing, int shaderStorageBufferArrayDynamicIndexing, int shaderStorageImageArrayDynamicIndexing, int shaderClipDistance, int shaderCullDistance, int shaderFloat64, int shaderInt64, int shaderInt16, int shaderResourceResidency, int shaderResourceMinLod, int sparseBinding, int sparseResidencyBuffer, int sparseResidencyImage2D, int sparseResidencyImage3D, int sparseResidency2Samples, int sparseResidency4Samples, int sparseResidency8Samples, int sparseResidency16Samples, int sparseResidencyAliased, int variableMultisampleRate, int inheritedQueries)
        {
            this.robustBufferAccess = robustBufferAccess;
            this.fullDrawIndexUint32 = fullDrawIndexUint32;
            this.imageCubeArray = imageCubeArray;
            this.independentBlend = independentBlend;
            this.geometryShader = geometryShader;
            this.tessellationShader = tessellationShader;
            this.sampleRateShading = sampleRateShading;
            this.dualSrcBlend = dualSrcBlend;
            this.logicOp = logicOp;
            this.multiDrawIndirect = multiDrawIndirect;
            this.drawIndirectFirstInstance = drawIndirectFirstInstance;
            this.depthClamp = depthClamp;
            this.depthBiasClamp = depthBiasClamp;
            this.fillModeNonSolid = fillModeNonSolid;
            this.depthBounds = depthBounds;
            this.wideLines = wideLines;
            this.largePoints = largePoints;
            this.alphaToOne = alphaToOne;
            this.multiViewport = multiViewport;
            this.samplerAnisotropy = samplerAnisotropy;
            this.textureCompressionETC2 = textureCompressionETC2;
            this.textureCompressionASTC_LDR = textureCompressionASTC_LDR;
            this.textureCompressionBC = textureCompressionBC;
            this.occlusionQueryPrecise = occlusionQueryPrecise;
            this.pipelineStatisticsQuery = pipelineStatisticsQuery;
            this.vertexPipelineStoresAndAtomics = vertexPipelineStoresAndAtomics;
            this.fragmentStoresAndAtomics = fragmentStoresAndAtomics;
            this.shaderTessellationAndGeometryPointSize = shaderTessellationAndGeometryPointSize;
            this.shaderImageGatherExtended = shaderImageGatherExtended;
            this.shaderStorageImageExtendedFormats = shaderStorageImageExtendedFormats;
            this.shaderStorageImageMultisample = shaderStorageImageMultisample;
            this.shaderStorageImageReadWithoutFormat = shaderStorageImageReadWithoutFormat;
            this.shaderStorageImageWriteWithoutFormat = shaderStorageImageWriteWithoutFormat;
            this.shaderUniformBufferArrayDynamicIndexing = shaderUniformBufferArrayDynamicIndexing;
            this.shaderSampledImageArrayDynamicIndexing = shaderSampledImageArrayDynamicIndexing;
            this.shaderStorageBufferArrayDynamicIndexing = shaderStorageBufferArrayDynamicIndexing;
            this.shaderStorageImageArrayDynamicIndexing = shaderStorageImageArrayDynamicIndexing;
            this.shaderClipDistance = shaderClipDistance;
            this.shaderCullDistance = shaderCullDistance;
            this.shaderFloat64 = shaderFloat64;
            this.shaderInt64 = shaderInt64;
            this.shaderInt16 = shaderInt16;
            this.shaderResourceResidency = shaderResourceResidency;
            this.shaderResourceMinLod = shaderResourceMinLod;
            this.sparseBinding = sparseBinding;
            this.sparseResidencyBuffer = sparseResidencyBuffer;
            this.sparseResidencyImage2D = sparseResidencyImage2D;
            this.sparseResidencyImage3D = sparseResidencyImage3D;
            this.sparseResidency2Samples = sparseResidency2Samples;
            this.sparseResidency4Samples = sparseResidency4Samples;
            this.sparseResidency8Samples = sparseResidency8Samples;
            this.sparseResidency16Samples = sparseResidency16Samples;
            this.sparseResidencyAliased = sparseResidencyAliased;
            this.variableMultisampleRate = variableMultisampleRate;
            this.inheritedQueries = inheritedQueries;
        }
    }
    public unsafe struct VkPhysicalDeviceSparseProperties
    {
        public int residencyStandard2DBlockShape;
        public int residencyStandard2DMultisampleBlockShape;
        public int residencyStandard3DBlockShape;
        public int residencyAlignedMipSize;
        public int residencyNonResidentStrict;
        public VkPhysicalDeviceSparseProperties(int residencyStandard2DBlockShape, int residencyStandard2DMultisampleBlockShape, int residencyStandard3DBlockShape, int residencyAlignedMipSize, int residencyNonResidentStrict)
        {
            this.residencyStandard2DBlockShape = residencyStandard2DBlockShape;
            this.residencyStandard2DMultisampleBlockShape = residencyStandard2DMultisampleBlockShape;
            this.residencyStandard3DBlockShape = residencyStandard3DBlockShape;
            this.residencyAlignedMipSize = residencyAlignedMipSize;
            this.residencyNonResidentStrict = residencyNonResidentStrict;
        }
    }
    public unsafe struct VkPhysicalDeviceLimits
    {
        public uint maxImageDimension1D;
        public uint maxImageDimension2D;
        public uint maxImageDimension3D;
        public uint maxImageDimensionCube;
        public uint maxImageArrayLayers;
        public uint maxTexelBufferElements;
        public uint maxUniformBufferRange;
        public uint maxStorageBufferRange;
        public uint maxPushConstantsSize;
        public uint maxMemoryAllocationCount;
        public uint maxSamplerAllocationCount;
        public ulong bufferImageGranularity;
        public ulong sparseAddressSpaceSize;
        public uint maxBoundDescriptorSets;
        public uint maxPerStageDescriptorSamplers;
        public uint maxPerStageDescriptorUniformBuffers;
        public uint maxPerStageDescriptorStorageBuffers;
        public uint maxPerStageDescriptorSampledImages;
        public uint maxPerStageDescriptorStorageImages;
        public uint maxPerStageDescriptorInputAttachments;
        public uint maxPerStageResources;
        public uint maxDescriptorSetSamplers;
        public uint maxDescriptorSetUniformBuffers;
        public uint maxDescriptorSetUniformBuffersDynamic;
        public uint maxDescriptorSetStorageBuffers;
        public uint maxDescriptorSetStorageBuffersDynamic;
        public uint maxDescriptorSetSampledImages;
        public uint maxDescriptorSetStorageImages;
        public uint maxDescriptorSetInputAttachments;
        public uint maxVertexInputAttributes;
        public uint maxVertexInputBindings;
        public uint maxVertexInputAttributeOffset;
        public uint maxVertexInputBindingStride;
        public uint maxVertexOutputComponents;
        public uint maxTessellationGenerationLevel;
        public uint maxTessellationPatchSize;
        public uint maxTessellationControlPerVertexInputComponents;
        public uint maxTessellationControlPerVertexOutputComponents;
        public uint maxTessellationControlPerPatchOutputComponents;
        public uint maxTessellationControlTotalOutputComponents;
        public uint maxTessellationEvaluationInputComponents;
        public uint maxTessellationEvaluationOutputComponents;
        public uint maxGeometryShaderInvocations;
        public uint maxGeometryInputComponents;
        public uint maxGeometryOutputComponents;
        public uint maxGeometryOutputVertices;
        public uint maxGeometryTotalOutputComponents;
        public uint maxFragmentInputComponents;
        public uint maxFragmentOutputAttachments;
        public uint maxFragmentDualSrcAttachments;
        public uint maxFragmentCombinedOutputResources;
        public uint maxComputeSharedMemorySize;
        public fixed uint maxComputeWorkGroupCount[3];
        public uint maxComputeWorkGroupInvocations;
        public fixed uint maxComputeWorkGroupSize[3];
        public uint subPixelPrecisionBits;
        public uint subTexelPrecisionBits;
        public uint mipmapPrecisionBits;
        public uint maxDrawIndexedIndexValue;
        public uint maxDrawIndirectCount;
        public float maxSamplerLodBias;
        public float maxSamplerAnisotropy;
        public uint maxViewports;
        public fixed uint maxViewportDimensions[2];
        public fixed float viewportBoundsRange[2];
        public uint viewportSubPixelBits;
        public nuint minMemoryMapAlignment;
        public ulong minTexelBufferOffsetAlignment;
        public ulong minUniformBufferOffsetAlignment;
        public ulong minStorageBufferOffsetAlignment;
        public int minTexelOffset;
        public uint maxTexelOffset;
        public int minTexelGatherOffset;
        public uint maxTexelGatherOffset;
        public float minInterpolationOffset;
        public float maxInterpolationOffset;
        public uint subPixelInterpolationOffsetBits;
        public uint maxFramebufferWidth;
        public uint maxFramebufferHeight;
        public uint maxFramebufferLayers;
        public VkSampleCountFlagBits framebufferColorSampleCounts;
        public VkSampleCountFlagBits framebufferDepthSampleCounts;
        public VkSampleCountFlagBits framebufferStencilSampleCounts;
        public VkSampleCountFlagBits framebufferNoAttachmentsSampleCounts;
        public uint maxColorAttachments;
        public VkSampleCountFlagBits sampledImageColorSampleCounts;
        public VkSampleCountFlagBits sampledImageIntegerSampleCounts;
        public VkSampleCountFlagBits sampledImageDepthSampleCounts;
        public VkSampleCountFlagBits sampledImageStencilSampleCounts;
        public VkSampleCountFlagBits storageImageSampleCounts;
        public uint maxSampleMaskWords;
        public int timestampComputeAndGraphics;
        public float timestampPeriod;
        public uint maxClipDistances;
        public uint maxCullDistances;
        public uint maxCombinedClipAndCullDistances;
        public uint discreteQueuePriorities;
        public fixed float pointSizeRange[2];
        public fixed float lineWidthRange[2];
        public float pointSizeGranularity;
        public float lineWidthGranularity;
        public int strictLines;
        public int standardSampleLocations;
        public ulong optimalBufferCopyOffsetAlignment;
        public ulong optimalBufferCopyRowPitchAlignment;
        public ulong nonCoherentAtomSize;
    }
    public unsafe struct VkSemaphoreCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreCreateInfo;
        public void* pNext;
        public VkSemaphoreCreateFlags flags;
        public VkSemaphoreCreateInfo(VkStructureType sType, void* pNext, VkSemaphoreCreateFlags flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkQueryPoolCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueryPoolCreateInfo;
        public void* pNext;
        public VkQueryPoolCreateFlags flags;
        public VkQueryType queryType;
        public uint queryCount;
        public VkQueryPipelineStatisticFlagBits pipelineStatistics;
        public VkQueryPoolCreateInfo(VkStructureType sType, void* pNext, VkQueryPoolCreateFlags flags, VkQueryType queryType, uint queryCount, VkQueryPipelineStatisticFlagBits pipelineStatistics)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.queryType = queryType;
            this.queryCount = queryCount;
            this.pipelineStatistics = pipelineStatistics;
        }
    }
    public unsafe struct VkFramebufferCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeFramebufferCreateInfo;
        public void* pNext;
        public VkFramebufferCreateFlagBits flags;
        public VkRenderPass renderPass;
        public uint attachmentCount;
        public VkImageView* pAttachments;
        public uint width;
        public uint height;
        public uint layers;
        public VkFramebufferCreateInfo(VkStructureType sType, void* pNext, VkFramebufferCreateFlagBits flags, VkRenderPass renderPass, uint attachmentCount, VkImageView* pAttachments, uint width, uint height, uint layers)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.renderPass = renderPass;
            this.attachmentCount = attachmentCount;
            this.pAttachments = pAttachments;
            this.width = width;
            this.height = height;
            this.layers = layers;
        }
    }
    public unsafe struct VkDrawIndirectCommand
    {
        public uint vertexCount;
        public uint instanceCount;
        public uint firstVertex;
        public uint firstInstance;
        public VkDrawIndirectCommand(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            this.vertexCount = vertexCount;
            this.instanceCount = instanceCount;
            this.firstVertex = firstVertex;
            this.firstInstance = firstInstance;
        }
    }
    public unsafe struct VkDrawIndexedIndirectCommand
    {
        public uint indexCount;
        public uint instanceCount;
        public uint firstIndex;
        public int vertexOffset;
        public uint firstInstance;
        public VkDrawIndexedIndirectCommand(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            this.indexCount = indexCount;
            this.instanceCount = instanceCount;
            this.firstIndex = firstIndex;
            this.vertexOffset = vertexOffset;
            this.firstInstance = firstInstance;
        }
    }
    public unsafe struct VkDispatchIndirectCommand
    {
        public uint x;
        public uint y;
        public uint z;
        public VkDispatchIndirectCommand(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    public unsafe struct VkMultiDrawInfoEXT
    {
        public uint firstVertex;
        public uint vertexCount;
        public VkMultiDrawInfoEXT(uint firstVertex, uint vertexCount)
        {
            this.firstVertex = firstVertex;
            this.vertexCount = vertexCount;
        }
    }
    public unsafe struct VkMultiDrawIndexedInfoEXT
    {
        public uint firstIndex;
        public uint indexCount;
        public int vertexOffset;
        public VkMultiDrawIndexedInfoEXT(uint firstIndex, uint indexCount, int vertexOffset)
        {
            this.firstIndex = firstIndex;
            this.indexCount = indexCount;
            this.vertexOffset = vertexOffset;
        }
    }
    public unsafe struct VkSubmitInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubmitInfo;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public VkPipelineStageFlagBits* pWaitDstStageMask;
        public uint commandBufferCount;
        public VkCommandBuffer* pCommandBuffers;
        public uint signalSemaphoreCount;
        public VkSemaphore* pSignalSemaphores;
        public VkSubmitInfo(VkStructureType sType, void* pNext, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkPipelineStageFlagBits* pWaitDstStageMask, uint commandBufferCount, VkCommandBuffer* pCommandBuffers, uint signalSemaphoreCount, VkSemaphore* pSignalSemaphores)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.waitSemaphoreCount = waitSemaphoreCount;
            this.pWaitSemaphores = pWaitSemaphores;
            this.pWaitDstStageMask = pWaitDstStageMask;
            this.commandBufferCount = commandBufferCount;
            this.pCommandBuffers = pCommandBuffers;
            this.signalSemaphoreCount = signalSemaphoreCount;
            this.pSignalSemaphores = pSignalSemaphores;
        }
    }
    public unsafe struct VkDisplayPropertiesKHR
    {
        public VkDisplayKHR display;
        public byte* displayName;
        public VkExtent2D physicalDimensions;
        public VkExtent2D physicalResolution;
        public VkSurfaceTransformFlagBitsKHR supportedTransforms;
        public int planeReorderPossible;
        public int persistentContent;
        public VkDisplayPropertiesKHR(VkDisplayKHR display, byte* displayName, VkExtent2D physicalDimensions, VkExtent2D physicalResolution, VkSurfaceTransformFlagBitsKHR supportedTransforms, int planeReorderPossible, int persistentContent)
        {
            this.display = display;
            this.displayName = displayName;
            this.physicalDimensions = physicalDimensions;
            this.physicalResolution = physicalResolution;
            this.supportedTransforms = supportedTransforms;
            this.planeReorderPossible = planeReorderPossible;
            this.persistentContent = persistentContent;
        }
    }
    public unsafe struct VkDisplayPlanePropertiesKHR
    {
        public VkDisplayKHR currentDisplay;
        public uint currentStackIndex;
        public VkDisplayPlanePropertiesKHR(VkDisplayKHR currentDisplay, uint currentStackIndex)
        {
            this.currentDisplay = currentDisplay;
            this.currentStackIndex = currentStackIndex;
        }
    }
    public unsafe struct VkDisplayModeParametersKHR
    {
        public VkExtent2D visibleRegion;
        public uint refreshRate;
        public VkDisplayModeParametersKHR(VkExtent2D visibleRegion, uint refreshRate)
        {
            this.visibleRegion = visibleRegion;
            this.refreshRate = refreshRate;
        }
    }
    public unsafe struct VkDisplayModePropertiesKHR
    {
        public VkDisplayModeKHR displayMode;
        public VkDisplayModeParametersKHR parameters;
        public VkDisplayModePropertiesKHR(VkDisplayModeKHR displayMode, VkDisplayModeParametersKHR parameters)
        {
            this.displayMode = displayMode;
            this.parameters = parameters;
        }
    }
    public unsafe struct VkDisplayModeCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayModeCreateInfoKhr;
        public void* pNext;
        public VkDisplayModeCreateFlagsKHR flags;
        public VkDisplayModeParametersKHR parameters;
        public VkDisplayModeCreateInfoKHR(VkStructureType sType, void* pNext, VkDisplayModeCreateFlagsKHR flags, VkDisplayModeParametersKHR parameters)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.parameters = parameters;
        }
    }
    public unsafe struct VkDisplayPlaneCapabilitiesKHR
    {
        public VkDisplayPlaneAlphaFlagBitsKHR supportedAlpha;
        public VkOffset2D minSrcPosition;
        public VkOffset2D maxSrcPosition;
        public VkExtent2D minSrcExtent;
        public VkExtent2D maxSrcExtent;
        public VkOffset2D minDstPosition;
        public VkOffset2D maxDstPosition;
        public VkExtent2D minDstExtent;
        public VkExtent2D maxDstExtent;
        public VkDisplayPlaneCapabilitiesKHR(VkDisplayPlaneAlphaFlagBitsKHR supportedAlpha, VkOffset2D minSrcPosition, VkOffset2D maxSrcPosition, VkExtent2D minSrcExtent, VkExtent2D maxSrcExtent, VkOffset2D minDstPosition, VkOffset2D maxDstPosition, VkExtent2D minDstExtent, VkExtent2D maxDstExtent)
        {
            this.supportedAlpha = supportedAlpha;
            this.minSrcPosition = minSrcPosition;
            this.maxSrcPosition = maxSrcPosition;
            this.minSrcExtent = minSrcExtent;
            this.maxSrcExtent = maxSrcExtent;
            this.minDstPosition = minDstPosition;
            this.maxDstPosition = maxDstPosition;
            this.minDstExtent = minDstExtent;
            this.maxDstExtent = maxDstExtent;
        }
    }
    public unsafe struct VkDisplaySurfaceCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplaySurfaceCreateInfoKhr;
        public void* pNext;
        public VkDisplaySurfaceCreateFlagsKHR flags;
        public VkDisplayModeKHR displayMode;
        public uint planeIndex;
        public uint planeStackIndex;
        public VkSurfaceTransformFlagBitsKHR transform;
        public float globalAlpha;
        public VkDisplayPlaneAlphaFlagBitsKHR alphaMode;
        public VkExtent2D imageExtent;
        public VkDisplaySurfaceCreateInfoKHR(VkStructureType sType, void* pNext, VkDisplaySurfaceCreateFlagsKHR flags, VkDisplayModeKHR displayMode, uint planeIndex, uint planeStackIndex, VkSurfaceTransformFlagBitsKHR transform, float globalAlpha, VkDisplayPlaneAlphaFlagBitsKHR alphaMode, VkExtent2D imageExtent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.displayMode = displayMode;
            this.planeIndex = planeIndex;
            this.planeStackIndex = planeStackIndex;
            this.transform = transform;
            this.globalAlpha = globalAlpha;
            this.alphaMode = alphaMode;
            this.imageExtent = imageExtent;
        }
    }
    public unsafe struct VkDisplayPresentInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayPresentInfoKhr;
        public void* pNext;
        public VkRect2D srcRect;
        public VkRect2D dstRect;
        public int persistent;
        public VkDisplayPresentInfoKHR(VkStructureType sType, void* pNext, VkRect2D srcRect, VkRect2D dstRect, int persistent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcRect = srcRect;
            this.dstRect = dstRect;
            this.persistent = persistent;
        }
    }
    public unsafe struct VkSurfaceCapabilitiesKHR
    {
        public uint minImageCount;
        public uint maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public VkSurfaceTransformFlagBitsKHR supportedTransforms;
        public VkSurfaceTransformFlagBitsKHR currentTransform;
        public VkCompositeAlphaFlagBitsKHR supportedCompositeAlpha;
        public VkImageUsageFlagBits supportedUsageFlags;
        public VkSurfaceCapabilitiesKHR(uint minImageCount, uint maxImageCount, VkExtent2D currentExtent, VkExtent2D minImageExtent, VkExtent2D maxImageExtent, uint maxImageArrayLayers, VkSurfaceTransformFlagBitsKHR supportedTransforms, VkSurfaceTransformFlagBitsKHR currentTransform, VkCompositeAlphaFlagBitsKHR supportedCompositeAlpha, VkImageUsageFlagBits supportedUsageFlags)
        {
            this.minImageCount = minImageCount;
            this.maxImageCount = maxImageCount;
            this.currentExtent = currentExtent;
            this.minImageExtent = minImageExtent;
            this.maxImageExtent = maxImageExtent;
            this.maxImageArrayLayers = maxImageArrayLayers;
            this.supportedTransforms = supportedTransforms;
            this.currentTransform = currentTransform;
            this.supportedCompositeAlpha = supportedCompositeAlpha;
            this.supportedUsageFlags = supportedUsageFlags;
        }
    }
    public unsafe struct VkAndroidSurfaceCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAndroidSurfaceCreateInfoKhr;
        public void* pNext;
        public VkAndroidSurfaceCreateFlagsKHR flags;
        public IntPtr window;
        public VkAndroidSurfaceCreateInfoKHR(VkStructureType sType, void* pNext, VkAndroidSurfaceCreateFlagsKHR flags, IntPtr window)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.window = window;
        }
    }
    public unsafe struct VkViSurfaceCreateInfoNN
    {
        public VkStructureType sType = VkStructureType.StructureTypeViSurfaceCreateInfoNn;
        public void* pNext;
        public VkViSurfaceCreateFlagsNN flags;
        public void* window;
        public VkViSurfaceCreateInfoNN(VkStructureType sType, void* pNext, VkViSurfaceCreateFlagsNN flags, void* window)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.window = window;
        }
    }
    public unsafe struct VkWaylandSurfaceCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeWaylandSurfaceCreateInfoKhr;
        public void* pNext;
        public VkWaylandSurfaceCreateFlagsKHR flags;
        public IntPtr display;
        public IntPtr surface;
        public VkWaylandSurfaceCreateInfoKHR(VkStructureType sType, void* pNext, VkWaylandSurfaceCreateFlagsKHR flags, IntPtr display, IntPtr surface)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.display = display;
            this.surface = surface;
        }
    }
    public unsafe struct VkWin32SurfaceCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeWin32SurfaceCreateInfoKhr;
        public void* pNext;
        public VkWin32SurfaceCreateFlagsKHR flags;
        public IntPtr hinstance;
        public IntPtr hwnd;
        public VkWin32SurfaceCreateInfoKHR(VkStructureType sType, void* pNext, VkWin32SurfaceCreateFlagsKHR flags, IntPtr hinstance, IntPtr hwnd)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.hinstance = hinstance;
            this.hwnd = hwnd;
        }
    }
    public unsafe struct VkXlibSurfaceCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeXlibSurfaceCreateInfoKhr;
        public void* pNext;
        public VkXlibSurfaceCreateFlagsKHR flags;
        public IntPtr dpy;
        public nuint window;
        public VkXlibSurfaceCreateInfoKHR(VkStructureType sType, void* pNext, VkXlibSurfaceCreateFlagsKHR flags, IntPtr dpy, nuint window)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.dpy = dpy;
            this.window = window;
        }
    }
    public unsafe struct VkXcbSurfaceCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeXcbSurfaceCreateInfoKhr;
        public void* pNext;
        public VkXcbSurfaceCreateFlagsKHR flags;
        public IntPtr connection;
        public uint window;
        public VkXcbSurfaceCreateInfoKHR(VkStructureType sType, void* pNext, VkXcbSurfaceCreateFlagsKHR flags, IntPtr connection, uint window)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.connection = connection;
            this.window = window;
        }
    }
    public unsafe struct VkDirectFBSurfaceCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDirectfbSurfaceCreateInfoExt;
        public void* pNext;
        public VkDirectFBSurfaceCreateFlagsEXT flags;
        public IntPtr dfb;
        public IntPtr surface;
        public VkDirectFBSurfaceCreateInfoEXT(VkStructureType sType, void* pNext, VkDirectFBSurfaceCreateFlagsEXT flags, IntPtr dfb, IntPtr surface)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.dfb = dfb;
            this.surface = surface;
        }
    }
    public unsafe struct VkImagePipeSurfaceCreateInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeImagepipeSurfaceCreateInfoFuchsia;
        public void* pNext;
        public VkImagePipeSurfaceCreateFlagsFUCHSIA flags;
        public int imagePipeHandle;
        public VkImagePipeSurfaceCreateInfoFUCHSIA(VkStructureType sType, void* pNext, VkImagePipeSurfaceCreateFlagsFUCHSIA flags, int imagePipeHandle)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.imagePipeHandle = imagePipeHandle;
        }
    }
    public unsafe struct VkStreamDescriptorSurfaceCreateInfoGGP
    {
        public VkStructureType sType = VkStructureType.StructureTypeStreamDescriptorSurfaceCreateInfoGgp;
        public void* pNext;
        public VkStreamDescriptorSurfaceCreateFlagsGGP flags;
        // Unsupported type for field streamDescriptor
        public VkStreamDescriptorSurfaceCreateInfoGGP(){ }
    }
    public unsafe struct VkScreenSurfaceCreateInfoQNX
    {
        public VkStructureType sType = VkStructureType.StructureTypeScreenSurfaceCreateInfoQnx;
        public void* pNext;
        public VkScreenSurfaceCreateFlagsQNX flags;
        public IntPtr* context;
        public IntPtr* window;
        public VkScreenSurfaceCreateInfoQNX(VkStructureType sType, void* pNext, VkScreenSurfaceCreateFlagsQNX flags, IntPtr* context, IntPtr* window)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.context = context;
            this.window = window;
        }
    }
    public unsafe struct VkSurfaceFormatKHR
    {
        public VkFormat format;
        public VkColorSpaceKHR colorSpace;
        public VkSurfaceFormatKHR(VkFormat format, VkColorSpaceKHR colorSpace)
        {
            this.format = format;
            this.colorSpace = colorSpace;
        }
    }
    public unsafe struct VkSwapchainCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeSwapchainCreateInfoKhr;
        public void* pNext;
        public VkSwapchainCreateFlagBitsKHR flags;
        public VkSurfaceKHR surface;
        public uint minImageCount;
        public VkFormat imageFormat;
        public VkColorSpaceKHR imageColorSpace;
        public VkExtent2D imageExtent;
        public uint imageArrayLayers;
        public VkImageUsageFlagBits imageUsage;
        public VkSharingMode imageSharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkSurfaceTransformFlagBitsKHR preTransform;
        public VkCompositeAlphaFlagBitsKHR compositeAlpha;
        public VkPresentModeKHR presentMode;
        public int clipped;
        public VkSwapchainKHR oldSwapchain;
        public VkSwapchainCreateInfoKHR(VkStructureType sType, void* pNext, VkSwapchainCreateFlagBitsKHR flags, VkSurfaceKHR surface, uint minImageCount, VkFormat imageFormat, VkColorSpaceKHR imageColorSpace, VkExtent2D imageExtent, uint imageArrayLayers, VkImageUsageFlagBits imageUsage, VkSharingMode imageSharingMode, uint queueFamilyIndexCount, uint* pQueueFamilyIndices, VkSurfaceTransformFlagBitsKHR preTransform, VkCompositeAlphaFlagBitsKHR compositeAlpha, VkPresentModeKHR presentMode, int clipped, VkSwapchainKHR oldSwapchain)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.surface = surface;
            this.minImageCount = minImageCount;
            this.imageFormat = imageFormat;
            this.imageColorSpace = imageColorSpace;
            this.imageExtent = imageExtent;
            this.imageArrayLayers = imageArrayLayers;
            this.imageUsage = imageUsage;
            this.imageSharingMode = imageSharingMode;
            this.queueFamilyIndexCount = queueFamilyIndexCount;
            this.pQueueFamilyIndices = pQueueFamilyIndices;
            this.preTransform = preTransform;
            this.compositeAlpha = compositeAlpha;
            this.presentMode = presentMode;
            this.clipped = clipped;
            this.oldSwapchain = oldSwapchain;
        }
    }
    public unsafe struct VkPresentInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePresentInfoKhr;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public uint swapchainCount;
        public VkSwapchainKHR* pSwapchains;
        public uint* pImageIndices;
        public VkResult* pResults;
        public VkPresentInfoKHR(VkStructureType sType, void* pNext, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, uint swapchainCount, VkSwapchainKHR* pSwapchains, uint* pImageIndices, VkResult* pResults)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.waitSemaphoreCount = waitSemaphoreCount;
            this.pWaitSemaphores = pWaitSemaphores;
            this.swapchainCount = swapchainCount;
            this.pSwapchains = pSwapchains;
            this.pImageIndices = pImageIndices;
            this.pResults = pResults;
        }
    }
    public unsafe struct VkDebugReportCallbackCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDebugReportCallbackCreateInfoExt;
        public void* pNext;
        public VkDebugReportFlagBitsEXT flags;
        public delegate* unmanaged[Cdecl]<VkDebugReportFlagBitsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void*, int> pfnCallback;
        public void* pUserData;
        public VkDebugReportCallbackCreateInfoEXT(VkStructureType sType, void* pNext, VkDebugReportFlagBitsEXT flags, delegate* unmanaged[Cdecl]<VkDebugReportFlagBitsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void*, int> pfnCallback, void* pUserData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pfnCallback = pfnCallback;
            this.pUserData = pUserData;
        }
    }
    public unsafe struct VkValidationFlagsEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeValidationFlagsExt;
        public void* pNext;
        public uint disabledValidationCheckCount;
        public VkValidationCheckEXT* pDisabledValidationChecks;
        public VkValidationFlagsEXT(VkStructureType sType, void* pNext, uint disabledValidationCheckCount, VkValidationCheckEXT* pDisabledValidationChecks)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.disabledValidationCheckCount = disabledValidationCheckCount;
            this.pDisabledValidationChecks = pDisabledValidationChecks;
        }
    }
    public unsafe struct VkValidationFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeValidationFeaturesExt;
        public void* pNext;
        public uint enabledValidationFeatureCount;
        public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
        public uint disabledValidationFeatureCount;
        public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
        public VkValidationFeaturesEXT(VkStructureType sType, void* pNext, uint enabledValidationFeatureCount, VkValidationFeatureEnableEXT* pEnabledValidationFeatures, uint disabledValidationFeatureCount, VkValidationFeatureDisableEXT* pDisabledValidationFeatures)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.enabledValidationFeatureCount = enabledValidationFeatureCount;
            this.pEnabledValidationFeatures = pEnabledValidationFeatures;
            this.disabledValidationFeatureCount = disabledValidationFeatureCount;
            this.pDisabledValidationFeatures = pDisabledValidationFeatures;
        }
    }
    public unsafe struct VkLayerSettingsCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeLayerSettingsCreateInfoExt;
        public void* pNext;
        public uint settingCount;
        public VkLayerSettingEXT* pSettings;
        public VkLayerSettingsCreateInfoEXT(VkStructureType sType, void* pNext, uint settingCount, VkLayerSettingEXT* pSettings)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.settingCount = settingCount;
            this.pSettings = pSettings;
        }
    }
    public unsafe struct VkLayerSettingEXT
    {
        public byte* pLayerName;
        public byte* pSettingName;
        public VkLayerSettingTypeEXT type;
        public uint valueCount;
        public void* pValues;
        public VkLayerSettingEXT(byte* pLayerName, byte* pSettingName, VkLayerSettingTypeEXT type, uint valueCount, void* pValues)
        {
            this.pLayerName = pLayerName;
            this.pSettingName = pSettingName;
            this.type = type;
            this.valueCount = valueCount;
            this.pValues = pValues;
        }
    }
    public unsafe struct VkApplicationParametersEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeApplicationParametersExt;
        public void* pNext;
        public uint vendorID;
        public uint deviceID;
        public uint key;
        public ulong value;
        public VkApplicationParametersEXT(VkStructureType sType, void* pNext, uint vendorID, uint deviceID, uint key, ulong value)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.vendorID = vendorID;
            this.deviceID = deviceID;
            this.key = key;
            this.value = value;
        }
    }
    public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRasterizationStateRasterizationOrderAmd;
        public void* pNext;
        public VkRasterizationOrderAMD rasterizationOrder;
        public VkPipelineRasterizationStateRasterizationOrderAMD(VkStructureType sType, void* pNext, VkRasterizationOrderAMD rasterizationOrder)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rasterizationOrder = rasterizationOrder;
        }
    }
    public unsafe struct VkDebugMarkerObjectNameInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDebugMarkerObjectNameInfoExt;
        public void* pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong obj;
        public byte* pObjectName;
        public VkDebugMarkerObjectNameInfoEXT(VkStructureType sType, void* pNext, VkDebugReportObjectTypeEXT objectType, ulong obj, byte* pObjectName)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.objectType = objectType;
            this.obj = obj;
            this.pObjectName = pObjectName;
        }
    }
    public unsafe struct VkDebugMarkerObjectTagInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDebugMarkerObjectTagInfoExt;
        public void* pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong obj;
        public ulong tagName;
        public nuint tagSize;
        public void* pTag;
        public VkDebugMarkerObjectTagInfoEXT(VkStructureType sType, void* pNext, VkDebugReportObjectTypeEXT objectType, ulong obj, ulong tagName, nuint tagSize, void* pTag)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.objectType = objectType;
            this.obj = obj;
            this.tagName = tagName;
            this.tagSize = tagSize;
            this.pTag = pTag;
        }
    }
    public unsafe struct VkDebugMarkerMarkerInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDebugMarkerMarkerInfoExt;
        public void* pNext;
        public byte* pMarkerName;
        public fixed float color[4];
        public VkDebugMarkerMarkerInfoEXT(){ }
    }
    public unsafe struct VkDedicatedAllocationImageCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeDedicatedAllocationImageCreateInfoNv;
        public void* pNext;
        public int dedicatedAllocation;
        public VkDedicatedAllocationImageCreateInfoNV(VkStructureType sType, void* pNext, int dedicatedAllocation)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dedicatedAllocation = dedicatedAllocation;
        }
    }
    public unsafe struct VkDedicatedAllocationBufferCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeDedicatedAllocationBufferCreateInfoNv;
        public void* pNext;
        public int dedicatedAllocation;
        public VkDedicatedAllocationBufferCreateInfoNV(VkStructureType sType, void* pNext, int dedicatedAllocation)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dedicatedAllocation = dedicatedAllocation;
        }
    }
    public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeDedicatedAllocationMemoryAllocateInfoNv;
        public void* pNext;
        public VkImage image;
        public VkBuffer buffer;
        public VkDedicatedAllocationMemoryAllocateInfoNV(VkStructureType sType, void* pNext, VkImage image, VkBuffer buffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image = image;
            this.buffer = buffer;
        }
    }
    public unsafe struct VkExternalImageFormatPropertiesNV
    {
        public VkImageFormatProperties imageFormatProperties;
        public VkExternalMemoryFeatureFlagBitsNV externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlagBitsNV exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlagBitsNV compatibleHandleTypes;
        public VkExternalImageFormatPropertiesNV(VkImageFormatProperties imageFormatProperties, VkExternalMemoryFeatureFlagBitsNV externalMemoryFeatures, VkExternalMemoryHandleTypeFlagBitsNV exportFromImportedHandleTypes, VkExternalMemoryHandleTypeFlagBitsNV compatibleHandleTypes)
        {
            this.imageFormatProperties = imageFormatProperties;
            this.externalMemoryFeatures = externalMemoryFeatures;
            this.exportFromImportedHandleTypes = exportFromImportedHandleTypes;
            this.compatibleHandleTypes = compatibleHandleTypes;
        }
    }
    public unsafe struct VkExternalMemoryImageCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalMemoryImageCreateInfoNv;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBitsNV handleTypes;
        public VkExternalMemoryImageCreateInfoNV(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBitsNV handleTypes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleTypes = handleTypes;
        }
    }
    public unsafe struct VkExportMemoryAllocateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMemoryAllocateInfoNv;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBitsNV handleTypes;
        public VkExportMemoryAllocateInfoNV(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBitsNV handleTypes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleTypes = handleTypes;
        }
    }
    public unsafe struct VkImportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMemoryWin32HandleInfoNv;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBitsNV handleType;
        public IntPtr handle;
        public VkImportMemoryWin32HandleInfoNV(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBitsNV handleType, IntPtr handle)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleType = handleType;
            this.handle = handle;
        }
    }
    public unsafe struct VkExportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMemoryWin32HandleInfoNv;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public VkExportMemoryWin32HandleInfoNV(VkStructureType sType, void* pNext, SECURITY_ATTRIBUTES* pAttributes, uint dwAccess)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pAttributes = pAttributes;
            this.dwAccess = dwAccess;
        }
    }
    public unsafe struct VkExportMemorySciBufInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMemorySciBufInfoNv;
        public void* pNext;
        public IntPtr pAttributes;
        public VkExportMemorySciBufInfoNV(VkStructureType sType, void* pNext, IntPtr pAttributes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pAttributes = pAttributes;
        }
    }
    public unsafe struct VkImportMemorySciBufInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMemorySciBufInfoNv;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public IntPtr handle;
        public VkImportMemorySciBufInfoNV(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleType = handleType;
            this.handle = handle;
        }
    }
    public unsafe struct VkMemoryGetSciBufInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryGetSciBufInfoNv;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public VkMemoryGetSciBufInfoNV(VkStructureType sType, void* pNext, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memory = memory;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkMemorySciBufPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemorySciBufPropertiesNv;
        public void* pNext;
        public uint memoryTypeBits;
        public VkMemorySciBufPropertiesNV(VkStructureType sType, void* pNext, uint memoryTypeBits)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryTypeBits = memoryTypeBits;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalMemorySciBufFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalMemorySciBufFeaturesNv;
        public void* pNext;
        public int sciBufImport;
        public int sciBufExport;
        public VkPhysicalDeviceExternalMemorySciBufFeaturesNV(VkStructureType sType, void* pNext, int sciBufImport, int sciBufExport)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sciBufImport = sciBufImport;
            this.sciBufExport = sciBufExport;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalSciBufFeaturesNV
    {
        public VkPhysicalDeviceExternalSciBufFeaturesNV()
        {
        }
    }
    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeWin32KeyedMutexAcquireReleaseInfoNv;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeoutMilliseconds;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
        public VkWin32KeyedMutexAcquireReleaseInfoNV(VkStructureType sType, void* pNext, uint acquireCount, VkDeviceMemory* pAcquireSyncs, ulong* pAcquireKeys, uint* pAcquireTimeoutMilliseconds, uint releaseCount, VkDeviceMemory* pReleaseSyncs, ulong* pReleaseKeys)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.acquireCount = acquireCount;
            this.pAcquireSyncs = pAcquireSyncs;
            this.pAcquireKeys = pAcquireKeys;
            this.pAcquireTimeoutMilliseconds = pAcquireTimeoutMilliseconds;
            this.releaseCount = releaseCount;
            this.pReleaseSyncs = pReleaseSyncs;
            this.pReleaseKeys = pReleaseKeys;
        }
    }
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDeviceGeneratedCommandsFeaturesNv;
        public void* pNext;
        public int deviceGeneratedCommands;
        public VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV(VkStructureType sType, void* pNext, int deviceGeneratedCommands)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceGeneratedCommands = deviceGeneratedCommands;
        }
    }
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNv;
        public void* pNext;
        public int deviceGeneratedCompute;
        public int deviceGeneratedComputePipelines;
        public int deviceGeneratedComputeCaptureReplay;
        public VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV(VkStructureType sType, void* pNext, int deviceGeneratedCompute, int deviceGeneratedComputePipelines, int deviceGeneratedComputeCaptureReplay)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceGeneratedCompute = deviceGeneratedCompute;
            this.deviceGeneratedComputePipelines = deviceGeneratedComputePipelines;
            this.deviceGeneratedComputeCaptureReplay = deviceGeneratedComputeCaptureReplay;
        }
    }
    public unsafe struct VkDevicePrivateDataCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDevicePrivateDataCreateInfo;
        public void* pNext;
        public uint privateDataSlotRequestCount;
        public VkDevicePrivateDataCreateInfo(VkStructureType sType, void* pNext, uint privateDataSlotRequestCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.privateDataSlotRequestCount = privateDataSlotRequestCount;
        }
    }
    public unsafe struct VkDevicePrivateDataCreateInfoEXT
    {
        public VkDevicePrivateDataCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkPrivateDataSlotCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePrivateDataSlotCreateInfo;
        public void* pNext;
        public VkPrivateDataSlotCreateFlags flags;
        public VkPrivateDataSlotCreateInfo(VkStructureType sType, void* pNext, VkPrivateDataSlotCreateFlags flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkPrivateDataSlotCreateInfoEXT
    {
        public VkPrivateDataSlotCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDevicePrivateDataFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePrivateDataFeatures;
        public void* pNext;
        public int privateData;
        public VkPhysicalDevicePrivateDataFeatures(VkStructureType sType, void* pNext, int privateData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.privateData = privateData;
        }
    }
    public unsafe struct VkPhysicalDevicePrivateDataFeaturesEXT
    {
        public VkPhysicalDevicePrivateDataFeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDeviceGeneratedCommandsPropertiesNv;
        public void* pNext;
        public uint maxGraphicsShaderGroupCount;
        public uint maxIndirectSequenceCount;
        public uint maxIndirectCommandsTokenCount;
        public uint maxIndirectCommandsStreamCount;
        public uint maxIndirectCommandsTokenOffset;
        public uint maxIndirectCommandsStreamStride;
        public uint minSequencesCountBufferOffsetAlignment;
        public uint minSequencesIndexBufferOffsetAlignment;
        public uint minIndirectCommandsBufferOffsetAlignment;
        public VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV(VkStructureType sType, void* pNext, uint maxGraphicsShaderGroupCount, uint maxIndirectSequenceCount, uint maxIndirectCommandsTokenCount, uint maxIndirectCommandsStreamCount, uint maxIndirectCommandsTokenOffset, uint maxIndirectCommandsStreamStride, uint minSequencesCountBufferOffsetAlignment, uint minSequencesIndexBufferOffsetAlignment, uint minIndirectCommandsBufferOffsetAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxGraphicsShaderGroupCount = maxGraphicsShaderGroupCount;
            this.maxIndirectSequenceCount = maxIndirectSequenceCount;
            this.maxIndirectCommandsTokenCount = maxIndirectCommandsTokenCount;
            this.maxIndirectCommandsStreamCount = maxIndirectCommandsStreamCount;
            this.maxIndirectCommandsTokenOffset = maxIndirectCommandsTokenOffset;
            this.maxIndirectCommandsStreamStride = maxIndirectCommandsStreamStride;
            this.minSequencesCountBufferOffsetAlignment = minSequencesCountBufferOffsetAlignment;
            this.minSequencesIndexBufferOffsetAlignment = minSequencesIndexBufferOffsetAlignment;
            this.minIndirectCommandsBufferOffsetAlignment = minIndirectCommandsBufferOffsetAlignment;
        }
    }
    public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMultiDrawPropertiesExt;
        public void* pNext;
        public uint maxMultiDrawCount;
        public VkPhysicalDeviceMultiDrawPropertiesEXT(VkStructureType sType, void* pNext, uint maxMultiDrawCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxMultiDrawCount = maxMultiDrawCount;
        }
    }
    public unsafe struct VkGraphicsShaderGroupCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeGraphicsShaderGroupCreateInfoNv;
        public void* pNext;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
        public VkGraphicsShaderGroupCreateInfoNV(VkStructureType sType, void* pNext, uint stageCount, VkPipelineShaderStageCreateInfo* pStages, VkPipelineVertexInputStateCreateInfo* pVertexInputState, VkPipelineTessellationStateCreateInfo* pTessellationState)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stageCount = stageCount;
            this.pStages = pStages;
            this.pVertexInputState = pVertexInputState;
            this.pTessellationState = pTessellationState;
        }
    }
    public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeGraphicsPipelineShaderGroupsCreateInfoNv;
        public void* pNext;
        public uint groupCount;
        public VkGraphicsShaderGroupCreateInfoNV* pGroups;
        public uint pipelineCount;
        public VkPipeline* pPipelines;
        public VkGraphicsPipelineShaderGroupsCreateInfoNV(VkStructureType sType, void* pNext, uint groupCount, VkGraphicsShaderGroupCreateInfoNV* pGroups, uint pipelineCount, VkPipeline* pPipelines)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.groupCount = groupCount;
            this.pGroups = pGroups;
            this.pipelineCount = pipelineCount;
            this.pPipelines = pPipelines;
        }
    }
    public unsafe struct VkBindShaderGroupIndirectCommandNV
    {
        public uint groupIndex;
        public VkBindShaderGroupIndirectCommandNV(uint groupIndex)
        {
            this.groupIndex = groupIndex;
        }
    }
    public unsafe struct VkBindIndexBufferIndirectCommandNV
    {
        public ulong bufferAddress;
        public uint size;
        public VkIndexType indexType;
        public VkBindIndexBufferIndirectCommandNV(ulong bufferAddress, uint size, VkIndexType indexType)
        {
            this.bufferAddress = bufferAddress;
            this.size = size;
            this.indexType = indexType;
        }
    }
    public unsafe struct VkBindVertexBufferIndirectCommandNV
    {
        public ulong bufferAddress;
        public uint size;
        public uint stride;
        public VkBindVertexBufferIndirectCommandNV(ulong bufferAddress, uint size, uint stride)
        {
            this.bufferAddress = bufferAddress;
            this.size = size;
            this.stride = stride;
        }
    }
    public unsafe struct VkSetStateFlagsIndirectCommandNV
    {
        public uint data;
        public VkSetStateFlagsIndirectCommandNV(uint data)
        {
            this.data = data;
        }
    }
    public unsafe struct VkIndirectCommandsStreamNV
    {
        public VkBuffer buffer;
        public ulong offset;
        public VkIndirectCommandsStreamNV(VkBuffer buffer, ulong offset)
        {
            this.buffer = buffer;
            this.offset = offset;
        }
    }
    public unsafe struct VkIndirectCommandsLayoutTokenNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeIndirectCommandsLayoutTokenNv;
        public void* pNext;
        public VkIndirectCommandsTokenTypeNV tokenType;
        public uint stream;
        public uint offset;
        public uint vertexBindingUnit;
        public int vertexDynamicStride;
        public VkPipelineLayout pushconstantPipelineLayout;
        public VkShaderStageFlagBits pushconstantShaderStageFlags;
        public uint pushconstantOffset;
        public uint pushconstantSize;
        public VkIndirectStateFlagBitsNV indirectStateFlags;
        public uint indexTypeCount;
        public VkIndexType* pIndexTypes;
        public uint* pIndexTypeValues;
        public VkIndirectCommandsLayoutTokenNV(VkStructureType sType, void* pNext, VkIndirectCommandsTokenTypeNV tokenType, uint stream, uint offset, uint vertexBindingUnit, int vertexDynamicStride, VkPipelineLayout pushconstantPipelineLayout, VkShaderStageFlagBits pushconstantShaderStageFlags, uint pushconstantOffset, uint pushconstantSize, VkIndirectStateFlagBitsNV indirectStateFlags, uint indexTypeCount, VkIndexType* pIndexTypes, uint* pIndexTypeValues)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.tokenType = tokenType;
            this.stream = stream;
            this.offset = offset;
            this.vertexBindingUnit = vertexBindingUnit;
            this.vertexDynamicStride = vertexDynamicStride;
            this.pushconstantPipelineLayout = pushconstantPipelineLayout;
            this.pushconstantShaderStageFlags = pushconstantShaderStageFlags;
            this.pushconstantOffset = pushconstantOffset;
            this.pushconstantSize = pushconstantSize;
            this.indirectStateFlags = indirectStateFlags;
            this.indexTypeCount = indexTypeCount;
            this.pIndexTypes = pIndexTypes;
            this.pIndexTypeValues = pIndexTypeValues;
        }
    }
    public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeIndirectCommandsLayoutCreateInfoNv;
        public void* pNext;
        public VkIndirectCommandsLayoutUsageFlagBitsNV flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint tokenCount;
        public VkIndirectCommandsLayoutTokenNV* pTokens;
        public uint streamCount;
        public uint* pStreamStrides;
        public VkIndirectCommandsLayoutCreateInfoNV(VkStructureType sType, void* pNext, VkIndirectCommandsLayoutUsageFlagBitsNV flags, VkPipelineBindPoint pipelineBindPoint, uint tokenCount, VkIndirectCommandsLayoutTokenNV* pTokens, uint streamCount, uint* pStreamStrides)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pipelineBindPoint = pipelineBindPoint;
            this.tokenCount = tokenCount;
            this.pTokens = pTokens;
            this.streamCount = streamCount;
            this.pStreamStrides = pStreamStrides;
        }
    }
    public unsafe struct VkGeneratedCommandsInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeGeneratedCommandsInfoNv;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint streamCount;
        public VkIndirectCommandsStreamNV* pStreams;
        public uint sequencesCount;
        public VkBuffer preprocessBuffer;
        public ulong preprocessOffset;
        public ulong preprocessSize;
        public VkBuffer sequencesCountBuffer;
        public ulong sequencesCountOffset;
        public VkBuffer sequencesIndexBuffer;
        public ulong sequencesIndexOffset;
        public VkGeneratedCommandsInfoNV(VkStructureType sType, void* pNext, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, VkIndirectCommandsLayoutNV indirectCommandsLayout, uint streamCount, VkIndirectCommandsStreamNV* pStreams, uint sequencesCount, VkBuffer preprocessBuffer, ulong preprocessOffset, ulong preprocessSize, VkBuffer sequencesCountBuffer, ulong sequencesCountOffset, VkBuffer sequencesIndexBuffer, ulong sequencesIndexOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineBindPoint = pipelineBindPoint;
            this.pipeline = pipeline;
            this.indirectCommandsLayout = indirectCommandsLayout;
            this.streamCount = streamCount;
            this.pStreams = pStreams;
            this.sequencesCount = sequencesCount;
            this.preprocessBuffer = preprocessBuffer;
            this.preprocessOffset = preprocessOffset;
            this.preprocessSize = preprocessSize;
            this.sequencesCountBuffer = sequencesCountBuffer;
            this.sequencesCountOffset = sequencesCountOffset;
            this.sequencesIndexBuffer = sequencesIndexBuffer;
            this.sequencesIndexOffset = sequencesIndexOffset;
        }
    }
    public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeGeneratedCommandsMemoryRequirementsInfoNv;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint maxSequencesCount;
        public VkGeneratedCommandsMemoryRequirementsInfoNV(VkStructureType sType, void* pNext, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, VkIndirectCommandsLayoutNV indirectCommandsLayout, uint maxSequencesCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineBindPoint = pipelineBindPoint;
            this.pipeline = pipeline;
            this.indirectCommandsLayout = indirectCommandsLayout;
            this.maxSequencesCount = maxSequencesCount;
        }
    }
    public unsafe struct VkPipelineIndirectDeviceAddressInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineIndirectDeviceAddressInfoNv;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkPipelineIndirectDeviceAddressInfoNV(VkStructureType sType, void* pNext, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineBindPoint = pipelineBindPoint;
            this.pipeline = pipeline;
        }
    }
    public unsafe struct VkBindPipelineIndirectCommandNV
    {
        public ulong pipelineAddress;
        public VkBindPipelineIndirectCommandNV(ulong pipelineAddress)
        {
            this.pipelineAddress = pipelineAddress;
        }
    }
    public unsafe struct VkPhysicalDeviceFeatures2
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFeatures2;
        public void* pNext;
        public VkPhysicalDeviceFeatures features;
        public VkPhysicalDeviceFeatures2(VkStructureType sType, void* pNext, VkPhysicalDeviceFeatures features)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.features = features;
        }
    }
    public unsafe struct VkPhysicalDeviceFeatures2KHR
    {
        public VkPhysicalDeviceFeatures2KHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceProperties2
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceProperties2;
        public void* pNext;
        public VkPhysicalDeviceProperties properties;
        public VkPhysicalDeviceProperties2(VkStructureType sType, void* pNext, VkPhysicalDeviceProperties properties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.properties = properties;
        }
    }
    public unsafe struct VkPhysicalDeviceProperties2KHR
    {
        public VkPhysicalDeviceProperties2KHR()
        {
        }
    }
    public unsafe struct VkFormatProperties2
    {
        public VkStructureType sType = VkStructureType.StructureTypeFormatProperties2;
        public void* pNext;
        public VkFormatProperties formatProperties;
        public VkFormatProperties2(VkStructureType sType, void* pNext, VkFormatProperties formatProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.formatProperties = formatProperties;
        }
    }
    public unsafe struct VkFormatProperties2KHR
    {
        public VkFormatProperties2KHR()
        {
        }
    }
    public unsafe struct VkImageFormatProperties2
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageFormatProperties2;
        public void* pNext;
        public VkImageFormatProperties imageFormatProperties;
        public VkImageFormatProperties2(VkStructureType sType, void* pNext, VkImageFormatProperties imageFormatProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageFormatProperties = imageFormatProperties;
        }
    }
    public unsafe struct VkImageFormatProperties2KHR
    {
        public VkImageFormatProperties2KHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceImageFormatInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageFormatInfo2;
        public void* pNext;
        public VkFormat format;
        public VkImageType type;
        public VkImageTiling tiling;
        public VkImageUsageFlagBits usage;
        public VkImageCreateFlagBits flags;
        public VkPhysicalDeviceImageFormatInfo2(VkStructureType sType, void* pNext, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.format = format;
            this.type = type;
            this.tiling = tiling;
            this.usage = usage;
            this.flags = flags;
        }
    }
    public unsafe struct VkPhysicalDeviceImageFormatInfo2KHR
    {
        public VkPhysicalDeviceImageFormatInfo2KHR()
        {
        }
    }
    public unsafe struct VkQueueFamilyProperties2
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueueFamilyProperties2;
        public void* pNext;
        public VkQueueFamilyProperties queueFamilyProperties;
        public VkQueueFamilyProperties2(VkStructureType sType, void* pNext, VkQueueFamilyProperties queueFamilyProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.queueFamilyProperties = queueFamilyProperties;
        }
    }
    public unsafe struct VkQueueFamilyProperties2KHR
    {
        public VkQueueFamilyProperties2KHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceMemoryProperties2
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMemoryProperties2;
        public void* pNext;
        public VkPhysicalDeviceMemoryProperties memoryProperties;
        public VkPhysicalDeviceMemoryProperties2(VkStructureType sType, void* pNext, VkPhysicalDeviceMemoryProperties memoryProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryProperties = memoryProperties;
        }
    }
    public unsafe struct VkPhysicalDeviceMemoryProperties2KHR
    {
        public VkPhysicalDeviceMemoryProperties2KHR()
        {
        }
    }
    public unsafe struct VkSparseImageFormatProperties2
    {
        public VkStructureType sType = VkStructureType.StructureTypeSparseImageFormatProperties2;
        public void* pNext;
        public VkSparseImageFormatProperties properties;
        public VkSparseImageFormatProperties2(VkStructureType sType, void* pNext, VkSparseImageFormatProperties properties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.properties = properties;
        }
    }
    public unsafe struct VkSparseImageFormatProperties2KHR
    {
        public VkSparseImageFormatProperties2KHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSparseImageFormatInfo2;
        public void* pNext;
        public VkFormat format;
        public VkImageType type;
        public VkSampleCountFlagBits samples;
        public VkImageUsageFlagBits usage;
        public VkImageTiling tiling;
        public VkPhysicalDeviceSparseImageFormatInfo2(VkStructureType sType, void* pNext, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlagBits usage, VkImageTiling tiling)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.format = format;
            this.type = type;
            this.samples = samples;
            this.usage = usage;
            this.tiling = tiling;
        }
    }
    public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2KHR
    {
        public VkPhysicalDeviceSparseImageFormatInfo2KHR()
        {
        }
    }
    public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePushDescriptorPropertiesKhr;
        public void* pNext;
        public uint maxPushDescriptors;
        public VkPhysicalDevicePushDescriptorPropertiesKHR(VkStructureType sType, void* pNext, uint maxPushDescriptors)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxPushDescriptors = maxPushDescriptors;
        }
    }
    public unsafe struct VkConformanceVersion
    {
        public byte major;
        public byte minor;
        public byte subminor;
        public byte patch;
        public VkConformanceVersion(byte major, byte minor, byte subminor, byte patch)
        {
            this.major = major;
            this.minor = minor;
            this.subminor = subminor;
            this.patch = patch;
        }
    }
    public unsafe struct VkConformanceVersionKHR
    {
        public VkConformanceVersionKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceDriverProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDriverProperties;
        public void* pNext;
        public VkDriverId driverID;
        [InlineArray(256)]
        public struct driverNameInlineArray1
        {
            public byte element;
        }
        public driverNameInlineArray1 driverName;
        [InlineArray(256)]
        public struct driverInfoInlineArray1
        {
            public byte element;
        }
        public driverInfoInlineArray1 driverInfo;
        public VkConformanceVersion conformanceVersion;
        public VkPhysicalDeviceDriverProperties(){ }
    }
    public unsafe struct VkPhysicalDeviceDriverPropertiesKHR
    {
        public VkPhysicalDeviceDriverPropertiesKHR()
        {
        }
    }
    public unsafe struct VkPresentRegionsKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePresentRegionsKhr;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentRegionKHR* pRegions;
        public VkPresentRegionsKHR(VkStructureType sType, void* pNext, uint swapchainCount, VkPresentRegionKHR* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchainCount = swapchainCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkPresentRegionKHR
    {
        public uint rectangleCount;
        public VkRectLayerKHR* pRectangles;
        public VkPresentRegionKHR(uint rectangleCount, VkRectLayerKHR* pRectangles)
        {
            this.rectangleCount = rectangleCount;
            this.pRectangles = pRectangles;
        }
    }
    public unsafe struct VkRectLayerKHR
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
        public uint layer;
        public VkRectLayerKHR(VkOffset2D offset, VkExtent2D extent, uint layer)
        {
            this.offset = offset;
            this.extent = extent;
            this.layer = layer;
        }
    }
    public unsafe struct VkPhysicalDeviceVariablePointersFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVariablePointersFeatures;
        public void* pNext;
        public int variablePointersStorageBuffer;
        public int variablePointers;
        public VkPhysicalDeviceVariablePointersFeatures(VkStructureType sType, void* pNext, int variablePointersStorageBuffer, int variablePointers)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.variablePointersStorageBuffer = variablePointersStorageBuffer;
            this.variablePointers = variablePointers;
        }
    }
    public unsafe struct VkPhysicalDeviceVariablePointersFeaturesKHR
    {
        public VkPhysicalDeviceVariablePointersFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceVariablePointerFeaturesKHR
    {
        public VkPhysicalDeviceVariablePointerFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceVariablePointerFeatures
    {
        public VkPhysicalDeviceVariablePointerFeatures()
        {
        }
    }
    public unsafe struct VkExternalMemoryProperties
    {
        public VkExternalMemoryFeatureFlagBits externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlagBits exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlagBits compatibleHandleTypes;
        public VkExternalMemoryProperties(VkExternalMemoryFeatureFlagBits externalMemoryFeatures, VkExternalMemoryHandleTypeFlagBits exportFromImportedHandleTypes, VkExternalMemoryHandleTypeFlagBits compatibleHandleTypes)
        {
            this.externalMemoryFeatures = externalMemoryFeatures;
            this.exportFromImportedHandleTypes = exportFromImportedHandleTypes;
            this.compatibleHandleTypes = compatibleHandleTypes;
        }
    }
    public unsafe struct VkExternalMemoryPropertiesKHR
    {
        public VkExternalMemoryPropertiesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceExternalImageFormatInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalImageFormatInfo;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public VkPhysicalDeviceExternalImageFormatInfo(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalImageFormatInfoKHR
    {
        public VkPhysicalDeviceExternalImageFormatInfoKHR()
        {
        }
    }
    public unsafe struct VkExternalImageFormatProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalImageFormatProperties;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
        public VkExternalImageFormatProperties(VkStructureType sType, void* pNext, VkExternalMemoryProperties externalMemoryProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.externalMemoryProperties = externalMemoryProperties;
        }
    }
    public unsafe struct VkExternalImageFormatPropertiesKHR
    {
        public VkExternalImageFormatPropertiesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceExternalBufferInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalBufferInfo;
        public void* pNext;
        public VkBufferCreateFlagBits flags;
        public VkBufferUsageFlagBits usage;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public VkPhysicalDeviceExternalBufferInfo(VkStructureType sType, void* pNext, VkBufferCreateFlagBits flags, VkBufferUsageFlagBits usage, VkExternalMemoryHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.usage = usage;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalBufferInfoKHR
    {
        public VkPhysicalDeviceExternalBufferInfoKHR()
        {
        }
    }
    public unsafe struct VkExternalBufferProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalBufferProperties;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
        public VkExternalBufferProperties(VkStructureType sType, void* pNext, VkExternalMemoryProperties externalMemoryProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.externalMemoryProperties = externalMemoryProperties;
        }
    }
    public unsafe struct VkExternalBufferPropertiesKHR
    {
        public VkExternalBufferPropertiesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceIDProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceIdProperties;
        public void* pNext;
        public fixed byte deviceUUID[16];
        public fixed byte driverUUID[16];
        public fixed byte deviceLUID[8];
        public uint deviceNodeMask;
        public int deviceLUIDValid;
        public VkPhysicalDeviceIDProperties(){ }
    }
    public unsafe struct VkPhysicalDeviceIDPropertiesKHR
    {
        public VkPhysicalDeviceIDPropertiesKHR()
        {
        }
    }
    public unsafe struct VkExternalMemoryImageCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalMemoryImageCreateInfo;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleTypes;
        public VkExternalMemoryImageCreateInfo(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBits handleTypes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleTypes = handleTypes;
        }
    }
    public unsafe struct VkExternalMemoryImageCreateInfoKHR
    {
        public VkExternalMemoryImageCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkExternalMemoryBufferCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalMemoryBufferCreateInfo;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleTypes;
        public VkExternalMemoryBufferCreateInfo(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBits handleTypes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleTypes = handleTypes;
        }
    }
    public unsafe struct VkExternalMemoryBufferCreateInfoKHR
    {
        public VkExternalMemoryBufferCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkExportMemoryAllocateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMemoryAllocateInfo;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleTypes;
        public VkExportMemoryAllocateInfo(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBits handleTypes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleTypes = handleTypes;
        }
    }
    public unsafe struct VkExportMemoryAllocateInfoKHR
    {
        public VkExportMemoryAllocateInfoKHR()
        {
        }
    }
    public unsafe struct VkImportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMemoryWin32HandleInfoKhr;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public IntPtr handle;
        public char* name;
        public VkImportMemoryWin32HandleInfoKHR(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, char* name)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleType = handleType;
            this.handle = handle;
            this.name = name;
        }
    }
    public unsafe struct VkExportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMemoryWin32HandleInfoKhr;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public char* name;
        public VkExportMemoryWin32HandleInfoKHR(VkStructureType sType, void* pNext, SECURITY_ATTRIBUTES* pAttributes, uint dwAccess, char* name)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pAttributes = pAttributes;
            this.dwAccess = dwAccess;
            this.name = name;
        }
    }
    public unsafe struct VkImportMemoryZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMemoryZirconHandleInfoFuchsia;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public int handle;
        public VkImportMemoryZirconHandleInfoFUCHSIA(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBits handleType, int handle)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleType = handleType;
            this.handle = handle;
        }
    }
    public unsafe struct VkMemoryZirconHandlePropertiesFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryZirconHandlePropertiesFuchsia;
        public void* pNext;
        public uint memoryTypeBits;
        public VkMemoryZirconHandlePropertiesFUCHSIA(VkStructureType sType, void* pNext, uint memoryTypeBits)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryTypeBits = memoryTypeBits;
        }
    }
    public unsafe struct VkMemoryGetZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryGetZirconHandleInfoFuchsia;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public VkMemoryGetZirconHandleInfoFUCHSIA(VkStructureType sType, void* pNext, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memory = memory;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkMemoryWin32HandlePropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryWin32HandlePropertiesKhr;
        public void* pNext;
        public uint memoryTypeBits;
        public VkMemoryWin32HandlePropertiesKHR(VkStructureType sType, void* pNext, uint memoryTypeBits)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryTypeBits = memoryTypeBits;
        }
    }
    public unsafe struct VkMemoryGetWin32HandleInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryGetWin32HandleInfoKhr;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public VkMemoryGetWin32HandleInfoKHR(VkStructureType sType, void* pNext, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memory = memory;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkImportMemoryFdInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMemoryFdInfoKhr;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public int fd;
        public VkImportMemoryFdInfoKHR(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBits handleType, int fd)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleType = handleType;
            this.fd = fd;
        }
    }
    public unsafe struct VkMemoryFdPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryFdPropertiesKhr;
        public void* pNext;
        public uint memoryTypeBits;
        public VkMemoryFdPropertiesKHR(VkStructureType sType, void* pNext, uint memoryTypeBits)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryTypeBits = memoryTypeBits;
        }
    }
    public unsafe struct VkMemoryGetFdInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryGetFdInfoKhr;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public VkMemoryGetFdInfoKHR(VkStructureType sType, void* pNext, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memory = memory;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeWin32KeyedMutexAcquireReleaseInfoKhr;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeouts;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
        public VkWin32KeyedMutexAcquireReleaseInfoKHR(VkStructureType sType, void* pNext, uint acquireCount, VkDeviceMemory* pAcquireSyncs, ulong* pAcquireKeys, uint* pAcquireTimeouts, uint releaseCount, VkDeviceMemory* pReleaseSyncs, ulong* pReleaseKeys)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.acquireCount = acquireCount;
            this.pAcquireSyncs = pAcquireSyncs;
            this.pAcquireKeys = pAcquireKeys;
            this.pAcquireTimeouts = pAcquireTimeouts;
            this.releaseCount = releaseCount;
            this.pReleaseSyncs = pReleaseSyncs;
            this.pReleaseKeys = pReleaseKeys;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalSemaphoreInfo;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public VkPhysicalDeviceExternalSemaphoreInfo(VkStructureType sType, void* pNext, VkExternalSemaphoreHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalSemaphoreInfoKHR
    {
        public VkPhysicalDeviceExternalSemaphoreInfoKHR()
        {
        }
    }
    public unsafe struct VkExternalSemaphoreProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalSemaphoreProperties;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlagBits exportFromImportedHandleTypes;
        public VkExternalSemaphoreHandleTypeFlagBits compatibleHandleTypes;
        public VkExternalSemaphoreFeatureFlagBits externalSemaphoreFeatures;
        public VkExternalSemaphoreProperties(VkStructureType sType, void* pNext, VkExternalSemaphoreHandleTypeFlagBits exportFromImportedHandleTypes, VkExternalSemaphoreHandleTypeFlagBits compatibleHandleTypes, VkExternalSemaphoreFeatureFlagBits externalSemaphoreFeatures)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.exportFromImportedHandleTypes = exportFromImportedHandleTypes;
            this.compatibleHandleTypes = compatibleHandleTypes;
            this.externalSemaphoreFeatures = externalSemaphoreFeatures;
        }
    }
    public unsafe struct VkExternalSemaphorePropertiesKHR
    {
        public VkExternalSemaphorePropertiesKHR()
        {
        }
    }
    public unsafe struct VkExportSemaphoreCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportSemaphoreCreateInfo;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlagBits handleTypes;
        public VkExportSemaphoreCreateInfo(VkStructureType sType, void* pNext, VkExternalSemaphoreHandleTypeFlagBits handleTypes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleTypes = handleTypes;
        }
    }
    public unsafe struct VkExportSemaphoreCreateInfoKHR
    {
        public VkExportSemaphoreCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportSemaphoreWin32HandleInfoKhr;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlagBits flags;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public IntPtr handle;
        public char* name;
        public VkImportSemaphoreWin32HandleInfoKHR(VkStructureType sType, void* pNext, VkSemaphore semaphore, VkSemaphoreImportFlagBits flags, VkExternalSemaphoreHandleTypeFlagBits handleType, IntPtr handle, char* name)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.flags = flags;
            this.handleType = handleType;
            this.handle = handle;
            this.name = name;
        }
    }
    public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportSemaphoreWin32HandleInfoKhr;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public char* name;
        public VkExportSemaphoreWin32HandleInfoKHR(VkStructureType sType, void* pNext, SECURITY_ATTRIBUTES* pAttributes, uint dwAccess, char* name)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pAttributes = pAttributes;
            this.dwAccess = dwAccess;
            this.name = name;
        }
    }
    public unsafe struct VkD3D12FenceSubmitInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeD3d12FenceSubmitInfoKhr;
        public void* pNext;
        public uint waitSemaphoreValuesCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValuesCount;
        public ulong* pSignalSemaphoreValues;
        public VkD3D12FenceSubmitInfoKHR(VkStructureType sType, void* pNext, uint waitSemaphoreValuesCount, ulong* pWaitSemaphoreValues, uint signalSemaphoreValuesCount, ulong* pSignalSemaphoreValues)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.waitSemaphoreValuesCount = waitSemaphoreValuesCount;
            this.pWaitSemaphoreValues = pWaitSemaphoreValues;
            this.signalSemaphoreValuesCount = signalSemaphoreValuesCount;
            this.pSignalSemaphoreValues = pSignalSemaphoreValues;
        }
    }
    public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreGetWin32HandleInfoKhr;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public VkSemaphoreGetWin32HandleInfoKHR(VkStructureType sType, void* pNext, VkSemaphore semaphore, VkExternalSemaphoreHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkImportSemaphoreFdInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportSemaphoreFdInfoKhr;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlagBits flags;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public int fd;
        public VkImportSemaphoreFdInfoKHR(VkStructureType sType, void* pNext, VkSemaphore semaphore, VkSemaphoreImportFlagBits flags, VkExternalSemaphoreHandleTypeFlagBits handleType, int fd)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.flags = flags;
            this.handleType = handleType;
            this.fd = fd;
        }
    }
    public unsafe struct VkSemaphoreGetFdInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreGetFdInfoKhr;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public VkSemaphoreGetFdInfoKHR(VkStructureType sType, void* pNext, VkSemaphore semaphore, VkExternalSemaphoreHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkImportSemaphoreZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportSemaphoreZirconHandleInfoFuchsia;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlagBits flags;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public int zirconHandle;
        public VkImportSemaphoreZirconHandleInfoFUCHSIA(VkStructureType sType, void* pNext, VkSemaphore semaphore, VkSemaphoreImportFlagBits flags, VkExternalSemaphoreHandleTypeFlagBits handleType, int zirconHandle)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.flags = flags;
            this.handleType = handleType;
            this.zirconHandle = zirconHandle;
        }
    }
    public unsafe struct VkSemaphoreGetZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreGetZirconHandleInfoFuchsia;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public VkSemaphoreGetZirconHandleInfoFUCHSIA(VkStructureType sType, void* pNext, VkSemaphore semaphore, VkExternalSemaphoreHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalFenceInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalFenceInfo;
        public void* pNext;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public VkPhysicalDeviceExternalFenceInfo(VkStructureType sType, void* pNext, VkExternalFenceHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalFenceInfoKHR
    {
        public VkPhysicalDeviceExternalFenceInfoKHR()
        {
        }
    }
    public unsafe struct VkExternalFenceProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalFenceProperties;
        public void* pNext;
        public VkExternalFenceHandleTypeFlagBits exportFromImportedHandleTypes;
        public VkExternalFenceHandleTypeFlagBits compatibleHandleTypes;
        public VkExternalFenceFeatureFlagBits externalFenceFeatures;
        public VkExternalFenceProperties(VkStructureType sType, void* pNext, VkExternalFenceHandleTypeFlagBits exportFromImportedHandleTypes, VkExternalFenceHandleTypeFlagBits compatibleHandleTypes, VkExternalFenceFeatureFlagBits externalFenceFeatures)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.exportFromImportedHandleTypes = exportFromImportedHandleTypes;
            this.compatibleHandleTypes = compatibleHandleTypes;
            this.externalFenceFeatures = externalFenceFeatures;
        }
    }
    public unsafe struct VkExternalFencePropertiesKHR
    {
        public VkExternalFencePropertiesKHR()
        {
        }
    }
    public unsafe struct VkExportFenceCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportFenceCreateInfo;
        public void* pNext;
        public VkExternalFenceHandleTypeFlagBits handleTypes;
        public VkExportFenceCreateInfo(VkStructureType sType, void* pNext, VkExternalFenceHandleTypeFlagBits handleTypes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleTypes = handleTypes;
        }
    }
    public unsafe struct VkExportFenceCreateInfoKHR
    {
        public VkExportFenceCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkImportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportFenceWin32HandleInfoKhr;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlagBits flags;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public IntPtr handle;
        public char* name;
        public VkImportFenceWin32HandleInfoKHR(VkStructureType sType, void* pNext, VkFence fence, VkFenceImportFlagBits flags, VkExternalFenceHandleTypeFlagBits handleType, IntPtr handle, char* name)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fence = fence;
            this.flags = flags;
            this.handleType = handleType;
            this.handle = handle;
            this.name = name;
        }
    }
    public unsafe struct VkExportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportFenceWin32HandleInfoKhr;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public char* name;
        public VkExportFenceWin32HandleInfoKHR(VkStructureType sType, void* pNext, SECURITY_ATTRIBUTES* pAttributes, uint dwAccess, char* name)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pAttributes = pAttributes;
            this.dwAccess = dwAccess;
            this.name = name;
        }
    }
    public unsafe struct VkFenceGetWin32HandleInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeFenceGetWin32HandleInfoKhr;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public VkFenceGetWin32HandleInfoKHR(VkStructureType sType, void* pNext, VkFence fence, VkExternalFenceHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fence = fence;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkImportFenceFdInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportFenceFdInfoKhr;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlagBits flags;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public int fd;
        public VkImportFenceFdInfoKHR(VkStructureType sType, void* pNext, VkFence fence, VkFenceImportFlagBits flags, VkExternalFenceHandleTypeFlagBits handleType, int fd)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fence = fence;
            this.flags = flags;
            this.handleType = handleType;
            this.fd = fd;
        }
    }
    public unsafe struct VkFenceGetFdInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeFenceGetFdInfoKhr;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public VkFenceGetFdInfoKHR(VkStructureType sType, void* pNext, VkFence fence, VkExternalFenceHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fence = fence;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkExportFenceSciSyncInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportFenceSciSyncInfoNv;
        public void* pNext;
        public IntPtr pAttributes;
        public VkExportFenceSciSyncInfoNV(VkStructureType sType, void* pNext, IntPtr pAttributes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pAttributes = pAttributes;
        }
    }
    public unsafe struct VkImportFenceSciSyncInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportFenceSciSyncInfoNv;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public void* handle;
        public VkImportFenceSciSyncInfoNV(VkStructureType sType, void* pNext, VkFence fence, VkExternalFenceHandleTypeFlagBits handleType, void* handle)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fence = fence;
            this.handleType = handleType;
            this.handle = handle;
        }
    }
    public unsafe struct VkFenceGetSciSyncInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeFenceGetSciSyncInfoNv;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public VkFenceGetSciSyncInfoNV(VkStructureType sType, void* pNext, VkFence fence, VkExternalFenceHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fence = fence;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkExportSemaphoreSciSyncInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportSemaphoreSciSyncInfoNv;
        public void* pNext;
        public IntPtr pAttributes;
        public VkExportSemaphoreSciSyncInfoNV(VkStructureType sType, void* pNext, IntPtr pAttributes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pAttributes = pAttributes;
        }
    }
    public unsafe struct VkImportSemaphoreSciSyncInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportSemaphoreSciSyncInfoNv;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public void* handle;
        public VkImportSemaphoreSciSyncInfoNV(VkStructureType sType, void* pNext, VkSemaphore semaphore, VkExternalSemaphoreHandleTypeFlagBits handleType, void* handle)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.handleType = handleType;
            this.handle = handle;
        }
    }
    public unsafe struct VkSemaphoreGetSciSyncInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreGetSciSyncInfoNv;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public VkSemaphoreGetSciSyncInfoNV(VkStructureType sType, void* pNext, VkSemaphore semaphore, VkExternalSemaphoreHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkSciSyncAttributesInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeSciSyncAttributesInfoNv;
        public void* pNext;
        public VkSciSyncClientTypeNV clientType;
        public VkSciSyncPrimitiveTypeNV primitiveType;
        public VkSciSyncAttributesInfoNV(VkStructureType sType, void* pNext, VkSciSyncClientTypeNV clientType, VkSciSyncPrimitiveTypeNV primitiveType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.clientType = clientType;
            this.primitiveType = primitiveType;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalSciSyncFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalSciSyncFeaturesNv;
        public void* pNext;
        public int sciSyncFence;
        public int sciSyncSemaphore;
        public int sciSyncImport;
        public int sciSyncExport;
        public VkPhysicalDeviceExternalSciSyncFeaturesNV(VkStructureType sType, void* pNext, int sciSyncFence, int sciSyncSemaphore, int sciSyncImport, int sciSyncExport)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sciSyncFence = sciSyncFence;
            this.sciSyncSemaphore = sciSyncSemaphore;
            this.sciSyncImport = sciSyncImport;
            this.sciSyncExport = sciSyncExport;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalSciSync2FeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalSciSync2FeaturesNv;
        public void* pNext;
        public int sciSyncFence;
        public int sciSyncSemaphore2;
        public int sciSyncImport;
        public int sciSyncExport;
        public VkPhysicalDeviceExternalSciSync2FeaturesNV(VkStructureType sType, void* pNext, int sciSyncFence, int sciSyncSemaphore2, int sciSyncImport, int sciSyncExport)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sciSyncFence = sciSyncFence;
            this.sciSyncSemaphore2 = sciSyncSemaphore2;
            this.sciSyncImport = sciSyncImport;
            this.sciSyncExport = sciSyncExport;
        }
    }
    public unsafe struct VkSemaphoreSciSyncPoolCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreSciSyncPoolCreateInfoNv;
        public void* pNext;
        public IntPtr handle;
        public VkSemaphoreSciSyncPoolCreateInfoNV(VkStructureType sType, void* pNext, IntPtr handle)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handle = handle;
        }
    }
    public unsafe struct VkSemaphoreSciSyncCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreSciSyncCreateInfoNv;
        public void* pNext;
        public VkSemaphoreSciSyncPoolNV semaphorePool;
        public IntPtr pFence;
        public VkSemaphoreSciSyncCreateInfoNV(VkStructureType sType, void* pNext, VkSemaphoreSciSyncPoolNV semaphorePool, IntPtr pFence)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphorePool = semaphorePool;
            this.pFence = pFence;
        }
    }
    public unsafe struct VkDeviceSemaphoreSciSyncPoolReservationCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint semaphoreSciSyncPoolRequestCount;
        public VkDeviceSemaphoreSciSyncPoolReservationCreateInfoNV(VkStructureType sType, void* pNext, uint semaphoreSciSyncPoolRequestCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphoreSciSyncPoolRequestCount = semaphoreSciSyncPoolRequestCount;
        }
    }
    public unsafe struct VkPhysicalDeviceMultiviewFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMultiviewFeatures;
        public void* pNext;
        public int multiview;
        public int multiviewGeometryShader;
        public int multiviewTessellationShader;
        public VkPhysicalDeviceMultiviewFeatures(VkStructureType sType, void* pNext, int multiview, int multiviewGeometryShader, int multiviewTessellationShader)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.multiview = multiview;
            this.multiviewGeometryShader = multiviewGeometryShader;
            this.multiviewTessellationShader = multiviewTessellationShader;
        }
    }
    public unsafe struct VkPhysicalDeviceMultiviewFeaturesKHR
    {
        public VkPhysicalDeviceMultiviewFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceMultiviewProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMultiviewProperties;
        public void* pNext;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
        public VkPhysicalDeviceMultiviewProperties(VkStructureType sType, void* pNext, uint maxMultiviewViewCount, uint maxMultiviewInstanceIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxMultiviewViewCount = maxMultiviewViewCount;
            this.maxMultiviewInstanceIndex = maxMultiviewInstanceIndex;
        }
    }
    public unsafe struct VkPhysicalDeviceMultiviewPropertiesKHR
    {
        public VkPhysicalDeviceMultiviewPropertiesKHR()
        {
        }
    }
    public unsafe struct VkRenderPassMultiviewCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassMultiviewCreateInfo;
        public void* pNext;
        public uint subpassCount;
        public uint* pViewMasks;
        public uint dependencyCount;
        public int* pViewOffsets;
        public uint correlationMaskCount;
        public uint* pCorrelationMasks;
        public VkRenderPassMultiviewCreateInfo(VkStructureType sType, void* pNext, uint subpassCount, uint* pViewMasks, uint dependencyCount, int* pViewOffsets, uint correlationMaskCount, uint* pCorrelationMasks)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.subpassCount = subpassCount;
            this.pViewMasks = pViewMasks;
            this.dependencyCount = dependencyCount;
            this.pViewOffsets = pViewOffsets;
            this.correlationMaskCount = correlationMaskCount;
            this.pCorrelationMasks = pCorrelationMasks;
        }
    }
    public unsafe struct VkRenderPassMultiviewCreateInfoKHR
    {
        public VkRenderPassMultiviewCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkSurfaceCapabilities2EXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfaceCapabilities2Ext;
        public void* pNext;
        public uint minImageCount;
        public uint maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public VkSurfaceTransformFlagBitsKHR supportedTransforms;
        public VkSurfaceTransformFlagBitsKHR currentTransform;
        public VkCompositeAlphaFlagBitsKHR supportedCompositeAlpha;
        public VkImageUsageFlagBits supportedUsageFlags;
        public VkSurfaceCounterFlagBitsEXT supportedSurfaceCounters;
        public VkSurfaceCapabilities2EXT(VkStructureType sType, void* pNext, uint minImageCount, uint maxImageCount, VkExtent2D currentExtent, VkExtent2D minImageExtent, VkExtent2D maxImageExtent, uint maxImageArrayLayers, VkSurfaceTransformFlagBitsKHR supportedTransforms, VkSurfaceTransformFlagBitsKHR currentTransform, VkCompositeAlphaFlagBitsKHR supportedCompositeAlpha, VkImageUsageFlagBits supportedUsageFlags, VkSurfaceCounterFlagBitsEXT supportedSurfaceCounters)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minImageCount = minImageCount;
            this.maxImageCount = maxImageCount;
            this.currentExtent = currentExtent;
            this.minImageExtent = minImageExtent;
            this.maxImageExtent = maxImageExtent;
            this.maxImageArrayLayers = maxImageArrayLayers;
            this.supportedTransforms = supportedTransforms;
            this.currentTransform = currentTransform;
            this.supportedCompositeAlpha = supportedCompositeAlpha;
            this.supportedUsageFlags = supportedUsageFlags;
            this.supportedSurfaceCounters = supportedSurfaceCounters;
        }
    }
    public unsafe struct VkDisplayPowerInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayPowerInfoExt;
        public void* pNext;
        public VkDisplayPowerStateEXT powerState;
        public VkDisplayPowerInfoEXT(VkStructureType sType, void* pNext, VkDisplayPowerStateEXT powerState)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.powerState = powerState;
        }
    }
    public unsafe struct VkDeviceEventInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceEventInfoExt;
        public void* pNext;
        public VkDeviceEventTypeEXT deviceEvent;
        public VkDeviceEventInfoEXT(VkStructureType sType, void* pNext, VkDeviceEventTypeEXT deviceEvent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceEvent = deviceEvent;
        }
    }
    public unsafe struct VkDisplayEventInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayEventInfoExt;
        public void* pNext;
        public VkDisplayEventTypeEXT displayEvent;
        public VkDisplayEventInfoEXT(VkStructureType sType, void* pNext, VkDisplayEventTypeEXT displayEvent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.displayEvent = displayEvent;
        }
    }
    public unsafe struct VkSwapchainCounterCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSwapchainCounterCreateInfoExt;
        public void* pNext;
        public VkSurfaceCounterFlagBitsEXT surfaceCounters;
        public VkSwapchainCounterCreateInfoEXT(VkStructureType sType, void* pNext, VkSurfaceCounterFlagBitsEXT surfaceCounters)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.surfaceCounters = surfaceCounters;
        }
    }
    public unsafe struct VkPhysicalDeviceGroupProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceGroupProperties;
        public void* pNext;
        public uint physicalDeviceCount;
        [InlineArray(32)]
        public struct physicalDevicesInlineArray1
        {
            public VkPhysicalDevice element;
        }
        public physicalDevicesInlineArray1 physicalDevices;
        public int subsetAllocation;
        public VkPhysicalDeviceGroupProperties(){ }
    }
    public unsafe struct VkPhysicalDeviceGroupPropertiesKHR
    {
        public VkPhysicalDeviceGroupPropertiesKHR()
        {
        }
    }
    public unsafe struct VkMemoryAllocateFlagsInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryAllocateFlagsInfo;
        public void* pNext;
        public VkMemoryAllocateFlagBits flags;
        public uint deviceMask;
        public VkMemoryAllocateFlagsInfo(VkStructureType sType, void* pNext, VkMemoryAllocateFlagBits flags, uint deviceMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.deviceMask = deviceMask;
        }
    }
    public unsafe struct VkMemoryAllocateFlagsInfoKHR
    {
        public VkMemoryAllocateFlagsInfoKHR()
        {
        }
    }
    public unsafe struct VkBindBufferMemoryInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindBufferMemoryInfo;
        public void* pNext;
        public VkBuffer buffer;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkBindBufferMemoryInfo(VkStructureType sType, void* pNext, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.buffer = buffer;
            this.memory = memory;
            this.memoryOffset = memoryOffset;
        }
    }
    public unsafe struct VkBindBufferMemoryInfoKHR
    {
        public VkBindBufferMemoryInfoKHR()
        {
        }
    }
    public unsafe struct VkBindBufferMemoryDeviceGroupInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindBufferMemoryDeviceGroupInfo;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public VkBindBufferMemoryDeviceGroupInfo(VkStructureType sType, void* pNext, uint deviceIndexCount, uint* pDeviceIndices)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceIndexCount = deviceIndexCount;
            this.pDeviceIndices = pDeviceIndices;
        }
    }
    public unsafe struct VkBindBufferMemoryDeviceGroupInfoKHR
    {
        public VkBindBufferMemoryDeviceGroupInfoKHR()
        {
        }
    }
    public unsafe struct VkBindImageMemoryInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindImageMemoryInfo;
        public void* pNext;
        public VkImage image;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkBindImageMemoryInfo(VkStructureType sType, void* pNext, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image = image;
            this.memory = memory;
            this.memoryOffset = memoryOffset;
        }
    }
    public unsafe struct VkBindImageMemoryInfoKHR
    {
        public VkBindImageMemoryInfoKHR()
        {
        }
    }
    public unsafe struct VkBindImageMemoryDeviceGroupInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindImageMemoryDeviceGroupInfo;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public uint splitInstanceBindRegionCount;
        public VkRect2D* pSplitInstanceBindRegions;
        public VkBindImageMemoryDeviceGroupInfo(VkStructureType sType, void* pNext, uint deviceIndexCount, uint* pDeviceIndices, uint splitInstanceBindRegionCount, VkRect2D* pSplitInstanceBindRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceIndexCount = deviceIndexCount;
            this.pDeviceIndices = pDeviceIndices;
            this.splitInstanceBindRegionCount = splitInstanceBindRegionCount;
            this.pSplitInstanceBindRegions = pSplitInstanceBindRegions;
        }
    }
    public unsafe struct VkBindImageMemoryDeviceGroupInfoKHR
    {
        public VkBindImageMemoryDeviceGroupInfoKHR()
        {
        }
    }
    public unsafe struct VkDeviceGroupRenderPassBeginInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceGroupRenderPassBeginInfo;
        public void* pNext;
        public uint deviceMask;
        public uint deviceRenderAreaCount;
        public VkRect2D* pDeviceRenderAreas;
        public VkDeviceGroupRenderPassBeginInfo(VkStructureType sType, void* pNext, uint deviceMask, uint deviceRenderAreaCount, VkRect2D* pDeviceRenderAreas)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceMask = deviceMask;
            this.deviceRenderAreaCount = deviceRenderAreaCount;
            this.pDeviceRenderAreas = pDeviceRenderAreas;
        }
    }
    public unsafe struct VkDeviceGroupRenderPassBeginInfoKHR
    {
        public VkDeviceGroupRenderPassBeginInfoKHR()
        {
        }
    }
    public unsafe struct VkDeviceGroupCommandBufferBeginInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceGroupCommandBufferBeginInfo;
        public void* pNext;
        public uint deviceMask;
        public VkDeviceGroupCommandBufferBeginInfo(VkStructureType sType, void* pNext, uint deviceMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceMask = deviceMask;
        }
    }
    public unsafe struct VkDeviceGroupCommandBufferBeginInfoKHR
    {
        public VkDeviceGroupCommandBufferBeginInfoKHR()
        {
        }
    }
    public unsafe struct VkDeviceGroupSubmitInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceGroupSubmitInfo;
        public void* pNext;
        public uint waitSemaphoreCount;
        public uint* pWaitSemaphoreDeviceIndices;
        public uint commandBufferCount;
        public uint* pCommandBufferDeviceMasks;
        public uint signalSemaphoreCount;
        public uint* pSignalSemaphoreDeviceIndices;
        public VkDeviceGroupSubmitInfo(VkStructureType sType, void* pNext, uint waitSemaphoreCount, uint* pWaitSemaphoreDeviceIndices, uint commandBufferCount, uint* pCommandBufferDeviceMasks, uint signalSemaphoreCount, uint* pSignalSemaphoreDeviceIndices)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.waitSemaphoreCount = waitSemaphoreCount;
            this.pWaitSemaphoreDeviceIndices = pWaitSemaphoreDeviceIndices;
            this.commandBufferCount = commandBufferCount;
            this.pCommandBufferDeviceMasks = pCommandBufferDeviceMasks;
            this.signalSemaphoreCount = signalSemaphoreCount;
            this.pSignalSemaphoreDeviceIndices = pSignalSemaphoreDeviceIndices;
        }
    }
    public unsafe struct VkDeviceGroupSubmitInfoKHR
    {
        public VkDeviceGroupSubmitInfoKHR()
        {
        }
    }
    public unsafe struct VkDeviceGroupBindSparseInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceGroupBindSparseInfo;
        public void* pNext;
        public uint resourceDeviceIndex;
        public uint memoryDeviceIndex;
        public VkDeviceGroupBindSparseInfo(VkStructureType sType, void* pNext, uint resourceDeviceIndex, uint memoryDeviceIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.resourceDeviceIndex = resourceDeviceIndex;
            this.memoryDeviceIndex = memoryDeviceIndex;
        }
    }
    public unsafe struct VkDeviceGroupBindSparseInfoKHR
    {
        public VkDeviceGroupBindSparseInfoKHR()
        {
        }
    }
    public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceGroupPresentCapabilitiesKhr;
        public void* pNext;
        public fixed uint presentMask[32];
        public VkDeviceGroupPresentModeFlagBitsKHR modes;
        public VkDeviceGroupPresentCapabilitiesKHR(){ }
    }
    public unsafe struct VkImageSwapchainCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageSwapchainCreateInfoKhr;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public VkImageSwapchainCreateInfoKHR(VkStructureType sType, void* pNext, VkSwapchainKHR swapchain)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchain = swapchain;
        }
    }
    public unsafe struct VkBindImageMemorySwapchainInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindImageMemorySwapchainInfoKhr;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public uint imageIndex;
        public VkBindImageMemorySwapchainInfoKHR(VkStructureType sType, void* pNext, VkSwapchainKHR swapchain, uint imageIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchain = swapchain;
            this.imageIndex = imageIndex;
        }
    }
    public unsafe struct VkAcquireNextImageInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAcquireNextImageInfoKhr;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public ulong timeout;
        public VkSemaphore semaphore;
        public VkFence fence;
        public uint deviceMask;
        public VkAcquireNextImageInfoKHR(VkStructureType sType, void* pNext, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint deviceMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchain = swapchain;
            this.timeout = timeout;
            this.semaphore = semaphore;
            this.fence = fence;
            this.deviceMask = deviceMask;
        }
    }
    public unsafe struct VkDeviceGroupPresentInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceGroupPresentInfoKhr;
        public void* pNext;
        public uint swapchainCount;
        public uint* pDeviceMasks;
        public VkDeviceGroupPresentModeFlagBitsKHR mode;
        public VkDeviceGroupPresentInfoKHR(VkStructureType sType, void* pNext, uint swapchainCount, uint* pDeviceMasks, VkDeviceGroupPresentModeFlagBitsKHR mode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchainCount = swapchainCount;
            this.pDeviceMasks = pDeviceMasks;
            this.mode = mode;
        }
    }
    public unsafe struct VkDeviceGroupDeviceCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceGroupDeviceCreateInfo;
        public void* pNext;
        public uint physicalDeviceCount;
        public VkPhysicalDevice* pPhysicalDevices;
        public VkDeviceGroupDeviceCreateInfo(VkStructureType sType, void* pNext, uint physicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.physicalDeviceCount = physicalDeviceCount;
            this.pPhysicalDevices = pPhysicalDevices;
        }
    }
    public unsafe struct VkDeviceGroupDeviceCreateInfoKHR
    {
        public VkDeviceGroupDeviceCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceGroupSwapchainCreateInfoKhr;
        public void* pNext;
        public VkDeviceGroupPresentModeFlagBitsKHR modes;
        public VkDeviceGroupSwapchainCreateInfoKHR(VkStructureType sType, void* pNext, VkDeviceGroupPresentModeFlagBitsKHR modes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.modes = modes;
        }
    }
    public unsafe struct VkDescriptorUpdateTemplateEntry
    {
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkDescriptorType descriptorType;
        public nuint offset;
        public nuint stride;
        public VkDescriptorUpdateTemplateEntry(uint dstBinding, uint dstArrayElement, uint descriptorCount, VkDescriptorType descriptorType, nuint offset, nuint stride)
        {
            this.dstBinding = dstBinding;
            this.dstArrayElement = dstArrayElement;
            this.descriptorCount = descriptorCount;
            this.descriptorType = descriptorType;
            this.offset = offset;
            this.stride = stride;
        }
    }
    public unsafe struct VkDescriptorUpdateTemplateEntryKHR
    {
        public VkDescriptorUpdateTemplateEntryKHR()
        {
        }
    }
    public unsafe struct VkDescriptorUpdateTemplateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorUpdateTemplateCreateInfo;
        public void* pNext;
        public VkDescriptorUpdateTemplateCreateFlags flags;
        public uint descriptorUpdateEntryCount;
        public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
        public VkDescriptorUpdateTemplateType templateType;
        public VkDescriptorSetLayout descriptorSetLayout;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipelineLayout pipelineLayout;
        public uint set;
        public VkDescriptorUpdateTemplateCreateInfo(VkStructureType sType, void* pNext, VkDescriptorUpdateTemplateCreateFlags flags, uint descriptorUpdateEntryCount, VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries, VkDescriptorUpdateTemplateType templateType, VkDescriptorSetLayout descriptorSetLayout, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout pipelineLayout, uint set)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.descriptorUpdateEntryCount = descriptorUpdateEntryCount;
            this.pDescriptorUpdateEntries = pDescriptorUpdateEntries;
            this.templateType = templateType;
            this.descriptorSetLayout = descriptorSetLayout;
            this.pipelineBindPoint = pipelineBindPoint;
            this.pipelineLayout = pipelineLayout;
            this.set = set;
        }
    }
    public unsafe struct VkDescriptorUpdateTemplateCreateInfoKHR
    {
        public VkDescriptorUpdateTemplateCreateInfoKHR()
        {
        }
    }
    /// <summary>Chromaticity coordinate</summary>
    public unsafe struct VkXYColorEXT
    {
        public float x;
        public float y;
        public VkXYColorEXT(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public unsafe struct VkPhysicalDevicePresentIdFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePresentIdFeaturesKhr;
        public void* pNext;
        public int presentId;
        public VkPhysicalDevicePresentIdFeaturesKHR(VkStructureType sType, void* pNext, int presentId)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentId = presentId;
        }
    }
    public unsafe struct VkPresentIdKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePresentIdKhr;
        public void* pNext;
        public uint swapchainCount;
        public ulong* pPresentIds;
        public VkPresentIdKHR(VkStructureType sType, void* pNext, uint swapchainCount, ulong* pPresentIds)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchainCount = swapchainCount;
            this.pPresentIds = pPresentIds;
        }
    }
    public unsafe struct VkPhysicalDevicePresentWaitFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePresentWaitFeaturesKhr;
        public void* pNext;
        public int presentWait;
        public VkPhysicalDevicePresentWaitFeaturesKHR(VkStructureType sType, void* pNext, int presentWait)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentWait = presentWait;
        }
    }
    public unsafe struct VkHdrMetadataEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeHdrMetadataExt;
        public void* pNext;
        public VkXYColorEXT displayPrimaryRed;
        public VkXYColorEXT displayPrimaryGreen;
        public VkXYColorEXT displayPrimaryBlue;
        public VkXYColorEXT whitePoint;
        public float maxLuminance;
        public float minLuminance;
        public float maxContentLightLevel;
        public float maxFrameAverageLightLevel;
        public VkHdrMetadataEXT(VkStructureType sType, void* pNext, VkXYColorEXT displayPrimaryRed, VkXYColorEXT displayPrimaryGreen, VkXYColorEXT displayPrimaryBlue, VkXYColorEXT whitePoint, float maxLuminance, float minLuminance, float maxContentLightLevel, float maxFrameAverageLightLevel)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.displayPrimaryRed = displayPrimaryRed;
            this.displayPrimaryGreen = displayPrimaryGreen;
            this.displayPrimaryBlue = displayPrimaryBlue;
            this.whitePoint = whitePoint;
            this.maxLuminance = maxLuminance;
            this.minLuminance = minLuminance;
            this.maxContentLightLevel = maxContentLightLevel;
            this.maxFrameAverageLightLevel = maxFrameAverageLightLevel;
        }
    }
    public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayNativeHdrSurfaceCapabilitiesAmd;
        public void* pNext;
        public int localDimmingSupport;
        public VkDisplayNativeHdrSurfaceCapabilitiesAMD(VkStructureType sType, void* pNext, int localDimmingSupport)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.localDimmingSupport = localDimmingSupport;
        }
    }
    public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypeSwapchainDisplayNativeHdrCreateInfoAmd;
        public void* pNext;
        public int localDimmingEnable;
        public VkSwapchainDisplayNativeHdrCreateInfoAMD(VkStructureType sType, void* pNext, int localDimmingEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.localDimmingEnable = localDimmingEnable;
        }
    }
    public unsafe struct VkRefreshCycleDurationGOOGLE
    {
        public ulong refreshDuration;
        public VkRefreshCycleDurationGOOGLE(ulong refreshDuration)
        {
            this.refreshDuration = refreshDuration;
        }
    }
    public unsafe struct VkPastPresentationTimingGOOGLE
    {
        public uint presentID;
        public ulong desiredPresentTime;
        public ulong actualPresentTime;
        public ulong earliestPresentTime;
        public ulong presentMargin;
        public VkPastPresentationTimingGOOGLE(uint presentID, ulong desiredPresentTime, ulong actualPresentTime, ulong earliestPresentTime, ulong presentMargin)
        {
            this.presentID = presentID;
            this.desiredPresentTime = desiredPresentTime;
            this.actualPresentTime = actualPresentTime;
            this.earliestPresentTime = earliestPresentTime;
            this.presentMargin = presentMargin;
        }
    }
    public unsafe struct VkPresentTimesInfoGOOGLE
    {
        public VkStructureType sType = VkStructureType.StructureTypePresentTimesInfoGoogle;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentTimeGOOGLE* pTimes;
        public VkPresentTimesInfoGOOGLE(VkStructureType sType, void* pNext, uint swapchainCount, VkPresentTimeGOOGLE* pTimes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchainCount = swapchainCount;
            this.pTimes = pTimes;
        }
    }
    public unsafe struct VkPresentTimeGOOGLE
    {
        public uint presentID;
        public ulong desiredPresentTime;
        public VkPresentTimeGOOGLE(uint presentID, ulong desiredPresentTime)
        {
            this.presentID = presentID;
            this.desiredPresentTime = desiredPresentTime;
        }
    }
    public unsafe struct VkIOSSurfaceCreateInfoMVK
    {
        public VkStructureType sType = VkStructureType.StructureTypeIosSurfaceCreateInfoMvk;
        public void* pNext;
        public VkIOSSurfaceCreateFlagsMVK flags;
        public void* pView;
        public VkIOSSurfaceCreateInfoMVK(VkStructureType sType, void* pNext, VkIOSSurfaceCreateFlagsMVK flags, void* pView)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pView = pView;
        }
    }
    public unsafe struct VkMacOSSurfaceCreateInfoMVK
    {
        public VkStructureType sType = VkStructureType.StructureTypeMacosSurfaceCreateInfoMvk;
        public void* pNext;
        public VkMacOSSurfaceCreateFlagsMVK flags;
        public void* pView;
        public VkMacOSSurfaceCreateInfoMVK(VkStructureType sType, void* pNext, VkMacOSSurfaceCreateFlagsMVK flags, void* pView)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pView = pView;
        }
    }
    public unsafe struct VkMetalSurfaceCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMetalSurfaceCreateInfoExt;
        public void* pNext;
        public VkMetalSurfaceCreateFlagsEXT flags;
        public IntPtr* pLayer;
        public VkMetalSurfaceCreateInfoEXT(VkStructureType sType, void* pNext, VkMetalSurfaceCreateFlagsEXT flags, IntPtr* pLayer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pLayer = pLayer;
        }
    }
    public unsafe struct VkViewportWScalingNV
    {
        public float xcoeff;
        public float ycoeff;
        public VkViewportWScalingNV(float xcoeff, float ycoeff)
        {
            this.xcoeff = xcoeff;
            this.ycoeff = ycoeff;
        }
    }
    public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineViewportWScalingStateCreateInfoNv;
        public void* pNext;
        public int viewportWScalingEnable;
        public uint viewportCount;
        public VkViewportWScalingNV* pViewportWScalings;
        public VkPipelineViewportWScalingStateCreateInfoNV(VkStructureType sType, void* pNext, int viewportWScalingEnable, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.viewportWScalingEnable = viewportWScalingEnable;
            this.viewportCount = viewportCount;
            this.pViewportWScalings = pViewportWScalings;
        }
    }
    public unsafe struct VkViewportSwizzleNV
    {
        public VkViewportCoordinateSwizzleNV x;
        public VkViewportCoordinateSwizzleNV y;
        public VkViewportCoordinateSwizzleNV z;
        public VkViewportCoordinateSwizzleNV w;
        public VkViewportSwizzleNV(VkViewportCoordinateSwizzleNV x, VkViewportCoordinateSwizzleNV y, VkViewportCoordinateSwizzleNV z, VkViewportCoordinateSwizzleNV w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
    public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineViewportSwizzleStateCreateInfoNv;
        public void* pNext;
        public VkPipelineViewportSwizzleStateCreateFlagsNV flags;
        public uint viewportCount;
        public VkViewportSwizzleNV* pViewportSwizzles;
        public VkPipelineViewportSwizzleStateCreateInfoNV(VkStructureType sType, void* pNext, VkPipelineViewportSwizzleStateCreateFlagsNV flags, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.viewportCount = viewportCount;
            this.pViewportSwizzles = pViewportSwizzles;
        }
    }
    public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDiscardRectanglePropertiesExt;
        public void* pNext;
        public uint maxDiscardRectangles;
        public VkPhysicalDeviceDiscardRectanglePropertiesEXT(VkStructureType sType, void* pNext, uint maxDiscardRectangles)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxDiscardRectangles = maxDiscardRectangles;
        }
    }
    public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineDiscardRectangleStateCreateInfoExt;
        public void* pNext;
        public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
        public VkDiscardRectangleModeEXT discardRectangleMode;
        public uint discardRectangleCount;
        public VkRect2D* pDiscardRectangles;
        public VkPipelineDiscardRectangleStateCreateInfoEXT(VkStructureType sType, void* pNext, VkPipelineDiscardRectangleStateCreateFlagsEXT flags, VkDiscardRectangleModeEXT discardRectangleMode, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.discardRectangleMode = discardRectangleMode;
            this.discardRectangleCount = discardRectangleCount;
            this.pDiscardRectangles = pDiscardRectangles;
        }
    }
    public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMultiviewPerViewAttributesPropertiesNvx;
        public void* pNext;
        public int perViewPositionAllComponents;
        public VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX(VkStructureType sType, void* pNext, int perViewPositionAllComponents)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.perViewPositionAllComponents = perViewPositionAllComponents;
        }
    }
    public unsafe struct VkInputAttachmentAspectReference
    {
        public uint subpass;
        public uint inputAttachmentIndex;
        public VkImageAspectFlagBits aspectMask;
        public VkInputAttachmentAspectReference(uint subpass, uint inputAttachmentIndex, VkImageAspectFlagBits aspectMask)
        {
            this.subpass = subpass;
            this.inputAttachmentIndex = inputAttachmentIndex;
            this.aspectMask = aspectMask;
        }
    }
    public unsafe struct VkInputAttachmentAspectReferenceKHR
    {
        public VkInputAttachmentAspectReferenceKHR()
        {
        }
    }
    public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassInputAttachmentAspectCreateInfo;
        public void* pNext;
        public uint aspectReferenceCount;
        public VkInputAttachmentAspectReference* pAspectReferences;
        public VkRenderPassInputAttachmentAspectCreateInfo(VkStructureType sType, void* pNext, uint aspectReferenceCount, VkInputAttachmentAspectReference* pAspectReferences)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.aspectReferenceCount = aspectReferenceCount;
            this.pAspectReferences = pAspectReferences;
        }
    }
    public unsafe struct VkRenderPassInputAttachmentAspectCreateInfoKHR
    {
        public VkRenderPassInputAttachmentAspectCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSurfaceInfo2Khr;
        public void* pNext;
        public VkSurfaceKHR surface;
        public VkPhysicalDeviceSurfaceInfo2KHR(VkStructureType sType, void* pNext, VkSurfaceKHR surface)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.surface = surface;
        }
    }
    public unsafe struct VkSurfaceCapabilities2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfaceCapabilities2Khr;
        public void* pNext;
        public VkSurfaceCapabilitiesKHR surfaceCapabilities;
        public VkSurfaceCapabilities2KHR(VkStructureType sType, void* pNext, VkSurfaceCapabilitiesKHR surfaceCapabilities)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.surfaceCapabilities = surfaceCapabilities;
        }
    }
    public unsafe struct VkSurfaceFormat2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfaceFormat2Khr;
        public void* pNext;
        public VkSurfaceFormatKHR surfaceFormat;
        public VkSurfaceFormat2KHR(VkStructureType sType, void* pNext, VkSurfaceFormatKHR surfaceFormat)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.surfaceFormat = surfaceFormat;
        }
    }
    public unsafe struct VkDisplayProperties2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayProperties2Khr;
        public void* pNext;
        public VkDisplayPropertiesKHR displayProperties;
        public VkDisplayProperties2KHR(VkStructureType sType, void* pNext, VkDisplayPropertiesKHR displayProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.displayProperties = displayProperties;
        }
    }
    public unsafe struct VkDisplayPlaneProperties2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayPlaneProperties2Khr;
        public void* pNext;
        public VkDisplayPlanePropertiesKHR displayPlaneProperties;
        public VkDisplayPlaneProperties2KHR(VkStructureType sType, void* pNext, VkDisplayPlanePropertiesKHR displayPlaneProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.displayPlaneProperties = displayPlaneProperties;
        }
    }
    public unsafe struct VkDisplayModeProperties2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayModeProperties2Khr;
        public void* pNext;
        public VkDisplayModePropertiesKHR displayModeProperties;
        public VkDisplayModeProperties2KHR(VkStructureType sType, void* pNext, VkDisplayModePropertiesKHR displayModeProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.displayModeProperties = displayModeProperties;
        }
    }
    public unsafe struct VkDisplayPlaneInfo2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayPlaneInfo2Khr;
        public void* pNext;
        public VkDisplayModeKHR mode;
        public uint planeIndex;
        public VkDisplayPlaneInfo2KHR(VkStructureType sType, void* pNext, VkDisplayModeKHR mode, uint planeIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.mode = mode;
            this.planeIndex = planeIndex;
        }
    }
    public unsafe struct VkDisplayPlaneCapabilities2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDisplayPlaneCapabilities2Khr;
        public void* pNext;
        public VkDisplayPlaneCapabilitiesKHR capabilities;
        public VkDisplayPlaneCapabilities2KHR(VkStructureType sType, void* pNext, VkDisplayPlaneCapabilitiesKHR capabilities)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.capabilities = capabilities;
        }
    }
    public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeSharedPresentSurfaceCapabilitiesKhr;
        public void* pNext;
        public VkImageUsageFlagBits sharedPresentSupportedUsageFlags;
        public VkSharedPresentSurfaceCapabilitiesKHR(VkStructureType sType, void* pNext, VkImageUsageFlagBits sharedPresentSupportedUsageFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sharedPresentSupportedUsageFlags = sharedPresentSupportedUsageFlags;
        }
    }
    public unsafe struct VkPhysicalDevice16BitStorageFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevice16bitStorageFeatures;
        public void* pNext;
        public int storageBuffer16BitAccess;
        public int uniformAndStorageBuffer16BitAccess;
        public int storagePushConstant16;
        public int storageInputOutput16;
        public VkPhysicalDevice16BitStorageFeatures(VkStructureType sType, void* pNext, int storageBuffer16BitAccess, int uniformAndStorageBuffer16BitAccess, int storagePushConstant16, int storageInputOutput16)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.storageBuffer16BitAccess = storageBuffer16BitAccess;
            this.uniformAndStorageBuffer16BitAccess = uniformAndStorageBuffer16BitAccess;
            this.storagePushConstant16 = storagePushConstant16;
            this.storageInputOutput16 = storageInputOutput16;
        }
    }
    public unsafe struct VkPhysicalDevice16BitStorageFeaturesKHR
    {
        public VkPhysicalDevice16BitStorageFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceSubgroupProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSubgroupProperties;
        public void* pNext;
        public uint subgroupSize;
        public VkShaderStageFlagBits supportedStages;
        public VkSubgroupFeatureFlagBits supportedOperations;
        public int quadOperationsInAllStages;
        public VkPhysicalDeviceSubgroupProperties(VkStructureType sType, void* pNext, uint subgroupSize, VkShaderStageFlagBits supportedStages, VkSubgroupFeatureFlagBits supportedOperations, int quadOperationsInAllStages)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.subgroupSize = subgroupSize;
            this.supportedStages = supportedStages;
            this.supportedOperations = supportedOperations;
            this.quadOperationsInAllStages = quadOperationsInAllStages;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeatures;
        public void* pNext;
        public int shaderSubgroupExtendedTypes;
        public VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures(VkStructureType sType, void* pNext, int shaderSubgroupExtendedTypes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderSubgroupExtendedTypes = shaderSubgroupExtendedTypes;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR
    {
        public VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR()
        {
        }
    }
    public unsafe struct VkBufferMemoryRequirementsInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferMemoryRequirementsInfo2;
        public void* pNext;
        public VkBuffer buffer;
        public VkBufferMemoryRequirementsInfo2(VkStructureType sType, void* pNext, VkBuffer buffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.buffer = buffer;
        }
    }
    public unsafe struct VkBufferMemoryRequirementsInfo2KHR
    {
        public VkBufferMemoryRequirementsInfo2KHR()
        {
        }
    }
    public unsafe struct VkDeviceBufferMemoryRequirements
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceBufferMemoryRequirements;
        public void* pNext;
        public VkBufferCreateInfo* pCreateInfo;
        public VkDeviceBufferMemoryRequirements(VkStructureType sType, void* pNext, VkBufferCreateInfo* pCreateInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pCreateInfo = pCreateInfo;
        }
    }
    public unsafe struct VkDeviceBufferMemoryRequirementsKHR
    {
        public VkDeviceBufferMemoryRequirementsKHR()
        {
        }
    }
    public unsafe struct VkImageMemoryRequirementsInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageMemoryRequirementsInfo2;
        public void* pNext;
        public VkImage image;
        public VkImageMemoryRequirementsInfo2(VkStructureType sType, void* pNext, VkImage image)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image = image;
        }
    }
    public unsafe struct VkImageMemoryRequirementsInfo2KHR
    {
        public VkImageMemoryRequirementsInfo2KHR()
        {
        }
    }
    public unsafe struct VkImageSparseMemoryRequirementsInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageSparseMemoryRequirementsInfo2;
        public void* pNext;
        public VkImage image;
        public VkImageSparseMemoryRequirementsInfo2(VkStructureType sType, void* pNext, VkImage image)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image = image;
        }
    }
    public unsafe struct VkImageSparseMemoryRequirementsInfo2KHR
    {
        public VkImageSparseMemoryRequirementsInfo2KHR()
        {
        }
    }
    public unsafe struct VkDeviceImageMemoryRequirements
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceImageMemoryRequirements;
        public void* pNext;
        public VkImageCreateInfo* pCreateInfo;
        public VkImageAspectFlagBits planeAspect;
        public VkDeviceImageMemoryRequirements(VkStructureType sType, void* pNext, VkImageCreateInfo* pCreateInfo, VkImageAspectFlagBits planeAspect)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pCreateInfo = pCreateInfo;
            this.planeAspect = planeAspect;
        }
    }
    public unsafe struct VkDeviceImageMemoryRequirementsKHR
    {
        public VkDeviceImageMemoryRequirementsKHR()
        {
        }
    }
    public unsafe struct VkMemoryRequirements2
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryRequirements2;
        public void* pNext;
        public VkMemoryRequirements memoryRequirements;
        public VkMemoryRequirements2(VkStructureType sType, void* pNext, VkMemoryRequirements memoryRequirements)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryRequirements = memoryRequirements;
        }
    }
    public unsafe struct VkMemoryRequirements2KHR
    {
        public VkMemoryRequirements2KHR()
        {
        }
    }
    public unsafe struct VkSparseImageMemoryRequirements2
    {
        public VkStructureType sType = VkStructureType.StructureTypeSparseImageMemoryRequirements2;
        public void* pNext;
        public VkSparseImageMemoryRequirements memoryRequirements;
        public VkSparseImageMemoryRequirements2(VkStructureType sType, void* pNext, VkSparseImageMemoryRequirements memoryRequirements)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryRequirements = memoryRequirements;
        }
    }
    public unsafe struct VkSparseImageMemoryRequirements2KHR
    {
        public VkSparseImageMemoryRequirements2KHR()
        {
        }
    }
    public unsafe struct VkPhysicalDevicePointClippingProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePointClippingProperties;
        public void* pNext;
        public VkPointClippingBehavior pointClippingBehavior;
        public VkPhysicalDevicePointClippingProperties(VkStructureType sType, void* pNext, VkPointClippingBehavior pointClippingBehavior)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pointClippingBehavior = pointClippingBehavior;
        }
    }
    public unsafe struct VkPhysicalDevicePointClippingPropertiesKHR
    {
        public VkPhysicalDevicePointClippingPropertiesKHR()
        {
        }
    }
    public unsafe struct VkMemoryDedicatedRequirements
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryDedicatedRequirements;
        public void* pNext;
        public int prefersDedicatedAllocation;
        public int requiresDedicatedAllocation;
        public VkMemoryDedicatedRequirements(VkStructureType sType, void* pNext, int prefersDedicatedAllocation, int requiresDedicatedAllocation)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.prefersDedicatedAllocation = prefersDedicatedAllocation;
            this.requiresDedicatedAllocation = requiresDedicatedAllocation;
        }
    }
    public unsafe struct VkMemoryDedicatedRequirementsKHR
    {
        public VkMemoryDedicatedRequirementsKHR()
        {
        }
    }
    public unsafe struct VkMemoryDedicatedAllocateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryDedicatedAllocateInfo;
        public void* pNext;
        public VkImage image;
        public VkBuffer buffer;
        public VkMemoryDedicatedAllocateInfo(VkStructureType sType, void* pNext, VkImage image, VkBuffer buffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image = image;
            this.buffer = buffer;
        }
    }
    public unsafe struct VkMemoryDedicatedAllocateInfoKHR
    {
        public VkMemoryDedicatedAllocateInfoKHR()
        {
        }
    }
    public unsafe struct VkImageViewUsageCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageViewUsageCreateInfo;
        public void* pNext;
        public VkImageUsageFlagBits usage;
        public VkImageViewUsageCreateInfo(VkStructureType sType, void* pNext, VkImageUsageFlagBits usage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.usage = usage;
        }
    }
    public unsafe struct VkImageViewSlicedCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageViewSlicedCreateInfoExt;
        public void* pNext;
        public uint sliceOffset;
        public uint sliceCount;
        public VkImageViewSlicedCreateInfoEXT(VkStructureType sType, void* pNext, uint sliceOffset, uint sliceCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sliceOffset = sliceOffset;
            this.sliceCount = sliceCount;
        }
    }
    public unsafe struct VkImageViewUsageCreateInfoKHR
    {
        public VkImageViewUsageCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineTessellationDomainOriginStateCreateInfo;
        public void* pNext;
        public VkTessellationDomainOrigin domainOrigin;
        public VkPipelineTessellationDomainOriginStateCreateInfo(VkStructureType sType, void* pNext, VkTessellationDomainOrigin domainOrigin)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.domainOrigin = domainOrigin;
        }
    }
    public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
    {
        public VkPipelineTessellationDomainOriginStateCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkSamplerYcbcrConversionInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerYcbcrConversionInfo;
        public void* pNext;
        public VkSamplerYcbcrConversion conversion;
        public VkSamplerYcbcrConversionInfo(VkStructureType sType, void* pNext, VkSamplerYcbcrConversion conversion)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.conversion = conversion;
        }
    }
    public unsafe struct VkSamplerYcbcrConversionInfoKHR
    {
        public VkSamplerYcbcrConversionInfoKHR()
        {
        }
    }
    public unsafe struct VkSamplerYcbcrConversionCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerYcbcrConversionCreateInfo;
        public void* pNext;
        public VkFormat format;
        public VkSamplerYcbcrModelConversion ycbcrModel;
        public VkSamplerYcbcrRange ycbcrRange;
        public VkComponentMapping components;
        public VkChromaLocation xChromaOffset;
        public VkChromaLocation yChromaOffset;
        public VkFilter chromaFilter;
        public int forceExplicitReconstruction;
        public VkSamplerYcbcrConversionCreateInfo(VkStructureType sType, void* pNext, VkFormat format, VkSamplerYcbcrModelConversion ycbcrModel, VkSamplerYcbcrRange ycbcrRange, VkComponentMapping components, VkChromaLocation xChromaOffset, VkChromaLocation yChromaOffset, VkFilter chromaFilter, int forceExplicitReconstruction)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.format = format;
            this.ycbcrModel = ycbcrModel;
            this.ycbcrRange = ycbcrRange;
            this.components = components;
            this.xChromaOffset = xChromaOffset;
            this.yChromaOffset = yChromaOffset;
            this.chromaFilter = chromaFilter;
            this.forceExplicitReconstruction = forceExplicitReconstruction;
        }
    }
    public unsafe struct VkSamplerYcbcrConversionCreateInfoKHR
    {
        public VkSamplerYcbcrConversionCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkBindImagePlaneMemoryInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindImagePlaneMemoryInfo;
        public void* pNext;
        public VkImageAspectFlagBits planeAspect;
        public VkBindImagePlaneMemoryInfo(VkStructureType sType, void* pNext, VkImageAspectFlagBits planeAspect)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.planeAspect = planeAspect;
        }
    }
    public unsafe struct VkBindImagePlaneMemoryInfoKHR
    {
        public VkBindImagePlaneMemoryInfoKHR()
        {
        }
    }
    public unsafe struct VkImagePlaneMemoryRequirementsInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeImagePlaneMemoryRequirementsInfo;
        public void* pNext;
        public VkImageAspectFlagBits planeAspect;
        public VkImagePlaneMemoryRequirementsInfo(VkStructureType sType, void* pNext, VkImageAspectFlagBits planeAspect)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.planeAspect = planeAspect;
        }
    }
    public unsafe struct VkImagePlaneMemoryRequirementsInfoKHR
    {
        public VkImagePlaneMemoryRequirementsInfoKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSamplerYcbcrConversionFeatures;
        public void* pNext;
        public int samplerYcbcrConversion;
        public VkPhysicalDeviceSamplerYcbcrConversionFeatures(VkStructureType sType, void* pNext, int samplerYcbcrConversion)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.samplerYcbcrConversion = samplerYcbcrConversion;
        }
    }
    public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
    {
        public VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR()
        {
        }
    }
    public unsafe struct VkSamplerYcbcrConversionImageFormatProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerYcbcrConversionImageFormatProperties;
        public void* pNext;
        public uint combinedImageSamplerDescriptorCount;
        public VkSamplerYcbcrConversionImageFormatProperties(VkStructureType sType, void* pNext, uint combinedImageSamplerDescriptorCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.combinedImageSamplerDescriptorCount = combinedImageSamplerDescriptorCount;
        }
    }
    public unsafe struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
    {
        public VkSamplerYcbcrConversionImageFormatPropertiesKHR()
        {
        }
    }
    public unsafe struct VkTextureLODGatherFormatPropertiesAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypeTextureLodGatherFormatPropertiesAmd;
        public void* pNext;
        public int supportsTextureGatherLODBiasAMD;
        public VkTextureLODGatherFormatPropertiesAMD(VkStructureType sType, void* pNext, int supportsTextureGatherLODBiasAMD)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.supportsTextureGatherLODBiasAMD = supportsTextureGatherLODBiasAMD;
        }
    }
    public unsafe struct VkConditionalRenderingBeginInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeConditionalRenderingBeginInfoExt;
        public void* pNext;
        public VkBuffer buffer;
        public ulong offset;
        public VkConditionalRenderingFlagBitsEXT flags;
        public VkConditionalRenderingBeginInfoEXT(VkStructureType sType, void* pNext, VkBuffer buffer, ulong offset, VkConditionalRenderingFlagBitsEXT flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.buffer = buffer;
            this.offset = offset;
            this.flags = flags;
        }
    }
    public unsafe struct VkProtectedSubmitInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeProtectedSubmitInfo;
        public void* pNext;
        public int protectedSubmit;
        public VkProtectedSubmitInfo(VkStructureType sType, void* pNext, int protectedSubmit)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.protectedSubmit = protectedSubmit;
        }
    }
    public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceProtectedMemoryFeatures;
        public void* pNext;
        public int protectedMemory;
        public VkPhysicalDeviceProtectedMemoryFeatures(VkStructureType sType, void* pNext, int protectedMemory)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.protectedMemory = protectedMemory;
        }
    }
    public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceProtectedMemoryProperties;
        public void* pNext;
        public int protectedNoFault;
        public VkPhysicalDeviceProtectedMemoryProperties(VkStructureType sType, void* pNext, int protectedNoFault)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.protectedNoFault = protectedNoFault;
        }
    }
    public unsafe struct VkDeviceQueueInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceQueueInfo2;
        public void* pNext;
        public VkDeviceQueueCreateFlagBits flags;
        public uint queueFamilyIndex;
        public uint queueIndex;
        public VkDeviceQueueInfo2(VkStructureType sType, void* pNext, VkDeviceQueueCreateFlagBits flags, uint queueFamilyIndex, uint queueIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.queueFamilyIndex = queueFamilyIndex;
            this.queueIndex = queueIndex;
        }
    }
    public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineCoverageToColorStateCreateInfoNv;
        public void* pNext;
        public VkPipelineCoverageToColorStateCreateFlagsNV flags;
        public int coverageToColorEnable;
        public uint coverageToColorLocation;
        public VkPipelineCoverageToColorStateCreateInfoNV(VkStructureType sType, void* pNext, VkPipelineCoverageToColorStateCreateFlagsNV flags, int coverageToColorEnable, uint coverageToColorLocation)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.coverageToColorEnable = coverageToColorEnable;
            this.coverageToColorLocation = coverageToColorLocation;
        }
    }
    public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSamplerFilterMinmaxProperties;
        public void* pNext;
        public int filterMinmaxSingleComponentFormats;
        public int filterMinmaxImageComponentMapping;
        public VkPhysicalDeviceSamplerFilterMinmaxProperties(VkStructureType sType, void* pNext, int filterMinmaxSingleComponentFormats, int filterMinmaxImageComponentMapping)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.filterMinmaxSingleComponentFormats = filterMinmaxSingleComponentFormats;
            this.filterMinmaxImageComponentMapping = filterMinmaxImageComponentMapping;
        }
    }
    public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
    {
        public VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT()
        {
        }
    }
    public unsafe struct VkSampleLocationEXT
    {
        public float x;
        public float y;
        public VkSampleLocationEXT(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public unsafe struct VkSampleLocationsInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSampleLocationsInfoExt;
        public void* pNext;
        public VkSampleCountFlagBits sampleLocationsPerPixel;
        public VkExtent2D sampleLocationGridSize;
        public uint sampleLocationsCount;
        public VkSampleLocationEXT* pSampleLocations;
        public VkSampleLocationsInfoEXT(VkStructureType sType, void* pNext, VkSampleCountFlagBits sampleLocationsPerPixel, VkExtent2D sampleLocationGridSize, uint sampleLocationsCount, VkSampleLocationEXT* pSampleLocations)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sampleLocationsPerPixel = sampleLocationsPerPixel;
            this.sampleLocationGridSize = sampleLocationGridSize;
            this.sampleLocationsCount = sampleLocationsCount;
            this.pSampleLocations = pSampleLocations;
        }
    }
    public unsafe struct VkAttachmentSampleLocationsEXT
    {
        public uint attachmentIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
        public VkAttachmentSampleLocationsEXT(uint attachmentIndex, VkSampleLocationsInfoEXT sampleLocationsInfo)
        {
            this.attachmentIndex = attachmentIndex;
            this.sampleLocationsInfo = sampleLocationsInfo;
        }
    }
    public unsafe struct VkSubpassSampleLocationsEXT
    {
        public uint subpassIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
        public VkSubpassSampleLocationsEXT(uint subpassIndex, VkSampleLocationsInfoEXT sampleLocationsInfo)
        {
            this.subpassIndex = subpassIndex;
            this.sampleLocationsInfo = sampleLocationsInfo;
        }
    }
    public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassSampleLocationsBeginInfoExt;
        public void* pNext;
        public uint attachmentInitialSampleLocationsCount;
        public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
        public uint postSubpassSampleLocationsCount;
        public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
        public VkRenderPassSampleLocationsBeginInfoEXT(VkStructureType sType, void* pNext, uint attachmentInitialSampleLocationsCount, VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations, uint postSubpassSampleLocationsCount, VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.attachmentInitialSampleLocationsCount = attachmentInitialSampleLocationsCount;
            this.pAttachmentInitialSampleLocations = pAttachmentInitialSampleLocations;
            this.postSubpassSampleLocationsCount = postSubpassSampleLocationsCount;
            this.pPostSubpassSampleLocations = pPostSubpassSampleLocations;
        }
    }
    public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineSampleLocationsStateCreateInfoExt;
        public void* pNext;
        public int sampleLocationsEnable;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
        public VkPipelineSampleLocationsStateCreateInfoEXT(VkStructureType sType, void* pNext, int sampleLocationsEnable, VkSampleLocationsInfoEXT sampleLocationsInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sampleLocationsEnable = sampleLocationsEnable;
            this.sampleLocationsInfo = sampleLocationsInfo;
        }
    }
    public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSampleLocationsPropertiesExt;
        public void* pNext;
        public VkSampleCountFlagBits sampleLocationSampleCounts;
        public VkExtent2D maxSampleLocationGridSize;
        public fixed float sampleLocationCoordinateRange[2];
        public uint sampleLocationSubPixelBits;
        public int variableSampleLocations;
        public VkPhysicalDeviceSampleLocationsPropertiesEXT(){ }
    }
    public unsafe struct VkMultisamplePropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMultisamplePropertiesExt;
        public void* pNext;
        public VkExtent2D maxSampleLocationGridSize;
        public VkMultisamplePropertiesEXT(VkStructureType sType, void* pNext, VkExtent2D maxSampleLocationGridSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxSampleLocationGridSize = maxSampleLocationGridSize;
        }
    }
    public unsafe struct VkSamplerReductionModeCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerReductionModeCreateInfo;
        public void* pNext;
        public VkSamplerReductionMode reductionMode;
        public VkSamplerReductionModeCreateInfo(VkStructureType sType, void* pNext, VkSamplerReductionMode reductionMode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.reductionMode = reductionMode;
        }
    }
    public unsafe struct VkSamplerReductionModeCreateInfoEXT
    {
        public VkSamplerReductionModeCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceBlendOperationAdvancedFeaturesExt;
        public void* pNext;
        public int advancedBlendCoherentOperations;
        public VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT(VkStructureType sType, void* pNext, int advancedBlendCoherentOperations)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.advancedBlendCoherentOperations = advancedBlendCoherentOperations;
        }
    }
    public unsafe struct VkPhysicalDeviceMultiDrawFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMultiDrawFeaturesExt;
        public void* pNext;
        public int multiDraw;
        public VkPhysicalDeviceMultiDrawFeaturesEXT(VkStructureType sType, void* pNext, int multiDraw)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.multiDraw = multiDraw;
        }
    }
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceBlendOperationAdvancedPropertiesExt;
        public void* pNext;
        public uint advancedBlendMaxColorAttachments;
        public int advancedBlendIndependentBlend;
        public int advancedBlendNonPremultipliedSrcColor;
        public int advancedBlendNonPremultipliedDstColor;
        public int advancedBlendCorrelatedOverlap;
        public int advancedBlendAllOperations;
        public VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT(VkStructureType sType, void* pNext, uint advancedBlendMaxColorAttachments, int advancedBlendIndependentBlend, int advancedBlendNonPremultipliedSrcColor, int advancedBlendNonPremultipliedDstColor, int advancedBlendCorrelatedOverlap, int advancedBlendAllOperations)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.advancedBlendMaxColorAttachments = advancedBlendMaxColorAttachments;
            this.advancedBlendIndependentBlend = advancedBlendIndependentBlend;
            this.advancedBlendNonPremultipliedSrcColor = advancedBlendNonPremultipliedSrcColor;
            this.advancedBlendNonPremultipliedDstColor = advancedBlendNonPremultipliedDstColor;
            this.advancedBlendCorrelatedOverlap = advancedBlendCorrelatedOverlap;
            this.advancedBlendAllOperations = advancedBlendAllOperations;
        }
    }
    public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineColorBlendAdvancedStateCreateInfoExt;
        public void* pNext;
        public int srcPremultiplied;
        public int dstPremultiplied;
        public VkBlendOverlapEXT blendOverlap;
        public VkPipelineColorBlendAdvancedStateCreateInfoEXT(VkStructureType sType, void* pNext, int srcPremultiplied, int dstPremultiplied, VkBlendOverlapEXT blendOverlap)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcPremultiplied = srcPremultiplied;
            this.dstPremultiplied = dstPremultiplied;
            this.blendOverlap = blendOverlap;
        }
    }
    public unsafe struct VkPhysicalDeviceInlineUniformBlockFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceInlineUniformBlockFeatures;
        public void* pNext;
        public int inlineUniformBlock;
        public int descriptorBindingInlineUniformBlockUpdateAfterBind;
        public VkPhysicalDeviceInlineUniformBlockFeatures(VkStructureType sType, void* pNext, int inlineUniformBlock, int descriptorBindingInlineUniformBlockUpdateAfterBind)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.inlineUniformBlock = inlineUniformBlock;
            this.descriptorBindingInlineUniformBlockUpdateAfterBind = descriptorBindingInlineUniformBlockUpdateAfterBind;
        }
    }
    public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
    {
        public VkPhysicalDeviceInlineUniformBlockFeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceInlineUniformBlockProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceInlineUniformBlockProperties;
        public void* pNext;
        public uint maxInlineUniformBlockSize;
        public uint maxPerStageDescriptorInlineUniformBlocks;
        public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint maxDescriptorSetInlineUniformBlocks;
        public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        public VkPhysicalDeviceInlineUniformBlockProperties(VkStructureType sType, void* pNext, uint maxInlineUniformBlockSize, uint maxPerStageDescriptorInlineUniformBlocks, uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks, uint maxDescriptorSetInlineUniformBlocks, uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxInlineUniformBlockSize = maxInlineUniformBlockSize;
            this.maxPerStageDescriptorInlineUniformBlocks = maxPerStageDescriptorInlineUniformBlocks;
            this.maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
            this.maxDescriptorSetInlineUniformBlocks = maxDescriptorSetInlineUniformBlocks;
            this.maxDescriptorSetUpdateAfterBindInlineUniformBlocks = maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        }
    }
    public unsafe struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
    {
        public VkPhysicalDeviceInlineUniformBlockPropertiesEXT()
        {
        }
    }
    public unsafe struct VkWriteDescriptorSetInlineUniformBlock
    {
        public VkStructureType sType = VkStructureType.StructureTypeWriteDescriptorSetInlineUniformBlock;
        public void* pNext;
        public uint dataSize;
        public void* pData;
        public VkWriteDescriptorSetInlineUniformBlock(VkStructureType sType, void* pNext, uint dataSize, void* pData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dataSize = dataSize;
            this.pData = pData;
        }
    }
    public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT
    {
        public VkWriteDescriptorSetInlineUniformBlockEXT()
        {
        }
    }
    public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorPoolInlineUniformBlockCreateInfo;
        public void* pNext;
        public uint maxInlineUniformBlockBindings;
        public VkDescriptorPoolInlineUniformBlockCreateInfo(VkStructureType sType, void* pNext, uint maxInlineUniformBlockBindings)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxInlineUniformBlockBindings = maxInlineUniformBlockBindings;
        }
    }
    public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
    {
        public VkDescriptorPoolInlineUniformBlockCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineCoverageModulationStateCreateInfoNv;
        public void* pNext;
        public VkPipelineCoverageModulationStateCreateFlagsNV flags;
        public VkCoverageModulationModeNV coverageModulationMode;
        public int coverageModulationTableEnable;
        public uint coverageModulationTableCount;
        public float* pCoverageModulationTable;
        public VkPipelineCoverageModulationStateCreateInfoNV(VkStructureType sType, void* pNext, VkPipelineCoverageModulationStateCreateFlagsNV flags, VkCoverageModulationModeNV coverageModulationMode, int coverageModulationTableEnable, uint coverageModulationTableCount, float* pCoverageModulationTable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.coverageModulationMode = coverageModulationMode;
            this.coverageModulationTableEnable = coverageModulationTableEnable;
            this.coverageModulationTableCount = coverageModulationTableCount;
            this.pCoverageModulationTable = pCoverageModulationTable;
        }
    }
    public unsafe struct VkImageFormatListCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageFormatListCreateInfo;
        public void* pNext;
        public uint viewFormatCount;
        public VkFormat* pViewFormats;
        public VkImageFormatListCreateInfo(VkStructureType sType, void* pNext, uint viewFormatCount, VkFormat* pViewFormats)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.viewFormatCount = viewFormatCount;
            this.pViewFormats = pViewFormats;
        }
    }
    public unsafe struct VkImageFormatListCreateInfoKHR
    {
        public VkImageFormatListCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkValidationCacheCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeValidationCacheCreateInfoExt;
        public void* pNext;
        public VkValidationCacheCreateFlagsEXT flags;
        public nuint initialDataSize;
        public void* pInitialData;
        public VkValidationCacheCreateInfoEXT(VkStructureType sType, void* pNext, VkValidationCacheCreateFlagsEXT flags, nuint initialDataSize, void* pInitialData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.initialDataSize = initialDataSize;
            this.pInitialData = pInitialData;
        }
    }
    public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeShaderModuleValidationCacheCreateInfoExt;
        public void* pNext;
        public VkValidationCacheEXT validationCache;
        public VkShaderModuleValidationCacheCreateInfoEXT(VkStructureType sType, void* pNext, VkValidationCacheEXT validationCache)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.validationCache = validationCache;
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance3Properties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMaintenance3Properties;
        public void* pNext;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
        public VkPhysicalDeviceMaintenance3Properties(VkStructureType sType, void* pNext, uint maxPerSetDescriptors, ulong maxMemoryAllocationSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxPerSetDescriptors = maxPerSetDescriptors;
            this.maxMemoryAllocationSize = maxMemoryAllocationSize;
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance3PropertiesKHR
    {
        public VkPhysicalDeviceMaintenance3PropertiesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance4Features
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMaintenance4Features;
        public void* pNext;
        public int maintenance4;
        public VkPhysicalDeviceMaintenance4Features(VkStructureType sType, void* pNext, int maintenance4)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maintenance4 = maintenance4;
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance4FeaturesKHR
    {
        public VkPhysicalDeviceMaintenance4FeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance4Properties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMaintenance4Properties;
        public void* pNext;
        public ulong maxBufferSize;
        public VkPhysicalDeviceMaintenance4Properties(VkStructureType sType, void* pNext, ulong maxBufferSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxBufferSize = maxBufferSize;
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance4PropertiesKHR
    {
        public VkPhysicalDeviceMaintenance4PropertiesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance5FeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMaintenance5FeaturesKhr;
        public void* pNext;
        public int maintenance5;
        public VkPhysicalDeviceMaintenance5FeaturesKHR(VkStructureType sType, void* pNext, int maintenance5)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maintenance5 = maintenance5;
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance5PropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMaintenance5PropertiesKhr;
        public void* pNext;
        public int earlyFragmentMultisampleCoverageAfterSampleCounting;
        public int earlyFragmentSampleMaskTestBeforeSampleCounting;
        public int depthStencilSwizzleOneSupport;
        public int polygonModePointSize;
        public int nonStrictSinglePixelWideLinesUseParallelogram;
        public int nonStrictWideLinesUseParallelogram;
        public VkPhysicalDeviceMaintenance5PropertiesKHR(VkStructureType sType, void* pNext, int earlyFragmentMultisampleCoverageAfterSampleCounting, int earlyFragmentSampleMaskTestBeforeSampleCounting, int depthStencilSwizzleOneSupport, int polygonModePointSize, int nonStrictSinglePixelWideLinesUseParallelogram, int nonStrictWideLinesUseParallelogram)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.earlyFragmentMultisampleCoverageAfterSampleCounting = earlyFragmentMultisampleCoverageAfterSampleCounting;
            this.earlyFragmentSampleMaskTestBeforeSampleCounting = earlyFragmentSampleMaskTestBeforeSampleCounting;
            this.depthStencilSwizzleOneSupport = depthStencilSwizzleOneSupport;
            this.polygonModePointSize = polygonModePointSize;
            this.nonStrictSinglePixelWideLinesUseParallelogram = nonStrictSinglePixelWideLinesUseParallelogram;
            this.nonStrictWideLinesUseParallelogram = nonStrictWideLinesUseParallelogram;
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance6FeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMaintenance6FeaturesKhr;
        public void* pNext;
        public int maintenance6;
        public VkPhysicalDeviceMaintenance6FeaturesKHR(VkStructureType sType, void* pNext, int maintenance6)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maintenance6 = maintenance6;
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance6PropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMaintenance6PropertiesKhr;
        public void* pNext;
        public int blockTexelViewCompatibleMultipleLayers;
        public uint maxCombinedImageSamplerDescriptorCount;
        public int fragmentShadingRateClampCombinerInputs;
        public VkPhysicalDeviceMaintenance6PropertiesKHR(VkStructureType sType, void* pNext, int blockTexelViewCompatibleMultipleLayers, uint maxCombinedImageSamplerDescriptorCount, int fragmentShadingRateClampCombinerInputs)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.blockTexelViewCompatibleMultipleLayers = blockTexelViewCompatibleMultipleLayers;
            this.maxCombinedImageSamplerDescriptorCount = maxCombinedImageSamplerDescriptorCount;
            this.fragmentShadingRateClampCombinerInputs = fragmentShadingRateClampCombinerInputs;
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance7FeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMaintenance7FeaturesKhr;
        public void* pNext;
        public int maintenance7;
        public VkPhysicalDeviceMaintenance7FeaturesKHR(VkStructureType sType, void* pNext, int maintenance7)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maintenance7 = maintenance7;
        }
    }
    public unsafe struct VkPhysicalDeviceMaintenance7PropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMaintenance7PropertiesKhr;
        public void* pNext;
        public int robustFragmentShadingRateAttachmentAccess;
        public int separateDepthStencilAttachmentAccess;
        public uint maxDescriptorSetTotalUniformBuffersDynamic;
        public uint maxDescriptorSetTotalStorageBuffersDynamic;
        public uint maxDescriptorSetTotalBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
        public VkPhysicalDeviceMaintenance7PropertiesKHR(VkStructureType sType, void* pNext, int robustFragmentShadingRateAttachmentAccess, int separateDepthStencilAttachmentAccess, uint maxDescriptorSetTotalUniformBuffersDynamic, uint maxDescriptorSetTotalStorageBuffersDynamic, uint maxDescriptorSetTotalBuffersDynamic, uint maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic, uint maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic, uint maxDescriptorSetUpdateAfterBindTotalBuffersDynamic)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.robustFragmentShadingRateAttachmentAccess = robustFragmentShadingRateAttachmentAccess;
            this.separateDepthStencilAttachmentAccess = separateDepthStencilAttachmentAccess;
            this.maxDescriptorSetTotalUniformBuffersDynamic = maxDescriptorSetTotalUniformBuffersDynamic;
            this.maxDescriptorSetTotalStorageBuffersDynamic = maxDescriptorSetTotalStorageBuffersDynamic;
            this.maxDescriptorSetTotalBuffersDynamic = maxDescriptorSetTotalBuffersDynamic;
            this.maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic = maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;
            this.maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic = maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;
            this.maxDescriptorSetUpdateAfterBindTotalBuffersDynamic = maxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
        }
    }
    public unsafe struct VkPhysicalDeviceLayeredApiPropertiesListKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLayeredApiPropertiesListKhr;
        public void* pNext;
        public uint layeredApiCount;
        public VkPhysicalDeviceLayeredApiPropertiesKHR* pLayeredApis;
        public VkPhysicalDeviceLayeredApiPropertiesListKHR(VkStructureType sType, void* pNext, uint layeredApiCount, VkPhysicalDeviceLayeredApiPropertiesKHR* pLayeredApis)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.layeredApiCount = layeredApiCount;
            this.pLayeredApis = pLayeredApis;
        }
    }
    public unsafe struct VkPhysicalDeviceLayeredApiPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLayeredApiPropertiesKhr;
        public void* pNext;
        public uint vendorID;
        public uint deviceID;
        public VkPhysicalDeviceLayeredApiKHR layeredAPI;
        [InlineArray(256)]
        public struct deviceNameInlineArray1
        {
            public byte element;
        }
        public deviceNameInlineArray1 deviceName;
        public VkPhysicalDeviceLayeredApiPropertiesKHR(){ }
    }
    public unsafe struct VkPhysicalDeviceLayeredApiVulkanPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLayeredApiVulkanPropertiesKhr;
        public void* pNext;
        public VkPhysicalDeviceProperties2 properties;
        public VkPhysicalDeviceLayeredApiVulkanPropertiesKHR(VkStructureType sType, void* pNext, VkPhysicalDeviceProperties2 properties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.properties = properties;
        }
    }
    public unsafe struct VkRenderingAreaInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderingAreaInfoKhr;
        public void* pNext;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
        public VkRenderingAreaInfoKHR(VkStructureType sType, void* pNext, uint viewMask, uint colorAttachmentCount, VkFormat* pColorAttachmentFormats, VkFormat depthAttachmentFormat, VkFormat stencilAttachmentFormat)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.viewMask = viewMask;
            this.colorAttachmentCount = colorAttachmentCount;
            this.pColorAttachmentFormats = pColorAttachmentFormats;
            this.depthAttachmentFormat = depthAttachmentFormat;
            this.stencilAttachmentFormat = stencilAttachmentFormat;
        }
    }
    public unsafe struct VkDescriptorSetLayoutSupport
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorSetLayoutSupport;
        public void* pNext;
        public int supported;
        public VkDescriptorSetLayoutSupport(VkStructureType sType, void* pNext, int supported)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.supported = supported;
        }
    }
    public unsafe struct VkDescriptorSetLayoutSupportKHR
    {
        public VkDescriptorSetLayoutSupportKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderDrawParametersFeatures;
        public void* pNext;
        public int shaderDrawParameters;
        public VkPhysicalDeviceShaderDrawParametersFeatures(VkStructureType sType, void* pNext, int shaderDrawParameters)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderDrawParameters = shaderDrawParameters;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderDrawParameterFeatures
    {
        public VkPhysicalDeviceShaderDrawParameterFeatures()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderFloat16Int8Features;
        public void* pNext;
        public int shaderFloat16;
        public int shaderInt8;
        public VkPhysicalDeviceShaderFloat16Int8Features(VkStructureType sType, void* pNext, int shaderFloat16, int shaderInt8)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderFloat16 = shaderFloat16;
            this.shaderInt8 = shaderInt8;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderFloat16Int8FeaturesKHR
    {
        public VkPhysicalDeviceShaderFloat16Int8FeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceFloat16Int8FeaturesKHR
    {
        public VkPhysicalDeviceFloat16Int8FeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFloatControlsProperties;
        public void* pNext;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public int shaderSignedZeroInfNanPreserveFloat16;
        public int shaderSignedZeroInfNanPreserveFloat32;
        public int shaderSignedZeroInfNanPreserveFloat64;
        public int shaderDenormPreserveFloat16;
        public int shaderDenormPreserveFloat32;
        public int shaderDenormPreserveFloat64;
        public int shaderDenormFlushToZeroFloat16;
        public int shaderDenormFlushToZeroFloat32;
        public int shaderDenormFlushToZeroFloat64;
        public int shaderRoundingModeRTEFloat16;
        public int shaderRoundingModeRTEFloat32;
        public int shaderRoundingModeRTEFloat64;
        public int shaderRoundingModeRTZFloat16;
        public int shaderRoundingModeRTZFloat32;
        public int shaderRoundingModeRTZFloat64;
        public VkPhysicalDeviceFloatControlsProperties(VkStructureType sType, void* pNext, VkShaderFloatControlsIndependence denormBehaviorIndependence, VkShaderFloatControlsIndependence roundingModeIndependence, int shaderSignedZeroInfNanPreserveFloat16, int shaderSignedZeroInfNanPreserveFloat32, int shaderSignedZeroInfNanPreserveFloat64, int shaderDenormPreserveFloat16, int shaderDenormPreserveFloat32, int shaderDenormPreserveFloat64, int shaderDenormFlushToZeroFloat16, int shaderDenormFlushToZeroFloat32, int shaderDenormFlushToZeroFloat64, int shaderRoundingModeRTEFloat16, int shaderRoundingModeRTEFloat32, int shaderRoundingModeRTEFloat64, int shaderRoundingModeRTZFloat16, int shaderRoundingModeRTZFloat32, int shaderRoundingModeRTZFloat64)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.denormBehaviorIndependence = denormBehaviorIndependence;
            this.roundingModeIndependence = roundingModeIndependence;
            this.shaderSignedZeroInfNanPreserveFloat16 = shaderSignedZeroInfNanPreserveFloat16;
            this.shaderSignedZeroInfNanPreserveFloat32 = shaderSignedZeroInfNanPreserveFloat32;
            this.shaderSignedZeroInfNanPreserveFloat64 = shaderSignedZeroInfNanPreserveFloat64;
            this.shaderDenormPreserveFloat16 = shaderDenormPreserveFloat16;
            this.shaderDenormPreserveFloat32 = shaderDenormPreserveFloat32;
            this.shaderDenormPreserveFloat64 = shaderDenormPreserveFloat64;
            this.shaderDenormFlushToZeroFloat16 = shaderDenormFlushToZeroFloat16;
            this.shaderDenormFlushToZeroFloat32 = shaderDenormFlushToZeroFloat32;
            this.shaderDenormFlushToZeroFloat64 = shaderDenormFlushToZeroFloat64;
            this.shaderRoundingModeRTEFloat16 = shaderRoundingModeRTEFloat16;
            this.shaderRoundingModeRTEFloat32 = shaderRoundingModeRTEFloat32;
            this.shaderRoundingModeRTEFloat64 = shaderRoundingModeRTEFloat64;
            this.shaderRoundingModeRTZFloat16 = shaderRoundingModeRTZFloat16;
            this.shaderRoundingModeRTZFloat32 = shaderRoundingModeRTZFloat32;
            this.shaderRoundingModeRTZFloat64 = shaderRoundingModeRTZFloat64;
        }
    }
    public unsafe struct VkPhysicalDeviceFloatControlsPropertiesKHR
    {
        public VkPhysicalDeviceFloatControlsPropertiesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceHostQueryResetFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceHostQueryResetFeatures;
        public void* pNext;
        public int hostQueryReset;
        public VkPhysicalDeviceHostQueryResetFeatures(VkStructureType sType, void* pNext, int hostQueryReset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.hostQueryReset = hostQueryReset;
        }
    }
    public unsafe struct VkPhysicalDeviceHostQueryResetFeaturesEXT
    {
        public VkPhysicalDeviceHostQueryResetFeaturesEXT()
        {
        }
    }
    public unsafe struct VkNativeBufferUsage2ANDROID
    {
        public ulong consumer;
        public ulong producer;
        public VkNativeBufferUsage2ANDROID(ulong consumer, ulong producer)
        {
            this.consumer = consumer;
            this.producer = producer;
        }
    }
    public unsafe struct VkNativeBufferANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public void* handle;
        public int stride;
        public int format;
        public int usage;
        public VkNativeBufferUsage2ANDROID usage2;
        public VkNativeBufferANDROID(VkStructureType sType, void* pNext, void* handle, int stride, int format, int usage, VkNativeBufferUsage2ANDROID usage2)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handle = handle;
            this.stride = stride;
            this.format = format;
            this.usage = usage;
            this.usage2 = usage2;
        }
    }
    public unsafe struct VkSwapchainImageCreateInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainImageUsageFlagBitsANDROID usage;
        public VkSwapchainImageCreateInfoANDROID(VkStructureType sType, void* pNext, VkSwapchainImageUsageFlagBitsANDROID usage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.usage = usage;
        }
    }
    public unsafe struct VkPhysicalDevicePresentationPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public int sharedImage;
        public VkPhysicalDevicePresentationPropertiesANDROID(VkStructureType sType, void* pNext, int sharedImage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sharedImage = sharedImage;
        }
    }
    public unsafe struct VkShaderResourceUsageAMD
    {
        public uint numUsedVgprs;
        public uint numUsedSgprs;
        public uint ldsSizePerLocalWorkGroup;
        public nuint ldsUsageSizeInBytes;
        public nuint scratchMemUsageInBytes;
        public VkShaderResourceUsageAMD(uint numUsedVgprs, uint numUsedSgprs, uint ldsSizePerLocalWorkGroup, nuint ldsUsageSizeInBytes, nuint scratchMemUsageInBytes)
        {
            this.numUsedVgprs = numUsedVgprs;
            this.numUsedSgprs = numUsedSgprs;
            this.ldsSizePerLocalWorkGroup = ldsSizePerLocalWorkGroup;
            this.ldsUsageSizeInBytes = ldsUsageSizeInBytes;
            this.scratchMemUsageInBytes = scratchMemUsageInBytes;
        }
    }
    public unsafe struct VkShaderStatisticsInfoAMD
    {
        public VkShaderStageFlagBits shaderStageMask;
        public VkShaderResourceUsageAMD resourceUsage;
        public uint numPhysicalVgprs;
        public uint numPhysicalSgprs;
        public uint numAvailableVgprs;
        public uint numAvailableSgprs;
        public fixed uint computeWorkGroupSize[3];
    }
    public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceQueueGlobalPriorityCreateInfoKhr;
        public void* pNext;
        public VkQueueGlobalPriorityKHR globalPriority;
        public VkDeviceQueueGlobalPriorityCreateInfoKHR(VkStructureType sType, void* pNext, VkQueueGlobalPriorityKHR globalPriority)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.globalPriority = globalPriority;
        }
    }
    public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
    {
        public VkDeviceQueueGlobalPriorityCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceGlobalPriorityQueryFeaturesKhr;
        public void* pNext;
        public int globalPriorityQuery;
        public VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR(VkStructureType sType, void* pNext, int globalPriorityQuery)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.globalPriorityQuery = globalPriorityQuery;
        }
    }
    public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT
    {
        public VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT()
        {
        }
    }
    public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueueFamilyGlobalPriorityPropertiesKhr;
        public void* pNext;
        public uint priorityCount;
        [InlineArray(16)]
        public struct prioritiesInlineArray1
        {
            public VkQueueGlobalPriorityKHR element;
        }
        public prioritiesInlineArray1 priorities;
        public VkQueueFamilyGlobalPriorityPropertiesKHR(){ }
    }
    public unsafe struct VkQueueFamilyGlobalPriorityPropertiesEXT
    {
        public VkQueueFamilyGlobalPriorityPropertiesEXT()
        {
        }
    }
    public unsafe struct VkDebugUtilsObjectNameInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDebugUtilsObjectNameInfoExt;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public byte* pObjectName;
        public VkDebugUtilsObjectNameInfoEXT(VkStructureType sType, void* pNext, VkObjectType objectType, ulong objectHandle, byte* pObjectName)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.objectType = objectType;
            this.objectHandle = objectHandle;
            this.pObjectName = pObjectName;
        }
    }
    public unsafe struct VkDebugUtilsObjectTagInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDebugUtilsObjectTagInfoExt;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public ulong tagName;
        public nuint tagSize;
        public void* pTag;
        public VkDebugUtilsObjectTagInfoEXT(VkStructureType sType, void* pNext, VkObjectType objectType, ulong objectHandle, ulong tagName, nuint tagSize, void* pTag)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.objectType = objectType;
            this.objectHandle = objectHandle;
            this.tagName = tagName;
            this.tagSize = tagSize;
            this.pTag = pTag;
        }
    }
    public unsafe struct VkDebugUtilsLabelEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDebugUtilsLabelExt;
        public void* pNext;
        public byte* pLabelName;
        public fixed float color[4];
        public VkDebugUtilsLabelEXT(){ }
    }
    public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDebugUtilsMessengerCreateInfoExt;
        public void* pNext;
        public VkDebugUtilsMessengerCreateFlagsEXT flags;
        public VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity;
        public VkDebugUtilsMessageTypeFlagBitsEXT messageType;
        public delegate* unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagBitsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, int> pfnUserCallback;
        public void* pUserData;
        public VkDebugUtilsMessengerCreateInfoEXT(VkStructureType sType, void* pNext, VkDebugUtilsMessengerCreateFlagsEXT flags, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagBitsEXT messageType, delegate* unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagBitsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, int> pfnUserCallback, void* pUserData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.messageSeverity = messageSeverity;
            this.messageType = messageType;
            this.pfnUserCallback = pfnUserCallback;
            this.pUserData = pUserData;
        }
    }
    public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDebugUtilsMessengerCallbackDataExt;
        public void* pNext;
        public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
        public byte* pMessageIdName;
        public int messageIdNumber;
        public byte* pMessage;
        public uint queueLabelCount;
        public VkDebugUtilsLabelEXT* pQueueLabels;
        public uint cmdBufLabelCount;
        public VkDebugUtilsLabelEXT* pCmdBufLabels;
        public uint objectCount;
        public VkDebugUtilsObjectNameInfoEXT* pObjects;
        public VkDebugUtilsMessengerCallbackDataEXT(VkStructureType sType, void* pNext, VkDebugUtilsMessengerCallbackDataFlagsEXT flags, byte* pMessageIdName, int messageIdNumber, byte* pMessage, uint queueLabelCount, VkDebugUtilsLabelEXT* pQueueLabels, uint cmdBufLabelCount, VkDebugUtilsLabelEXT* pCmdBufLabels, uint objectCount, VkDebugUtilsObjectNameInfoEXT* pObjects)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pMessageIdName = pMessageIdName;
            this.messageIdNumber = messageIdNumber;
            this.pMessage = pMessage;
            this.queueLabelCount = queueLabelCount;
            this.pQueueLabels = pQueueLabels;
            this.cmdBufLabelCount = cmdBufLabelCount;
            this.pCmdBufLabels = pCmdBufLabels;
            this.objectCount = objectCount;
            this.pObjects = pObjects;
        }
    }
    public unsafe struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDeviceMemoryReportFeaturesExt;
        public void* pNext;
        public int deviceMemoryReport;
        public VkPhysicalDeviceDeviceMemoryReportFeaturesEXT(VkStructureType sType, void* pNext, int deviceMemoryReport)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceMemoryReport = deviceMemoryReport;
        }
    }
    public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceDeviceMemoryReportCreateInfoExt;
        public void* pNext;
        public VkDeviceMemoryReportFlagsEXT flags;
        public delegate* unmanaged[Cdecl]<VkDeviceMemoryReportCallbackDataEXT*, void*, void> pfnUserCallback;
        public void* pUserData;
        public VkDeviceDeviceMemoryReportCreateInfoEXT(VkStructureType sType, void* pNext, VkDeviceMemoryReportFlagsEXT flags, delegate* unmanaged[Cdecl]<VkDeviceMemoryReportCallbackDataEXT*, void*, void> pfnUserCallback, void* pUserData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pfnUserCallback = pfnUserCallback;
            this.pUserData = pUserData;
        }
    }
    public unsafe struct VkDeviceMemoryReportCallbackDataEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceMemoryReportCallbackDataExt;
        public void* pNext;
        public VkDeviceMemoryReportFlagsEXT flags;
        public VkDeviceMemoryReportEventTypeEXT type;
        public ulong memoryObjectId;
        public ulong size;
        public VkObjectType objectType;
        public ulong objectHandle;
        public uint heapIndex;
        public VkDeviceMemoryReportCallbackDataEXT(VkStructureType sType, void* pNext, VkDeviceMemoryReportFlagsEXT flags, VkDeviceMemoryReportEventTypeEXT type, ulong memoryObjectId, ulong size, VkObjectType objectType, ulong objectHandle, uint heapIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.type = type;
            this.memoryObjectId = memoryObjectId;
            this.size = size;
            this.objectType = objectType;
            this.objectHandle = objectHandle;
            this.heapIndex = heapIndex;
        }
    }
    public unsafe struct VkImportMemoryHostPointerInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMemoryHostPointerInfoExt;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public void* pHostPointer;
        public VkImportMemoryHostPointerInfoEXT(VkStructureType sType, void* pNext, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.handleType = handleType;
            this.pHostPointer = pHostPointer;
        }
    }
    public unsafe struct VkMemoryHostPointerPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryHostPointerPropertiesExt;
        public void* pNext;
        public uint memoryTypeBits;
        public VkMemoryHostPointerPropertiesEXT(VkStructureType sType, void* pNext, uint memoryTypeBits)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryTypeBits = memoryTypeBits;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalMemoryHostPropertiesExt;
        public void* pNext;
        public ulong minImportedHostPointerAlignment;
        public VkPhysicalDeviceExternalMemoryHostPropertiesEXT(VkStructureType sType, void* pNext, ulong minImportedHostPointerAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minImportedHostPointerAlignment = minImportedHostPointerAlignment;
        }
    }
    public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceConservativeRasterizationPropertiesExt;
        public void* pNext;
        public float primitiveOverestimationSize;
        public float maxExtraPrimitiveOverestimationSize;
        public float extraPrimitiveOverestimationSizeGranularity;
        public int primitiveUnderestimation;
        public int conservativePointAndLineRasterization;
        public int degenerateTrianglesRasterized;
        public int degenerateLinesRasterized;
        public int fullyCoveredFragmentShaderInputVariable;
        public int conservativeRasterizationPostDepthCoverage;
        public VkPhysicalDeviceConservativeRasterizationPropertiesEXT(VkStructureType sType, void* pNext, float primitiveOverestimationSize, float maxExtraPrimitiveOverestimationSize, float extraPrimitiveOverestimationSizeGranularity, int primitiveUnderestimation, int conservativePointAndLineRasterization, int degenerateTrianglesRasterized, int degenerateLinesRasterized, int fullyCoveredFragmentShaderInputVariable, int conservativeRasterizationPostDepthCoverage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.primitiveOverestimationSize = primitiveOverestimationSize;
            this.maxExtraPrimitiveOverestimationSize = maxExtraPrimitiveOverestimationSize;
            this.extraPrimitiveOverestimationSizeGranularity = extraPrimitiveOverestimationSizeGranularity;
            this.primitiveUnderestimation = primitiveUnderestimation;
            this.conservativePointAndLineRasterization = conservativePointAndLineRasterization;
            this.degenerateTrianglesRasterized = degenerateTrianglesRasterized;
            this.degenerateLinesRasterized = degenerateLinesRasterized;
            this.fullyCoveredFragmentShaderInputVariable = fullyCoveredFragmentShaderInputVariable;
            this.conservativeRasterizationPostDepthCoverage = conservativeRasterizationPostDepthCoverage;
        }
    }
    public unsafe struct VkCalibratedTimestampInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeCalibratedTimestampInfoKhr;
        public void* pNext;
        public VkTimeDomainKHR timeDomain;
        public VkCalibratedTimestampInfoKHR(VkStructureType sType, void* pNext, VkTimeDomainKHR timeDomain)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.timeDomain = timeDomain;
        }
    }
    public unsafe struct VkCalibratedTimestampInfoEXT
    {
        public VkCalibratedTimestampInfoEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderCorePropertiesAmd;
        public void* pNext;
        public uint shaderEngineCount;
        public uint shaderArraysPerEngineCount;
        public uint computeUnitsPerShaderArray;
        public uint simdPerComputeUnit;
        public uint wavefrontsPerSimd;
        public uint wavefrontSize;
        public uint sgprsPerSimd;
        public uint minSgprAllocation;
        public uint maxSgprAllocation;
        public uint sgprAllocationGranularity;
        public uint vgprsPerSimd;
        public uint minVgprAllocation;
        public uint maxVgprAllocation;
        public uint vgprAllocationGranularity;
        public VkPhysicalDeviceShaderCorePropertiesAMD(VkStructureType sType, void* pNext, uint shaderEngineCount, uint shaderArraysPerEngineCount, uint computeUnitsPerShaderArray, uint simdPerComputeUnit, uint wavefrontsPerSimd, uint wavefrontSize, uint sgprsPerSimd, uint minSgprAllocation, uint maxSgprAllocation, uint sgprAllocationGranularity, uint vgprsPerSimd, uint minVgprAllocation, uint maxVgprAllocation, uint vgprAllocationGranularity)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderEngineCount = shaderEngineCount;
            this.shaderArraysPerEngineCount = shaderArraysPerEngineCount;
            this.computeUnitsPerShaderArray = computeUnitsPerShaderArray;
            this.simdPerComputeUnit = simdPerComputeUnit;
            this.wavefrontsPerSimd = wavefrontsPerSimd;
            this.wavefrontSize = wavefrontSize;
            this.sgprsPerSimd = sgprsPerSimd;
            this.minSgprAllocation = minSgprAllocation;
            this.maxSgprAllocation = maxSgprAllocation;
            this.sgprAllocationGranularity = sgprAllocationGranularity;
            this.vgprsPerSimd = vgprsPerSimd;
            this.minVgprAllocation = minVgprAllocation;
            this.maxVgprAllocation = maxVgprAllocation;
            this.vgprAllocationGranularity = vgprAllocationGranularity;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderCoreProperties2Amd;
        public void* pNext;
        public VkShaderCorePropertiesFlagBitsAMD shaderCoreFeatures;
        public uint activeComputeUnitCount;
        public VkPhysicalDeviceShaderCoreProperties2AMD(VkStructureType sType, void* pNext, VkShaderCorePropertiesFlagBitsAMD shaderCoreFeatures, uint activeComputeUnitCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderCoreFeatures = shaderCoreFeatures;
            this.activeComputeUnitCount = activeComputeUnitCount;
        }
    }
    public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRasterizationConservativeStateCreateInfoExt;
        public void* pNext;
        public VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;
        public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
        public float extraPrimitiveOverestimationSize;
        public VkPipelineRasterizationConservativeStateCreateInfoEXT(VkStructureType sType, void* pNext, VkPipelineRasterizationConservativeStateCreateFlagsEXT flags, VkConservativeRasterizationModeEXT conservativeRasterizationMode, float extraPrimitiveOverestimationSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.conservativeRasterizationMode = conservativeRasterizationMode;
            this.extraPrimitiveOverestimationSize = extraPrimitiveOverestimationSize;
        }
    }
    public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDescriptorIndexingFeatures;
        public void* pNext;
        public int shaderInputAttachmentArrayDynamicIndexing;
        public int shaderUniformTexelBufferArrayDynamicIndexing;
        public int shaderStorageTexelBufferArrayDynamicIndexing;
        public int shaderUniformBufferArrayNonUniformIndexing;
        public int shaderSampledImageArrayNonUniformIndexing;
        public int shaderStorageBufferArrayNonUniformIndexing;
        public int shaderStorageImageArrayNonUniformIndexing;
        public int shaderInputAttachmentArrayNonUniformIndexing;
        public int shaderUniformTexelBufferArrayNonUniformIndexing;
        public int shaderStorageTexelBufferArrayNonUniformIndexing;
        public int descriptorBindingUniformBufferUpdateAfterBind;
        public int descriptorBindingSampledImageUpdateAfterBind;
        public int descriptorBindingStorageImageUpdateAfterBind;
        public int descriptorBindingStorageBufferUpdateAfterBind;
        public int descriptorBindingUniformTexelBufferUpdateAfterBind;
        public int descriptorBindingStorageTexelBufferUpdateAfterBind;
        public int descriptorBindingUpdateUnusedWhilePending;
        public int descriptorBindingPartiallyBound;
        public int descriptorBindingVariableDescriptorCount;
        public int runtimeDescriptorArray;
        public VkPhysicalDeviceDescriptorIndexingFeatures(VkStructureType sType, void* pNext, int shaderInputAttachmentArrayDynamicIndexing, int shaderUniformTexelBufferArrayDynamicIndexing, int shaderStorageTexelBufferArrayDynamicIndexing, int shaderUniformBufferArrayNonUniformIndexing, int shaderSampledImageArrayNonUniformIndexing, int shaderStorageBufferArrayNonUniformIndexing, int shaderStorageImageArrayNonUniformIndexing, int shaderInputAttachmentArrayNonUniformIndexing, int shaderUniformTexelBufferArrayNonUniformIndexing, int shaderStorageTexelBufferArrayNonUniformIndexing, int descriptorBindingUniformBufferUpdateAfterBind, int descriptorBindingSampledImageUpdateAfterBind, int descriptorBindingStorageImageUpdateAfterBind, int descriptorBindingStorageBufferUpdateAfterBind, int descriptorBindingUniformTexelBufferUpdateAfterBind, int descriptorBindingStorageTexelBufferUpdateAfterBind, int descriptorBindingUpdateUnusedWhilePending, int descriptorBindingPartiallyBound, int descriptorBindingVariableDescriptorCount, int runtimeDescriptorArray)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderInputAttachmentArrayDynamicIndexing = shaderInputAttachmentArrayDynamicIndexing;
            this.shaderUniformTexelBufferArrayDynamicIndexing = shaderUniformTexelBufferArrayDynamicIndexing;
            this.shaderStorageTexelBufferArrayDynamicIndexing = shaderStorageTexelBufferArrayDynamicIndexing;
            this.shaderUniformBufferArrayNonUniformIndexing = shaderUniformBufferArrayNonUniformIndexing;
            this.shaderSampledImageArrayNonUniformIndexing = shaderSampledImageArrayNonUniformIndexing;
            this.shaderStorageBufferArrayNonUniformIndexing = shaderStorageBufferArrayNonUniformIndexing;
            this.shaderStorageImageArrayNonUniformIndexing = shaderStorageImageArrayNonUniformIndexing;
            this.shaderInputAttachmentArrayNonUniformIndexing = shaderInputAttachmentArrayNonUniformIndexing;
            this.shaderUniformTexelBufferArrayNonUniformIndexing = shaderUniformTexelBufferArrayNonUniformIndexing;
            this.shaderStorageTexelBufferArrayNonUniformIndexing = shaderStorageTexelBufferArrayNonUniformIndexing;
            this.descriptorBindingUniformBufferUpdateAfterBind = descriptorBindingUniformBufferUpdateAfterBind;
            this.descriptorBindingSampledImageUpdateAfterBind = descriptorBindingSampledImageUpdateAfterBind;
            this.descriptorBindingStorageImageUpdateAfterBind = descriptorBindingStorageImageUpdateAfterBind;
            this.descriptorBindingStorageBufferUpdateAfterBind = descriptorBindingStorageBufferUpdateAfterBind;
            this.descriptorBindingUniformTexelBufferUpdateAfterBind = descriptorBindingUniformTexelBufferUpdateAfterBind;
            this.descriptorBindingStorageTexelBufferUpdateAfterBind = descriptorBindingStorageTexelBufferUpdateAfterBind;
            this.descriptorBindingUpdateUnusedWhilePending = descriptorBindingUpdateUnusedWhilePending;
            this.descriptorBindingPartiallyBound = descriptorBindingPartiallyBound;
            this.descriptorBindingVariableDescriptorCount = descriptorBindingVariableDescriptorCount;
            this.runtimeDescriptorArray = runtimeDescriptorArray;
        }
    }
    public unsafe struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
    {
        public VkPhysicalDeviceDescriptorIndexingFeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDescriptorIndexingProperties;
        public void* pNext;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public int shaderUniformBufferArrayNonUniformIndexingNative;
        public int shaderSampledImageArrayNonUniformIndexingNative;
        public int shaderStorageBufferArrayNonUniformIndexingNative;
        public int shaderStorageImageArrayNonUniformIndexingNative;
        public int shaderInputAttachmentArrayNonUniformIndexingNative;
        public int robustBufferAccessUpdateAfterBind;
        public int quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
        public VkPhysicalDeviceDescriptorIndexingProperties(VkStructureType sType, void* pNext, uint maxUpdateAfterBindDescriptorsInAllPools, int shaderUniformBufferArrayNonUniformIndexingNative, int shaderSampledImageArrayNonUniformIndexingNative, int shaderStorageBufferArrayNonUniformIndexingNative, int shaderStorageImageArrayNonUniformIndexingNative, int shaderInputAttachmentArrayNonUniformIndexingNative, int robustBufferAccessUpdateAfterBind, int quadDivergentImplicitLod, uint maxPerStageDescriptorUpdateAfterBindSamplers, uint maxPerStageDescriptorUpdateAfterBindUniformBuffers, uint maxPerStageDescriptorUpdateAfterBindStorageBuffers, uint maxPerStageDescriptorUpdateAfterBindSampledImages, uint maxPerStageDescriptorUpdateAfterBindStorageImages, uint maxPerStageDescriptorUpdateAfterBindInputAttachments, uint maxPerStageUpdateAfterBindResources, uint maxDescriptorSetUpdateAfterBindSamplers, uint maxDescriptorSetUpdateAfterBindUniformBuffers, uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic, uint maxDescriptorSetUpdateAfterBindStorageBuffers, uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic, uint maxDescriptorSetUpdateAfterBindSampledImages, uint maxDescriptorSetUpdateAfterBindStorageImages, uint maxDescriptorSetUpdateAfterBindInputAttachments)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxUpdateAfterBindDescriptorsInAllPools = maxUpdateAfterBindDescriptorsInAllPools;
            this.shaderUniformBufferArrayNonUniformIndexingNative = shaderUniformBufferArrayNonUniformIndexingNative;
            this.shaderSampledImageArrayNonUniformIndexingNative = shaderSampledImageArrayNonUniformIndexingNative;
            this.shaderStorageBufferArrayNonUniformIndexingNative = shaderStorageBufferArrayNonUniformIndexingNative;
            this.shaderStorageImageArrayNonUniformIndexingNative = shaderStorageImageArrayNonUniformIndexingNative;
            this.shaderInputAttachmentArrayNonUniformIndexingNative = shaderInputAttachmentArrayNonUniformIndexingNative;
            this.robustBufferAccessUpdateAfterBind = robustBufferAccessUpdateAfterBind;
            this.quadDivergentImplicitLod = quadDivergentImplicitLod;
            this.maxPerStageDescriptorUpdateAfterBindSamplers = maxPerStageDescriptorUpdateAfterBindSamplers;
            this.maxPerStageDescriptorUpdateAfterBindUniformBuffers = maxPerStageDescriptorUpdateAfterBindUniformBuffers;
            this.maxPerStageDescriptorUpdateAfterBindStorageBuffers = maxPerStageDescriptorUpdateAfterBindStorageBuffers;
            this.maxPerStageDescriptorUpdateAfterBindSampledImages = maxPerStageDescriptorUpdateAfterBindSampledImages;
            this.maxPerStageDescriptorUpdateAfterBindStorageImages = maxPerStageDescriptorUpdateAfterBindStorageImages;
            this.maxPerStageDescriptorUpdateAfterBindInputAttachments = maxPerStageDescriptorUpdateAfterBindInputAttachments;
            this.maxPerStageUpdateAfterBindResources = maxPerStageUpdateAfterBindResources;
            this.maxDescriptorSetUpdateAfterBindSamplers = maxDescriptorSetUpdateAfterBindSamplers;
            this.maxDescriptorSetUpdateAfterBindUniformBuffers = maxDescriptorSetUpdateAfterBindUniformBuffers;
            this.maxDescriptorSetUpdateAfterBindUniformBuffersDynamic = maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
            this.maxDescriptorSetUpdateAfterBindStorageBuffers = maxDescriptorSetUpdateAfterBindStorageBuffers;
            this.maxDescriptorSetUpdateAfterBindStorageBuffersDynamic = maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
            this.maxDescriptorSetUpdateAfterBindSampledImages = maxDescriptorSetUpdateAfterBindSampledImages;
            this.maxDescriptorSetUpdateAfterBindStorageImages = maxDescriptorSetUpdateAfterBindStorageImages;
            this.maxDescriptorSetUpdateAfterBindInputAttachments = maxDescriptorSetUpdateAfterBindInputAttachments;
        }
    }
    public unsafe struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT
    {
        public VkPhysicalDeviceDescriptorIndexingPropertiesEXT()
        {
        }
    }
    public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorSetLayoutBindingFlagsCreateInfo;
        public void* pNext;
        public uint bindingCount;
        public VkDescriptorBindingFlagBits* pBindingFlags;
        public VkDescriptorSetLayoutBindingFlagsCreateInfo(VkStructureType sType, void* pNext, uint bindingCount, VkDescriptorBindingFlagBits* pBindingFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.bindingCount = bindingCount;
            this.pBindingFlags = pBindingFlags;
        }
    }
    public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
    {
        public VkDescriptorSetLayoutBindingFlagsCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorSetVariableDescriptorCountAllocateInfo;
        public void* pNext;
        public uint descriptorSetCount;
        public uint* pDescriptorCounts;
        public VkDescriptorSetVariableDescriptorCountAllocateInfo(VkStructureType sType, void* pNext, uint descriptorSetCount, uint* pDescriptorCounts)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.descriptorSetCount = descriptorSetCount;
            this.pDescriptorCounts = pDescriptorCounts;
        }
    }
    public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
    {
        public VkDescriptorSetVariableDescriptorCountAllocateInfoEXT()
        {
        }
    }
    public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorSetVariableDescriptorCountLayoutSupport;
        public void* pNext;
        public uint maxVariableDescriptorCount;
        public VkDescriptorSetVariableDescriptorCountLayoutSupport(VkStructureType sType, void* pNext, uint maxVariableDescriptorCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxVariableDescriptorCount = maxVariableDescriptorCount;
        }
    }
    public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
    {
        public VkDescriptorSetVariableDescriptorCountLayoutSupportEXT()
        {
        }
    }
    public unsafe struct VkAttachmentDescription2
    {
        public VkStructureType sType = VkStructureType.StructureTypeAttachmentDescription2;
        public void* pNext;
        public VkAttachmentDescriptionFlagBits flags;
        public VkFormat format;
        public VkSampleCountFlagBits samples;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkAttachmentLoadOp stencilLoadOp;
        public VkAttachmentStoreOp stencilStoreOp;
        public VkImageLayout initialLayout;
        public VkImageLayout finalLayout;
        public VkAttachmentDescription2(VkStructureType sType, void* pNext, VkAttachmentDescriptionFlagBits flags, VkFormat format, VkSampleCountFlagBits samples, VkAttachmentLoadOp loadOp, VkAttachmentStoreOp storeOp, VkAttachmentLoadOp stencilLoadOp, VkAttachmentStoreOp stencilStoreOp, VkImageLayout initialLayout, VkImageLayout finalLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.format = format;
            this.samples = samples;
            this.loadOp = loadOp;
            this.storeOp = storeOp;
            this.stencilLoadOp = stencilLoadOp;
            this.stencilStoreOp = stencilStoreOp;
            this.initialLayout = initialLayout;
            this.finalLayout = finalLayout;
        }
    }
    public unsafe struct VkAttachmentDescription2KHR
    {
        public VkAttachmentDescription2KHR()
        {
        }
    }
    public unsafe struct VkAttachmentReference2
    {
        public VkStructureType sType = VkStructureType.StructureTypeAttachmentReference2;
        public void* pNext;
        public uint attachment;
        public VkImageLayout layout;
        public VkImageAspectFlagBits aspectMask;
        public VkAttachmentReference2(VkStructureType sType, void* pNext, uint attachment, VkImageLayout layout, VkImageAspectFlagBits aspectMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.attachment = attachment;
            this.layout = layout;
            this.aspectMask = aspectMask;
        }
    }
    public unsafe struct VkAttachmentReference2KHR
    {
        public VkAttachmentReference2KHR()
        {
        }
    }
    public unsafe struct VkSubpassDescription2
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubpassDescription2;
        public void* pNext;
        public VkSubpassDescriptionFlagBits flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint viewMask;
        public uint inputAttachmentCount;
        public VkAttachmentReference2* pInputAttachments;
        public uint colorAttachmentCount;
        public VkAttachmentReference2* pColorAttachments;
        public VkAttachmentReference2* pResolveAttachments;
        public VkAttachmentReference2* pDepthStencilAttachment;
        public uint preserveAttachmentCount;
        public uint* pPreserveAttachments;
        public VkSubpassDescription2(VkStructureType sType, void* pNext, VkSubpassDescriptionFlagBits flags, VkPipelineBindPoint pipelineBindPoint, uint viewMask, uint inputAttachmentCount, VkAttachmentReference2* pInputAttachments, uint colorAttachmentCount, VkAttachmentReference2* pColorAttachments, VkAttachmentReference2* pResolveAttachments, VkAttachmentReference2* pDepthStencilAttachment, uint preserveAttachmentCount, uint* pPreserveAttachments)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pipelineBindPoint = pipelineBindPoint;
            this.viewMask = viewMask;
            this.inputAttachmentCount = inputAttachmentCount;
            this.pInputAttachments = pInputAttachments;
            this.colorAttachmentCount = colorAttachmentCount;
            this.pColorAttachments = pColorAttachments;
            this.pResolveAttachments = pResolveAttachments;
            this.pDepthStencilAttachment = pDepthStencilAttachment;
            this.preserveAttachmentCount = preserveAttachmentCount;
            this.pPreserveAttachments = pPreserveAttachments;
        }
    }
    public unsafe struct VkSubpassDescription2KHR
    {
        public VkSubpassDescription2KHR()
        {
        }
    }
    public unsafe struct VkSubpassDependency2
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubpassDependency2;
        public void* pNext;
        public uint srcSubpass;
        public uint dstSubpass;
        public VkPipelineStageFlagBits srcStageMask;
        public VkPipelineStageFlagBits dstStageMask;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
        public VkDependencyFlagBits dependencyFlags;
        public int viewOffset;
        public VkSubpassDependency2(VkStructureType sType, void* pNext, uint srcSubpass, uint dstSubpass, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, VkAccessFlagBits srcAccessMask, VkAccessFlagBits dstAccessMask, VkDependencyFlagBits dependencyFlags, int viewOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcSubpass = srcSubpass;
            this.dstSubpass = dstSubpass;
            this.srcStageMask = srcStageMask;
            this.dstStageMask = dstStageMask;
            this.srcAccessMask = srcAccessMask;
            this.dstAccessMask = dstAccessMask;
            this.dependencyFlags = dependencyFlags;
            this.viewOffset = viewOffset;
        }
    }
    public unsafe struct VkSubpassDependency2KHR
    {
        public VkSubpassDependency2KHR()
        {
        }
    }
    public unsafe struct VkRenderPassCreateInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassCreateInfo2;
        public void* pNext;
        public VkRenderPassCreateFlagBits flags;
        public uint attachmentCount;
        public VkAttachmentDescription2* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription2* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency2* pDependencies;
        public uint correlatedViewMaskCount;
        public uint* pCorrelatedViewMasks;
        public VkRenderPassCreateInfo2(VkStructureType sType, void* pNext, VkRenderPassCreateFlagBits flags, uint attachmentCount, VkAttachmentDescription2* pAttachments, uint subpassCount, VkSubpassDescription2* pSubpasses, uint dependencyCount, VkSubpassDependency2* pDependencies, uint correlatedViewMaskCount, uint* pCorrelatedViewMasks)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.attachmentCount = attachmentCount;
            this.pAttachments = pAttachments;
            this.subpassCount = subpassCount;
            this.pSubpasses = pSubpasses;
            this.dependencyCount = dependencyCount;
            this.pDependencies = pDependencies;
            this.correlatedViewMaskCount = correlatedViewMaskCount;
            this.pCorrelatedViewMasks = pCorrelatedViewMasks;
        }
    }
    public unsafe struct VkRenderPassCreateInfo2KHR
    {
        public VkRenderPassCreateInfo2KHR()
        {
        }
    }
    public unsafe struct VkSubpassBeginInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubpassBeginInfo;
        public void* pNext;
        public VkSubpassContents contents;
        public VkSubpassBeginInfo(VkStructureType sType, void* pNext, VkSubpassContents contents)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.contents = contents;
        }
    }
    public unsafe struct VkSubpassBeginInfoKHR
    {
        public VkSubpassBeginInfoKHR()
        {
        }
    }
    public unsafe struct VkSubpassEndInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubpassEndInfo;
        public void* pNext;
        public VkSubpassEndInfo(VkStructureType sType, void* pNext)
        {
            this.sType = sType;
            this.pNext = pNext;
        }
    }
    public unsafe struct VkSubpassEndInfoKHR
    {
        public VkSubpassEndInfoKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceTimelineSemaphoreFeatures;
        public void* pNext;
        public int timelineSemaphore;
        public VkPhysicalDeviceTimelineSemaphoreFeatures(VkStructureType sType, void* pNext, int timelineSemaphore)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.timelineSemaphore = timelineSemaphore;
        }
    }
    public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeaturesKHR
    {
        public VkPhysicalDeviceTimelineSemaphoreFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceTimelineSemaphoreProperties;
        public void* pNext;
        public ulong maxTimelineSemaphoreValueDifference;
        public VkPhysicalDeviceTimelineSemaphoreProperties(VkStructureType sType, void* pNext, ulong maxTimelineSemaphoreValueDifference)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxTimelineSemaphoreValueDifference = maxTimelineSemaphoreValueDifference;
        }
    }
    public unsafe struct VkPhysicalDeviceTimelineSemaphorePropertiesKHR
    {
        public VkPhysicalDeviceTimelineSemaphorePropertiesKHR()
        {
        }
    }
    public unsafe struct VkSemaphoreTypeCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreTypeCreateInfo;
        public void* pNext;
        public VkSemaphoreType semaphoreType;
        public ulong initialValue;
        public VkSemaphoreTypeCreateInfo(VkStructureType sType, void* pNext, VkSemaphoreType semaphoreType, ulong initialValue)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphoreType = semaphoreType;
            this.initialValue = initialValue;
        }
    }
    public unsafe struct VkSemaphoreTypeCreateInfoKHR
    {
        public VkSemaphoreTypeCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkTimelineSemaphoreSubmitInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeTimelineSemaphoreSubmitInfo;
        public void* pNext;
        public uint waitSemaphoreValueCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValueCount;
        public ulong* pSignalSemaphoreValues;
        public VkTimelineSemaphoreSubmitInfo(VkStructureType sType, void* pNext, uint waitSemaphoreValueCount, ulong* pWaitSemaphoreValues, uint signalSemaphoreValueCount, ulong* pSignalSemaphoreValues)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.waitSemaphoreValueCount = waitSemaphoreValueCount;
            this.pWaitSemaphoreValues = pWaitSemaphoreValues;
            this.signalSemaphoreValueCount = signalSemaphoreValueCount;
            this.pSignalSemaphoreValues = pSignalSemaphoreValues;
        }
    }
    public unsafe struct VkTimelineSemaphoreSubmitInfoKHR
    {
        public VkTimelineSemaphoreSubmitInfoKHR()
        {
        }
    }
    public unsafe struct VkSemaphoreWaitInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreWaitInfo;
        public void* pNext;
        public VkSemaphoreWaitFlagBits flags;
        public uint semaphoreCount;
        public VkSemaphore* pSemaphores;
        public ulong* pValues;
        public VkSemaphoreWaitInfo(VkStructureType sType, void* pNext, VkSemaphoreWaitFlagBits flags, uint semaphoreCount, VkSemaphore* pSemaphores, ulong* pValues)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.semaphoreCount = semaphoreCount;
            this.pSemaphores = pSemaphores;
            this.pValues = pValues;
        }
    }
    public unsafe struct VkSemaphoreWaitInfoKHR
    {
        public VkSemaphoreWaitInfoKHR()
        {
        }
    }
    public unsafe struct VkSemaphoreSignalInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreSignalInfo;
        public void* pNext;
        public VkSemaphore semaphore;
        public ulong value;
        public VkSemaphoreSignalInfo(VkStructureType sType, void* pNext, VkSemaphore semaphore, ulong value)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.value = value;
        }
    }
    public unsafe struct VkSemaphoreSignalInfoKHR
    {
        public VkSemaphoreSignalInfoKHR()
        {
        }
    }
    public unsafe struct VkVertexInputBindingDivisorDescriptionKHR
    {
        public uint binding;
        public uint divisor;
        public VkVertexInputBindingDivisorDescriptionKHR(uint binding, uint divisor)
        {
            this.binding = binding;
            this.divisor = divisor;
        }
    }
    public unsafe struct VkVertexInputBindingDivisorDescriptionEXT
    {
        public VkVertexInputBindingDivisorDescriptionEXT()
        {
        }
    }
    public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineVertexInputDivisorStateCreateInfoKhr;
        public void* pNext;
        public uint vertexBindingDivisorCount;
        public VkVertexInputBindingDivisorDescriptionKHR* pVertexBindingDivisors;
        public VkPipelineVertexInputDivisorStateCreateInfoKHR(VkStructureType sType, void* pNext, uint vertexBindingDivisorCount, VkVertexInputBindingDivisorDescriptionKHR* pVertexBindingDivisors)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.vertexBindingDivisorCount = vertexBindingDivisorCount;
            this.pVertexBindingDivisors = pVertexBindingDivisors;
        }
    }
    public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
    {
        public VkPipelineVertexInputDivisorStateCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVertexAttributeDivisorPropertiesExt;
        public void* pNext;
        public uint maxVertexAttribDivisor;
        public VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT(VkStructureType sType, void* pNext, uint maxVertexAttribDivisor)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxVertexAttribDivisor = maxVertexAttribDivisor;
        }
    }
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVertexAttributeDivisorPropertiesKhr;
        public void* pNext;
        public uint maxVertexAttribDivisor;
        public int supportsNonZeroFirstInstance;
        public VkPhysicalDeviceVertexAttributeDivisorPropertiesKHR(VkStructureType sType, void* pNext, uint maxVertexAttribDivisor, int supportsNonZeroFirstInstance)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxVertexAttribDivisor = maxVertexAttribDivisor;
            this.supportsNonZeroFirstInstance = supportsNonZeroFirstInstance;
        }
    }
    public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePciBusInfoPropertiesExt;
        public void* pNext;
        public uint pciDomain;
        public uint pciBus;
        public uint pciDevice;
        public uint pciFunction;
        public VkPhysicalDevicePCIBusInfoPropertiesEXT(VkStructureType sType, void* pNext, uint pciDomain, uint pciBus, uint pciDevice, uint pciFunction)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pciDomain = pciDomain;
            this.pciBus = pciBus;
            this.pciDevice = pciDevice;
            this.pciFunction = pciFunction;
        }
    }
    public unsafe struct VkImportAndroidHardwareBufferInfoANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportAndroidHardwareBufferInfoAndroid;
        public void* pNext;
        public IntPtr buffer;
        public VkImportAndroidHardwareBufferInfoANDROID(VkStructureType sType, void* pNext, IntPtr buffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.buffer = buffer;
        }
    }
    public unsafe struct VkAndroidHardwareBufferUsageANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypeAndroidHardwareBufferUsageAndroid;
        public void* pNext;
        public ulong androidHardwareBufferUsage;
        public VkAndroidHardwareBufferUsageANDROID(VkStructureType sType, void* pNext, ulong androidHardwareBufferUsage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.androidHardwareBufferUsage = androidHardwareBufferUsage;
        }
    }
    public unsafe struct VkAndroidHardwareBufferPropertiesANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypeAndroidHardwareBufferPropertiesAndroid;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeBits;
        public VkAndroidHardwareBufferPropertiesANDROID(VkStructureType sType, void* pNext, ulong allocationSize, uint memoryTypeBits)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.allocationSize = allocationSize;
            this.memoryTypeBits = memoryTypeBits;
        }
    }
    public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryGetAndroidHardwareBufferInfoAndroid;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkMemoryGetAndroidHardwareBufferInfoANDROID(VkStructureType sType, void* pNext, VkDeviceMemory memory)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memory = memory;
        }
    }
    public unsafe struct VkAndroidHardwareBufferFormatPropertiesANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypeAndroidHardwareBufferFormatPropertiesAndroid;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public VkFormatFeatureFlagBits formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
        public VkAndroidHardwareBufferFormatPropertiesANDROID(VkStructureType sType, void* pNext, VkFormat format, ulong externalFormat, VkFormatFeatureFlagBits formatFeatures, VkComponentMapping samplerYcbcrConversionComponents, VkSamplerYcbcrModelConversion suggestedYcbcrModel, VkSamplerYcbcrRange suggestedYcbcrRange, VkChromaLocation suggestedXChromaOffset, VkChromaLocation suggestedYChromaOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.format = format;
            this.externalFormat = externalFormat;
            this.formatFeatures = formatFeatures;
            this.samplerYcbcrConversionComponents = samplerYcbcrConversionComponents;
            this.suggestedYcbcrModel = suggestedYcbcrModel;
            this.suggestedYcbcrRange = suggestedYcbcrRange;
            this.suggestedXChromaOffset = suggestedXChromaOffset;
            this.suggestedYChromaOffset = suggestedYChromaOffset;
        }
    }
    public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeCommandBufferInheritanceConditionalRenderingInfoExt;
        public void* pNext;
        public int conditionalRenderingEnable;
        public VkCommandBufferInheritanceConditionalRenderingInfoEXT(VkStructureType sType, void* pNext, int conditionalRenderingEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.conditionalRenderingEnable = conditionalRenderingEnable;
        }
    }
    public unsafe struct VkExternalFormatANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalFormatAndroid;
        public void* pNext;
        public ulong externalFormat;
        public VkExternalFormatANDROID(VkStructureType sType, void* pNext, ulong externalFormat)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.externalFormat = externalFormat;
        }
    }
    public unsafe struct VkPhysicalDevice8BitStorageFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevice8bitStorageFeatures;
        public void* pNext;
        public int storageBuffer8BitAccess;
        public int uniformAndStorageBuffer8BitAccess;
        public int storagePushConstant8;
        public VkPhysicalDevice8BitStorageFeatures(VkStructureType sType, void* pNext, int storageBuffer8BitAccess, int uniformAndStorageBuffer8BitAccess, int storagePushConstant8)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.storageBuffer8BitAccess = storageBuffer8BitAccess;
            this.uniformAndStorageBuffer8BitAccess = uniformAndStorageBuffer8BitAccess;
            this.storagePushConstant8 = storagePushConstant8;
        }
    }
    public unsafe struct VkPhysicalDevice8BitStorageFeaturesKHR
    {
        public VkPhysicalDevice8BitStorageFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceConditionalRenderingFeaturesExt;
        public void* pNext;
        public int conditionalRendering;
        public int inheritedConditionalRendering;
        public VkPhysicalDeviceConditionalRenderingFeaturesEXT(VkStructureType sType, void* pNext, int conditionalRendering, int inheritedConditionalRendering)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.conditionalRendering = conditionalRendering;
            this.inheritedConditionalRendering = inheritedConditionalRendering;
        }
    }
    public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVulkanMemoryModelFeatures;
        public void* pNext;
        public int vulkanMemoryModel;
        public int vulkanMemoryModelDeviceScope;
        public int vulkanMemoryModelAvailabilityVisibilityChains;
        public VkPhysicalDeviceVulkanMemoryModelFeatures(VkStructureType sType, void* pNext, int vulkanMemoryModel, int vulkanMemoryModelDeviceScope, int vulkanMemoryModelAvailabilityVisibilityChains)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.vulkanMemoryModel = vulkanMemoryModel;
            this.vulkanMemoryModelDeviceScope = vulkanMemoryModelDeviceScope;
            this.vulkanMemoryModelAvailabilityVisibilityChains = vulkanMemoryModelAvailabilityVisibilityChains;
        }
    }
    public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR
    {
        public VkPhysicalDeviceVulkanMemoryModelFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderAtomicInt64Features;
        public void* pNext;
        public int shaderBufferInt64Atomics;
        public int shaderSharedInt64Atomics;
        public VkPhysicalDeviceShaderAtomicInt64Features(VkStructureType sType, void* pNext, int shaderBufferInt64Atomics, int shaderSharedInt64Atomics)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderBufferInt64Atomics = shaderBufferInt64Atomics;
            this.shaderSharedInt64Atomics = shaderSharedInt64Atomics;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR
    {
        public VkPhysicalDeviceShaderAtomicInt64FeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderAtomicFloatFeaturesExt;
        public void* pNext;
        public int shaderBufferFloat32Atomics;
        public int shaderBufferFloat32AtomicAdd;
        public int shaderBufferFloat64Atomics;
        public int shaderBufferFloat64AtomicAdd;
        public int shaderSharedFloat32Atomics;
        public int shaderSharedFloat32AtomicAdd;
        public int shaderSharedFloat64Atomics;
        public int shaderSharedFloat64AtomicAdd;
        public int shaderImageFloat32Atomics;
        public int shaderImageFloat32AtomicAdd;
        public int sparseImageFloat32Atomics;
        public int sparseImageFloat32AtomicAdd;
        public VkPhysicalDeviceShaderAtomicFloatFeaturesEXT(VkStructureType sType, void* pNext, int shaderBufferFloat32Atomics, int shaderBufferFloat32AtomicAdd, int shaderBufferFloat64Atomics, int shaderBufferFloat64AtomicAdd, int shaderSharedFloat32Atomics, int shaderSharedFloat32AtomicAdd, int shaderSharedFloat64Atomics, int shaderSharedFloat64AtomicAdd, int shaderImageFloat32Atomics, int shaderImageFloat32AtomicAdd, int sparseImageFloat32Atomics, int sparseImageFloat32AtomicAdd)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderBufferFloat32Atomics = shaderBufferFloat32Atomics;
            this.shaderBufferFloat32AtomicAdd = shaderBufferFloat32AtomicAdd;
            this.shaderBufferFloat64Atomics = shaderBufferFloat64Atomics;
            this.shaderBufferFloat64AtomicAdd = shaderBufferFloat64AtomicAdd;
            this.shaderSharedFloat32Atomics = shaderSharedFloat32Atomics;
            this.shaderSharedFloat32AtomicAdd = shaderSharedFloat32AtomicAdd;
            this.shaderSharedFloat64Atomics = shaderSharedFloat64Atomics;
            this.shaderSharedFloat64AtomicAdd = shaderSharedFloat64AtomicAdd;
            this.shaderImageFloat32Atomics = shaderImageFloat32Atomics;
            this.shaderImageFloat32AtomicAdd = shaderImageFloat32AtomicAdd;
            this.sparseImageFloat32Atomics = sparseImageFloat32Atomics;
            this.sparseImageFloat32AtomicAdd = sparseImageFloat32AtomicAdd;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderAtomicFloat2FeaturesExt;
        public void* pNext;
        public int shaderBufferFloat16Atomics;
        public int shaderBufferFloat16AtomicAdd;
        public int shaderBufferFloat16AtomicMinMax;
        public int shaderBufferFloat32AtomicMinMax;
        public int shaderBufferFloat64AtomicMinMax;
        public int shaderSharedFloat16Atomics;
        public int shaderSharedFloat16AtomicAdd;
        public int shaderSharedFloat16AtomicMinMax;
        public int shaderSharedFloat32AtomicMinMax;
        public int shaderSharedFloat64AtomicMinMax;
        public int shaderImageFloat32AtomicMinMax;
        public int sparseImageFloat32AtomicMinMax;
        public VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT(VkStructureType sType, void* pNext, int shaderBufferFloat16Atomics, int shaderBufferFloat16AtomicAdd, int shaderBufferFloat16AtomicMinMax, int shaderBufferFloat32AtomicMinMax, int shaderBufferFloat64AtomicMinMax, int shaderSharedFloat16Atomics, int shaderSharedFloat16AtomicAdd, int shaderSharedFloat16AtomicMinMax, int shaderSharedFloat32AtomicMinMax, int shaderSharedFloat64AtomicMinMax, int shaderImageFloat32AtomicMinMax, int sparseImageFloat32AtomicMinMax)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderBufferFloat16Atomics = shaderBufferFloat16Atomics;
            this.shaderBufferFloat16AtomicAdd = shaderBufferFloat16AtomicAdd;
            this.shaderBufferFloat16AtomicMinMax = shaderBufferFloat16AtomicMinMax;
            this.shaderBufferFloat32AtomicMinMax = shaderBufferFloat32AtomicMinMax;
            this.shaderBufferFloat64AtomicMinMax = shaderBufferFloat64AtomicMinMax;
            this.shaderSharedFloat16Atomics = shaderSharedFloat16Atomics;
            this.shaderSharedFloat16AtomicAdd = shaderSharedFloat16AtomicAdd;
            this.shaderSharedFloat16AtomicMinMax = shaderSharedFloat16AtomicMinMax;
            this.shaderSharedFloat32AtomicMinMax = shaderSharedFloat32AtomicMinMax;
            this.shaderSharedFloat64AtomicMinMax = shaderSharedFloat64AtomicMinMax;
            this.shaderImageFloat32AtomicMinMax = shaderImageFloat32AtomicMinMax;
            this.sparseImageFloat32AtomicMinMax = sparseImageFloat32AtomicMinMax;
        }
    }
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVertexAttributeDivisorFeaturesKhr;
        public void* pNext;
        public int vertexAttributeInstanceRateDivisor;
        public int vertexAttributeInstanceRateZeroDivisor;
        public VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR(VkStructureType sType, void* pNext, int vertexAttributeInstanceRateDivisor, int vertexAttributeInstanceRateZeroDivisor)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.vertexAttributeInstanceRateDivisor = vertexAttributeInstanceRateDivisor;
            this.vertexAttributeInstanceRateZeroDivisor = vertexAttributeInstanceRateZeroDivisor;
        }
    }
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
    {
        public VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT()
        {
        }
    }
    public unsafe struct VkQueueFamilyCheckpointPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueueFamilyCheckpointPropertiesNv;
        public void* pNext;
        public VkPipelineStageFlagBits checkpointExecutionStageMask;
        public VkQueueFamilyCheckpointPropertiesNV(VkStructureType sType, void* pNext, VkPipelineStageFlagBits checkpointExecutionStageMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.checkpointExecutionStageMask = checkpointExecutionStageMask;
        }
    }
    public unsafe struct VkCheckpointDataNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeCheckpointDataNv;
        public void* pNext;
        public VkPipelineStageFlagBits stage;
        public void* pCheckpointMarker;
        public VkCheckpointDataNV(VkStructureType sType, void* pNext, VkPipelineStageFlagBits stage, void* pCheckpointMarker)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stage = stage;
            this.pCheckpointMarker = pCheckpointMarker;
        }
    }
    public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDepthStencilResolveProperties;
        public void* pNext;
        public VkResolveModeFlagBits supportedDepthResolveModes;
        public VkResolveModeFlagBits supportedStencilResolveModes;
        public int independentResolveNone;
        public int independentResolve;
        public VkPhysicalDeviceDepthStencilResolveProperties(VkStructureType sType, void* pNext, VkResolveModeFlagBits supportedDepthResolveModes, VkResolveModeFlagBits supportedStencilResolveModes, int independentResolveNone, int independentResolve)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.supportedDepthResolveModes = supportedDepthResolveModes;
            this.supportedStencilResolveModes = supportedStencilResolveModes;
            this.independentResolveNone = independentResolveNone;
            this.independentResolve = independentResolve;
        }
    }
    public unsafe struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
    {
        public VkPhysicalDeviceDepthStencilResolvePropertiesKHR()
        {
        }
    }
    public unsafe struct VkSubpassDescriptionDepthStencilResolve
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubpassDescriptionDepthStencilResolve;
        public void* pNext;
        public VkResolveModeFlagBits depthResolveMode;
        public VkResolveModeFlagBits stencilResolveMode;
        public VkAttachmentReference2* pDepthStencilResolveAttachment;
        public VkSubpassDescriptionDepthStencilResolve(VkStructureType sType, void* pNext, VkResolveModeFlagBits depthResolveMode, VkResolveModeFlagBits stencilResolveMode, VkAttachmentReference2* pDepthStencilResolveAttachment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.depthResolveMode = depthResolveMode;
            this.stencilResolveMode = stencilResolveMode;
            this.pDepthStencilResolveAttachment = pDepthStencilResolveAttachment;
        }
    }
    public unsafe struct VkSubpassDescriptionDepthStencilResolveKHR
    {
        public VkSubpassDescriptionDepthStencilResolveKHR()
        {
        }
    }
    public unsafe struct VkImageViewASTCDecodeModeEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageViewAstcDecodeModeExt;
        public void* pNext;
        public VkFormat decodeMode;
        public VkImageViewASTCDecodeModeEXT(VkStructureType sType, void* pNext, VkFormat decodeMode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.decodeMode = decodeMode;
        }
    }
    public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceAstcDecodeFeaturesExt;
        public void* pNext;
        public int decodeModeSharedExponent;
        public VkPhysicalDeviceASTCDecodeFeaturesEXT(VkStructureType sType, void* pNext, int decodeModeSharedExponent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.decodeModeSharedExponent = decodeModeSharedExponent;
        }
    }
    public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceTransformFeedbackFeaturesExt;
        public void* pNext;
        public int transformFeedback;
        public int geometryStreams;
        public VkPhysicalDeviceTransformFeedbackFeaturesEXT(VkStructureType sType, void* pNext, int transformFeedback, int geometryStreams)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.transformFeedback = transformFeedback;
            this.geometryStreams = geometryStreams;
        }
    }
    public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceTransformFeedbackPropertiesExt;
        public void* pNext;
        public uint maxTransformFeedbackStreams;
        public uint maxTransformFeedbackBuffers;
        public ulong maxTransformFeedbackBufferSize;
        public uint maxTransformFeedbackStreamDataSize;
        public uint maxTransformFeedbackBufferDataSize;
        public uint maxTransformFeedbackBufferDataStride;
        public int transformFeedbackQueries;
        public int transformFeedbackStreamsLinesTriangles;
        public int transformFeedbackRasterizationStreamSelect;
        public int transformFeedbackDraw;
        public VkPhysicalDeviceTransformFeedbackPropertiesEXT(VkStructureType sType, void* pNext, uint maxTransformFeedbackStreams, uint maxTransformFeedbackBuffers, ulong maxTransformFeedbackBufferSize, uint maxTransformFeedbackStreamDataSize, uint maxTransformFeedbackBufferDataSize, uint maxTransformFeedbackBufferDataStride, int transformFeedbackQueries, int transformFeedbackStreamsLinesTriangles, int transformFeedbackRasterizationStreamSelect, int transformFeedbackDraw)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxTransformFeedbackStreams = maxTransformFeedbackStreams;
            this.maxTransformFeedbackBuffers = maxTransformFeedbackBuffers;
            this.maxTransformFeedbackBufferSize = maxTransformFeedbackBufferSize;
            this.maxTransformFeedbackStreamDataSize = maxTransformFeedbackStreamDataSize;
            this.maxTransformFeedbackBufferDataSize = maxTransformFeedbackBufferDataSize;
            this.maxTransformFeedbackBufferDataStride = maxTransformFeedbackBufferDataStride;
            this.transformFeedbackQueries = transformFeedbackQueries;
            this.transformFeedbackStreamsLinesTriangles = transformFeedbackStreamsLinesTriangles;
            this.transformFeedbackRasterizationStreamSelect = transformFeedbackRasterizationStreamSelect;
            this.transformFeedbackDraw = transformFeedbackDraw;
        }
    }
    public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRasterizationStateStreamCreateInfoExt;
        public void* pNext;
        public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
        public uint rasterizationStream;
        public VkPipelineRasterizationStateStreamCreateInfoEXT(VkStructureType sType, void* pNext, VkPipelineRasterizationStateStreamCreateFlagsEXT flags, uint rasterizationStream)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.rasterizationStream = rasterizationStream;
        }
    }
    public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRepresentativeFragmentTestFeaturesNv;
        public void* pNext;
        public int representativeFragmentTest;
        public VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV(VkStructureType sType, void* pNext, int representativeFragmentTest)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.representativeFragmentTest = representativeFragmentTest;
        }
    }
    public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRepresentativeFragmentTestStateCreateInfoNv;
        public void* pNext;
        public int representativeFragmentTestEnable;
        public VkPipelineRepresentativeFragmentTestStateCreateInfoNV(VkStructureType sType, void* pNext, int representativeFragmentTestEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.representativeFragmentTestEnable = representativeFragmentTestEnable;
        }
    }
    public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExclusiveScissorFeaturesNv;
        public void* pNext;
        public int exclusiveScissor;
        public VkPhysicalDeviceExclusiveScissorFeaturesNV(VkStructureType sType, void* pNext, int exclusiveScissor)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.exclusiveScissor = exclusiveScissor;
        }
    }
    public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineViewportExclusiveScissorStateCreateInfoNv;
        public void* pNext;
        public uint exclusiveScissorCount;
        public VkRect2D* pExclusiveScissors;
        public VkPipelineViewportExclusiveScissorStateCreateInfoNV(VkStructureType sType, void* pNext, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.exclusiveScissorCount = exclusiveScissorCount;
            this.pExclusiveScissors = pExclusiveScissors;
        }
    }
    public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCornerSampledImageFeaturesNv;
        public void* pNext;
        public int cornerSampledImage;
        public VkPhysicalDeviceCornerSampledImageFeaturesNV(VkStructureType sType, void* pNext, int cornerSampledImage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.cornerSampledImage = cornerSampledImage;
        }
    }
    public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceComputeShaderDerivativesFeaturesNv;
        public void* pNext;
        public int computeDerivativeGroupQuads;
        public int computeDerivativeGroupLinear;
        public VkPhysicalDeviceComputeShaderDerivativesFeaturesNV(VkStructureType sType, void* pNext, int computeDerivativeGroupQuads, int computeDerivativeGroupLinear)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.computeDerivativeGroupQuads = computeDerivativeGroupQuads;
            this.computeDerivativeGroupLinear = computeDerivativeGroupLinear;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
    {
        public VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderImageFootprintFeaturesNv;
        public void* pNext;
        public int imageFootprint;
        public VkPhysicalDeviceShaderImageFootprintFeaturesNV(VkStructureType sType, void* pNext, int imageFootprint)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageFootprint = imageFootprint;
        }
    }
    public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv;
        public void* pNext;
        public int dedicatedAllocationImageAliasing;
        public VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV(VkStructureType sType, void* pNext, int dedicatedAllocationImageAliasing)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dedicatedAllocationImageAliasing = dedicatedAllocationImageAliasing;
        }
    }
    public unsafe struct VkPhysicalDeviceCopyMemoryIndirectFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCopyMemoryIndirectFeaturesNv;
        public void* pNext;
        public int indirectCopy;
        public VkPhysicalDeviceCopyMemoryIndirectFeaturesNV(VkStructureType sType, void* pNext, int indirectCopy)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.indirectCopy = indirectCopy;
        }
    }
    public unsafe struct VkPhysicalDeviceCopyMemoryIndirectPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCopyMemoryIndirectPropertiesNv;
        public void* pNext;
        public VkQueueFlagBits supportedQueues;
        public VkPhysicalDeviceCopyMemoryIndirectPropertiesNV(VkStructureType sType, void* pNext, VkQueueFlagBits supportedQueues)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.supportedQueues = supportedQueues;
        }
    }
    public unsafe struct VkPhysicalDeviceMemoryDecompressionFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMemoryDecompressionFeaturesNv;
        public void* pNext;
        public int memoryDecompression;
        public VkPhysicalDeviceMemoryDecompressionFeaturesNV(VkStructureType sType, void* pNext, int memoryDecompression)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryDecompression = memoryDecompression;
        }
    }
    public unsafe struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMemoryDecompressionPropertiesNv;
        public void* pNext;
        public VkMemoryDecompressionMethodFlagBitsNV decompressionMethods;
        public ulong maxDecompressionIndirectCount;
        public VkPhysicalDeviceMemoryDecompressionPropertiesNV(VkStructureType sType, void* pNext, VkMemoryDecompressionMethodFlagBitsNV decompressionMethods, ulong maxDecompressionIndirectCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.decompressionMethods = decompressionMethods;
            this.maxDecompressionIndirectCount = maxDecompressionIndirectCount;
        }
    }
    public unsafe struct VkShadingRatePaletteNV
    {
        public uint shadingRatePaletteEntryCount;
        public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
        public VkShadingRatePaletteNV(uint shadingRatePaletteEntryCount, VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries)
        {
            this.shadingRatePaletteEntryCount = shadingRatePaletteEntryCount;
            this.pShadingRatePaletteEntries = pShadingRatePaletteEntries;
        }
    }
    public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineViewportShadingRateImageStateCreateInfoNv;
        public void* pNext;
        public int shadingRateImageEnable;
        public uint viewportCount;
        public VkShadingRatePaletteNV* pShadingRatePalettes;
        public VkPipelineViewportShadingRateImageStateCreateInfoNV(VkStructureType sType, void* pNext, int shadingRateImageEnable, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shadingRateImageEnable = shadingRateImageEnable;
            this.viewportCount = viewportCount;
            this.pShadingRatePalettes = pShadingRatePalettes;
        }
    }
    public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShadingRateImageFeaturesNv;
        public void* pNext;
        public int shadingRateImage;
        public int shadingRateCoarseSampleOrder;
        public VkPhysicalDeviceShadingRateImageFeaturesNV(VkStructureType sType, void* pNext, int shadingRateImage, int shadingRateCoarseSampleOrder)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shadingRateImage = shadingRateImage;
            this.shadingRateCoarseSampleOrder = shadingRateCoarseSampleOrder;
        }
    }
    public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShadingRateImagePropertiesNv;
        public void* pNext;
        public VkExtent2D shadingRateTexelSize;
        public uint shadingRatePaletteSize;
        public uint shadingRateMaxCoarseSamples;
        public VkPhysicalDeviceShadingRateImagePropertiesNV(VkStructureType sType, void* pNext, VkExtent2D shadingRateTexelSize, uint shadingRatePaletteSize, uint shadingRateMaxCoarseSamples)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shadingRateTexelSize = shadingRateTexelSize;
            this.shadingRatePaletteSize = shadingRatePaletteSize;
            this.shadingRateMaxCoarseSamples = shadingRateMaxCoarseSamples;
        }
    }
    public unsafe struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceInvocationMaskFeaturesHuawei;
        public void* pNext;
        public int invocationMask;
        public VkPhysicalDeviceInvocationMaskFeaturesHUAWEI(VkStructureType sType, void* pNext, int invocationMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.invocationMask = invocationMask;
        }
    }
    public unsafe struct VkCoarseSampleLocationNV
    {
        public uint pixelX;
        public uint pixelY;
        public uint sample;
        public VkCoarseSampleLocationNV(uint pixelX, uint pixelY, uint sample)
        {
            this.pixelX = pixelX;
            this.pixelY = pixelY;
            this.sample = sample;
        }
    }
    public unsafe struct VkCoarseSampleOrderCustomNV
    {
        public VkShadingRatePaletteEntryNV shadingRate;
        public uint sampleCount;
        public uint sampleLocationCount;
        public VkCoarseSampleLocationNV* pSampleLocations;
        public VkCoarseSampleOrderCustomNV(VkShadingRatePaletteEntryNV shadingRate, uint sampleCount, uint sampleLocationCount, VkCoarseSampleLocationNV* pSampleLocations)
        {
            this.shadingRate = shadingRate;
            this.sampleCount = sampleCount;
            this.sampleLocationCount = sampleLocationCount;
            this.pSampleLocations = pSampleLocations;
        }
    }
    public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineViewportCoarseSampleOrderStateCreateInfoNv;
        public void* pNext;
        public VkCoarseSampleOrderTypeNV sampleOrderType;
        public uint customSampleOrderCount;
        public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
        public VkPipelineViewportCoarseSampleOrderStateCreateInfoNV(VkStructureType sType, void* pNext, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sampleOrderType = sampleOrderType;
            this.customSampleOrderCount = customSampleOrderCount;
            this.pCustomSampleOrders = pCustomSampleOrders;
        }
    }
    public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMeshShaderFeaturesNv;
        public void* pNext;
        public int taskShader;
        public int meshShader;
        public VkPhysicalDeviceMeshShaderFeaturesNV(VkStructureType sType, void* pNext, int taskShader, int meshShader)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.taskShader = taskShader;
            this.meshShader = meshShader;
        }
    }
    public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMeshShaderPropertiesNv;
        public void* pNext;
        public uint maxDrawMeshTasksCount;
        public uint maxTaskWorkGroupInvocations;
        public fixed uint maxTaskWorkGroupSize[3];
        public uint maxTaskTotalMemorySize;
        public uint maxTaskOutputCount;
        public uint maxMeshWorkGroupInvocations;
        public fixed uint maxMeshWorkGroupSize[3];
        public uint maxMeshTotalMemorySize;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
        public VkPhysicalDeviceMeshShaderPropertiesNV(){ }
    }
    public unsafe struct VkDrawMeshTasksIndirectCommandNV
    {
        public uint taskCount;
        public uint firstTask;
        public VkDrawMeshTasksIndirectCommandNV(uint taskCount, uint firstTask)
        {
            this.taskCount = taskCount;
            this.firstTask = firstTask;
        }
    }
    public unsafe struct VkPhysicalDeviceMeshShaderFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMeshShaderFeaturesExt;
        public void* pNext;
        public int taskShader;
        public int meshShader;
        public int multiviewMeshShader;
        public int primitiveFragmentShadingRateMeshShader;
        public int meshShaderQueries;
        public VkPhysicalDeviceMeshShaderFeaturesEXT(VkStructureType sType, void* pNext, int taskShader, int meshShader, int multiviewMeshShader, int primitiveFragmentShadingRateMeshShader, int meshShaderQueries)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.taskShader = taskShader;
            this.meshShader = meshShader;
            this.multiviewMeshShader = multiviewMeshShader;
            this.primitiveFragmentShadingRateMeshShader = primitiveFragmentShadingRateMeshShader;
            this.meshShaderQueries = meshShaderQueries;
        }
    }
    public unsafe struct VkPhysicalDeviceMeshShaderPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMeshShaderPropertiesExt;
        public void* pNext;
        public uint maxTaskWorkGroupTotalCount;
        public fixed uint maxTaskWorkGroupCount[3];
        public uint maxTaskWorkGroupInvocations;
        public fixed uint maxTaskWorkGroupSize[3];
        public uint maxTaskPayloadSize;
        public uint maxTaskSharedMemorySize;
        public uint maxTaskPayloadAndSharedMemorySize;
        public uint maxMeshWorkGroupTotalCount;
        public fixed uint maxMeshWorkGroupCount[3];
        public uint maxMeshWorkGroupInvocations;
        public fixed uint maxMeshWorkGroupSize[3];
        public uint maxMeshSharedMemorySize;
        public uint maxMeshPayloadAndSharedMemorySize;
        public uint maxMeshOutputMemorySize;
        public uint maxMeshPayloadAndOutputMemorySize;
        public uint maxMeshOutputComponents;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshOutputLayers;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
        public uint maxPreferredTaskWorkGroupInvocations;
        public uint maxPreferredMeshWorkGroupInvocations;
        public int prefersLocalInvocationVertexOutput;
        public int prefersLocalInvocationPrimitiveOutput;
        public int prefersCompactVertexOutput;
        public int prefersCompactPrimitiveOutput;
        public VkPhysicalDeviceMeshShaderPropertiesEXT(){ }
    }
    public unsafe struct VkDrawMeshTasksIndirectCommandEXT
    {
        public uint groupCountX;
        public uint groupCountY;
        public uint groupCountZ;
        public VkDrawMeshTasksIndirectCommandEXT(uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            this.groupCountX = groupCountX;
            this.groupCountY = groupCountY;
            this.groupCountZ = groupCountZ;
        }
    }
    public unsafe struct VkRayTracingShaderGroupCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeRayTracingShaderGroupCreateInfoNv;
        public void* pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
        public VkRayTracingShaderGroupCreateInfoNV(VkStructureType sType, void* pNext, VkRayTracingShaderGroupTypeKHR type, uint generalShader, uint closestHitShader, uint anyHitShader, uint intersectionShader)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.type = type;
            this.generalShader = generalShader;
            this.closestHitShader = closestHitShader;
            this.anyHitShader = anyHitShader;
            this.intersectionShader = intersectionShader;
        }
    }
    public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeRayTracingShaderGroupCreateInfoKhr;
        public void* pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
        public void* pShaderGroupCaptureReplayHandle;
        public VkRayTracingShaderGroupCreateInfoKHR(VkStructureType sType, void* pNext, VkRayTracingShaderGroupTypeKHR type, uint generalShader, uint closestHitShader, uint anyHitShader, uint intersectionShader, void* pShaderGroupCaptureReplayHandle)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.type = type;
            this.generalShader = generalShader;
            this.closestHitShader = closestHitShader;
            this.anyHitShader = anyHitShader;
            this.intersectionShader = intersectionShader;
            this.pShaderGroupCaptureReplayHandle = pShaderGroupCaptureReplayHandle;
        }
    }
    public unsafe struct VkRayTracingPipelineCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeRayTracingPipelineCreateInfoNv;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public uint groupCount;
        public VkRayTracingShaderGroupCreateInfoNV* pGroups;
        public uint maxRecursionDepth;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public VkRayTracingPipelineCreateInfoNV(VkStructureType sType, void* pNext, VkPipelineCreateFlagBits flags, uint stageCount, VkPipelineShaderStageCreateInfo* pStages, uint groupCount, VkRayTracingShaderGroupCreateInfoNV* pGroups, uint maxRecursionDepth, VkPipelineLayout layout, VkPipeline basePipelineHandle, int basePipelineIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.stageCount = stageCount;
            this.pStages = pStages;
            this.groupCount = groupCount;
            this.pGroups = pGroups;
            this.maxRecursionDepth = maxRecursionDepth;
            this.layout = layout;
            this.basePipelineHandle = basePipelineHandle;
            this.basePipelineIndex = basePipelineIndex;
        }
    }
    public unsafe struct VkRayTracingPipelineCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeRayTracingPipelineCreateInfoKhr;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public uint groupCount;
        public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
        public uint maxPipelineRayRecursionDepth;
        public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
        public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
        public VkPipelineDynamicStateCreateInfo* pDynamicState;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public VkRayTracingPipelineCreateInfoKHR(VkStructureType sType, void* pNext, VkPipelineCreateFlagBits flags, uint stageCount, VkPipelineShaderStageCreateInfo* pStages, uint groupCount, VkRayTracingShaderGroupCreateInfoKHR* pGroups, uint maxPipelineRayRecursionDepth, VkPipelineLibraryCreateInfoKHR* pLibraryInfo, VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface, VkPipelineDynamicStateCreateInfo* pDynamicState, VkPipelineLayout layout, VkPipeline basePipelineHandle, int basePipelineIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.stageCount = stageCount;
            this.pStages = pStages;
            this.groupCount = groupCount;
            this.pGroups = pGroups;
            this.maxPipelineRayRecursionDepth = maxPipelineRayRecursionDepth;
            this.pLibraryInfo = pLibraryInfo;
            this.pLibraryInterface = pLibraryInterface;
            this.pDynamicState = pDynamicState;
            this.layout = layout;
            this.basePipelineHandle = basePipelineHandle;
            this.basePipelineIndex = basePipelineIndex;
        }
    }
    public unsafe struct VkGeometryTrianglesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeGeometryTrianglesNv;
        public void* pNext;
        public VkBuffer vertexData;
        public ulong vertexOffset;
        public uint vertexCount;
        public ulong vertexStride;
        public VkFormat vertexFormat;
        public VkBuffer indexData;
        public ulong indexOffset;
        public uint indexCount;
        public VkIndexType indexType;
        public VkBuffer transformData;
        public ulong transformOffset;
        public VkGeometryTrianglesNV(VkStructureType sType, void* pNext, VkBuffer vertexData, ulong vertexOffset, uint vertexCount, ulong vertexStride, VkFormat vertexFormat, VkBuffer indexData, ulong indexOffset, uint indexCount, VkIndexType indexType, VkBuffer transformData, ulong transformOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.vertexData = vertexData;
            this.vertexOffset = vertexOffset;
            this.vertexCount = vertexCount;
            this.vertexStride = vertexStride;
            this.vertexFormat = vertexFormat;
            this.indexData = indexData;
            this.indexOffset = indexOffset;
            this.indexCount = indexCount;
            this.indexType = indexType;
            this.transformData = transformData;
            this.transformOffset = transformOffset;
        }
    }
    public unsafe struct VkGeometryAABBNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeGeometryAabbNv;
        public void* pNext;
        public VkBuffer aabbData;
        public uint numAABBs;
        public uint stride;
        public ulong offset;
        public VkGeometryAABBNV(VkStructureType sType, void* pNext, VkBuffer aabbData, uint numAABBs, uint stride, ulong offset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.aabbData = aabbData;
            this.numAABBs = numAABBs;
            this.stride = stride;
            this.offset = offset;
        }
    }
    public unsafe struct VkGeometryDataNV
    {
        public VkGeometryTrianglesNV triangles;
        public VkGeometryAABBNV aabbs;
        public VkGeometryDataNV(VkGeometryTrianglesNV triangles, VkGeometryAABBNV aabbs)
        {
            this.triangles = triangles;
            this.aabbs = aabbs;
        }
    }
    public unsafe struct VkGeometryNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeGeometryNv;
        public void* pNext;
        public VkGeometryTypeKHR geometryType;
        public VkGeometryDataNV geometry;
        public VkGeometryFlagBitsKHR flags;
        public VkGeometryNV(VkStructureType sType, void* pNext, VkGeometryTypeKHR geometryType, VkGeometryDataNV geometry, VkGeometryFlagBitsKHR flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.geometryType = geometryType;
            this.geometry = geometry;
            this.flags = flags;
        }
    }
    public unsafe struct VkAccelerationStructureInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureInfoNv;
        public void* pNext;
        public VkAccelerationStructureTypeKHR type;
        public VkBuildAccelerationStructureFlagsNV flags;
        public uint instanceCount;
        public uint geometryCount;
        public VkGeometryNV* pGeometries;
        public VkAccelerationStructureInfoNV(VkStructureType sType, void* pNext, VkAccelerationStructureTypeKHR type, VkBuildAccelerationStructureFlagsNV flags, uint instanceCount, uint geometryCount, VkGeometryNV* pGeometries)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.type = type;
            this.flags = flags;
            this.instanceCount = instanceCount;
            this.geometryCount = geometryCount;
            this.pGeometries = pGeometries;
        }
    }
    public unsafe struct VkAccelerationStructureCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureCreateInfoNv;
        public void* pNext;
        public ulong compactedSize;
        public VkAccelerationStructureInfoNV info;
        public VkAccelerationStructureCreateInfoNV(VkStructureType sType, void* pNext, ulong compactedSize, VkAccelerationStructureInfoNV info)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.compactedSize = compactedSize;
            this.info = info;
        }
    }
    public unsafe struct VkBindAccelerationStructureMemoryInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindAccelerationStructureMemoryInfoNv;
        public void* pNext;
        public VkAccelerationStructureNV accelerationStructure;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public VkBindAccelerationStructureMemoryInfoNV(VkStructureType sType, void* pNext, VkAccelerationStructureNV accelerationStructure, VkDeviceMemory memory, ulong memoryOffset, uint deviceIndexCount, uint* pDeviceIndices)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.accelerationStructure = accelerationStructure;
            this.memory = memory;
            this.memoryOffset = memoryOffset;
            this.deviceIndexCount = deviceIndexCount;
            this.pDeviceIndices = pDeviceIndices;
        }
    }
    public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeWriteDescriptorSetAccelerationStructureKhr;
        public void* pNext;
        public uint accelerationStructureCount;
        public VkAccelerationStructureKHR* pAccelerationStructures;
        public VkWriteDescriptorSetAccelerationStructureKHR(VkStructureType sType, void* pNext, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.accelerationStructureCount = accelerationStructureCount;
            this.pAccelerationStructures = pAccelerationStructures;
        }
    }
    public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeWriteDescriptorSetAccelerationStructureNv;
        public void* pNext;
        public uint accelerationStructureCount;
        public VkAccelerationStructureNV* pAccelerationStructures;
        public VkWriteDescriptorSetAccelerationStructureNV(VkStructureType sType, void* pNext, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.accelerationStructureCount = accelerationStructureCount;
            this.pAccelerationStructures = pAccelerationStructures;
        }
    }
    public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureMemoryRequirementsInfoNv;
        public void* pNext;
        public VkAccelerationStructureMemoryRequirementsTypeNV type;
        public VkAccelerationStructureNV accelerationStructure;
        public VkAccelerationStructureMemoryRequirementsInfoNV(VkStructureType sType, void* pNext, VkAccelerationStructureMemoryRequirementsTypeNV type, VkAccelerationStructureNV accelerationStructure)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.type = type;
            this.accelerationStructure = accelerationStructure;
        }
    }
    public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceAccelerationStructureFeaturesKhr;
        public void* pNext;
        public int accelerationStructure;
        public int accelerationStructureCaptureReplay;
        public int accelerationStructureIndirectBuild;
        public int accelerationStructureHostCommands;
        public int descriptorBindingAccelerationStructureUpdateAfterBind;
        public VkPhysicalDeviceAccelerationStructureFeaturesKHR(VkStructureType sType, void* pNext, int accelerationStructure, int accelerationStructureCaptureReplay, int accelerationStructureIndirectBuild, int accelerationStructureHostCommands, int descriptorBindingAccelerationStructureUpdateAfterBind)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.accelerationStructure = accelerationStructure;
            this.accelerationStructureCaptureReplay = accelerationStructureCaptureReplay;
            this.accelerationStructureIndirectBuild = accelerationStructureIndirectBuild;
            this.accelerationStructureHostCommands = accelerationStructureHostCommands;
            this.descriptorBindingAccelerationStructureUpdateAfterBind = descriptorBindingAccelerationStructureUpdateAfterBind;
        }
    }
    public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayTracingPipelineFeaturesKhr;
        public void* pNext;
        public int rayTracingPipeline;
        public int rayTracingPipelineShaderGroupHandleCaptureReplay;
        public int rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
        public int rayTracingPipelineTraceRaysIndirect;
        public int rayTraversalPrimitiveCulling;
        public VkPhysicalDeviceRayTracingPipelineFeaturesKHR(VkStructureType sType, void* pNext, int rayTracingPipeline, int rayTracingPipelineShaderGroupHandleCaptureReplay, int rayTracingPipelineShaderGroupHandleCaptureReplayMixed, int rayTracingPipelineTraceRaysIndirect, int rayTraversalPrimitiveCulling)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rayTracingPipeline = rayTracingPipeline;
            this.rayTracingPipelineShaderGroupHandleCaptureReplay = rayTracingPipelineShaderGroupHandleCaptureReplay;
            this.rayTracingPipelineShaderGroupHandleCaptureReplayMixed = rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
            this.rayTracingPipelineTraceRaysIndirect = rayTracingPipelineTraceRaysIndirect;
            this.rayTraversalPrimitiveCulling = rayTraversalPrimitiveCulling;
        }
    }
    public unsafe struct VkPhysicalDeviceRayQueryFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayQueryFeaturesKhr;
        public void* pNext;
        public int rayQuery;
        public VkPhysicalDeviceRayQueryFeaturesKHR(VkStructureType sType, void* pNext, int rayQuery)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rayQuery = rayQuery;
        }
    }
    public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceAccelerationStructurePropertiesKhr;
        public void* pNext;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxPrimitiveCount;
        public uint maxPerStageDescriptorAccelerationStructures;
        public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
        public uint maxDescriptorSetAccelerationStructures;
        public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;
        public uint minAccelerationStructureScratchOffsetAlignment;
        public VkPhysicalDeviceAccelerationStructurePropertiesKHR(VkStructureType sType, void* pNext, ulong maxGeometryCount, ulong maxInstanceCount, ulong maxPrimitiveCount, uint maxPerStageDescriptorAccelerationStructures, uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures, uint maxDescriptorSetAccelerationStructures, uint maxDescriptorSetUpdateAfterBindAccelerationStructures, uint minAccelerationStructureScratchOffsetAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxGeometryCount = maxGeometryCount;
            this.maxInstanceCount = maxInstanceCount;
            this.maxPrimitiveCount = maxPrimitiveCount;
            this.maxPerStageDescriptorAccelerationStructures = maxPerStageDescriptorAccelerationStructures;
            this.maxPerStageDescriptorUpdateAfterBindAccelerationStructures = maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
            this.maxDescriptorSetAccelerationStructures = maxDescriptorSetAccelerationStructures;
            this.maxDescriptorSetUpdateAfterBindAccelerationStructures = maxDescriptorSetUpdateAfterBindAccelerationStructures;
            this.minAccelerationStructureScratchOffsetAlignment = minAccelerationStructureScratchOffsetAlignment;
        }
    }
    public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayTracingPipelinePropertiesKhr;
        public void* pNext;
        public uint shaderGroupHandleSize;
        public uint maxRayRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public uint shaderGroupHandleCaptureReplaySize;
        public uint maxRayDispatchInvocationCount;
        public uint shaderGroupHandleAlignment;
        public uint maxRayHitAttributeSize;
        public VkPhysicalDeviceRayTracingPipelinePropertiesKHR(VkStructureType sType, void* pNext, uint shaderGroupHandleSize, uint maxRayRecursionDepth, uint maxShaderGroupStride, uint shaderGroupBaseAlignment, uint shaderGroupHandleCaptureReplaySize, uint maxRayDispatchInvocationCount, uint shaderGroupHandleAlignment, uint maxRayHitAttributeSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderGroupHandleSize = shaderGroupHandleSize;
            this.maxRayRecursionDepth = maxRayRecursionDepth;
            this.maxShaderGroupStride = maxShaderGroupStride;
            this.shaderGroupBaseAlignment = shaderGroupBaseAlignment;
            this.shaderGroupHandleCaptureReplaySize = shaderGroupHandleCaptureReplaySize;
            this.maxRayDispatchInvocationCount = maxRayDispatchInvocationCount;
            this.shaderGroupHandleAlignment = shaderGroupHandleAlignment;
            this.maxRayHitAttributeSize = maxRayHitAttributeSize;
        }
    }
    public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayTracingPropertiesNv;
        public void* pNext;
        public uint shaderGroupHandleSize;
        public uint maxRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxTriangleCount;
        public uint maxDescriptorSetAccelerationStructures;
        public VkPhysicalDeviceRayTracingPropertiesNV(VkStructureType sType, void* pNext, uint shaderGroupHandleSize, uint maxRecursionDepth, uint maxShaderGroupStride, uint shaderGroupBaseAlignment, ulong maxGeometryCount, ulong maxInstanceCount, ulong maxTriangleCount, uint maxDescriptorSetAccelerationStructures)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderGroupHandleSize = shaderGroupHandleSize;
            this.maxRecursionDepth = maxRecursionDepth;
            this.maxShaderGroupStride = maxShaderGroupStride;
            this.shaderGroupBaseAlignment = shaderGroupBaseAlignment;
            this.maxGeometryCount = maxGeometryCount;
            this.maxInstanceCount = maxInstanceCount;
            this.maxTriangleCount = maxTriangleCount;
            this.maxDescriptorSetAccelerationStructures = maxDescriptorSetAccelerationStructures;
        }
    }
    public unsafe struct VkStridedDeviceAddressRegionKHR
    {
        public ulong deviceAddress;
        public ulong stride;
        public ulong size;
        public VkStridedDeviceAddressRegionKHR(ulong deviceAddress, ulong stride, ulong size)
        {
            this.deviceAddress = deviceAddress;
            this.stride = stride;
            this.size = size;
        }
    }
    public unsafe struct VkTraceRaysIndirectCommandKHR
    {
        public uint width;
        public uint height;
        public uint depth;
        public VkTraceRaysIndirectCommandKHR(uint width, uint height, uint depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }
    public unsafe struct VkTraceRaysIndirectCommand2KHR
    {
        public ulong raygenShaderRecordAddress;
        public ulong raygenShaderRecordSize;
        public ulong missShaderBindingTableAddress;
        public ulong missShaderBindingTableSize;
        public ulong missShaderBindingTableStride;
        public ulong hitShaderBindingTableAddress;
        public ulong hitShaderBindingTableSize;
        public ulong hitShaderBindingTableStride;
        public ulong callableShaderBindingTableAddress;
        public ulong callableShaderBindingTableSize;
        public ulong callableShaderBindingTableStride;
        public uint width;
        public uint height;
        public uint depth;
        public VkTraceRaysIndirectCommand2KHR(ulong raygenShaderRecordAddress, ulong raygenShaderRecordSize, ulong missShaderBindingTableAddress, ulong missShaderBindingTableSize, ulong missShaderBindingTableStride, ulong hitShaderBindingTableAddress, ulong hitShaderBindingTableSize, ulong hitShaderBindingTableStride, ulong callableShaderBindingTableAddress, ulong callableShaderBindingTableSize, ulong callableShaderBindingTableStride, uint width, uint height, uint depth)
        {
            this.raygenShaderRecordAddress = raygenShaderRecordAddress;
            this.raygenShaderRecordSize = raygenShaderRecordSize;
            this.missShaderBindingTableAddress = missShaderBindingTableAddress;
            this.missShaderBindingTableSize = missShaderBindingTableSize;
            this.missShaderBindingTableStride = missShaderBindingTableStride;
            this.hitShaderBindingTableAddress = hitShaderBindingTableAddress;
            this.hitShaderBindingTableSize = hitShaderBindingTableSize;
            this.hitShaderBindingTableStride = hitShaderBindingTableStride;
            this.callableShaderBindingTableAddress = callableShaderBindingTableAddress;
            this.callableShaderBindingTableSize = callableShaderBindingTableSize;
            this.callableShaderBindingTableStride = callableShaderBindingTableStride;
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }
    public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayTracingMaintenance1FeaturesKhr;
        public void* pNext;
        public int rayTracingMaintenance1;
        public int rayTracingPipelineTraceRaysIndirect2;
        public VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR(VkStructureType sType, void* pNext, int rayTracingMaintenance1, int rayTracingPipelineTraceRaysIndirect2)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rayTracingMaintenance1 = rayTracingMaintenance1;
            this.rayTracingPipelineTraceRaysIndirect2 = rayTracingPipelineTraceRaysIndirect2;
        }
    }
    public unsafe struct VkDrmFormatModifierPropertiesListEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDrmFormatModifierPropertiesListExt;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
        public VkDrmFormatModifierPropertiesListEXT(VkStructureType sType, void* pNext, uint drmFormatModifierCount, VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.drmFormatModifierCount = drmFormatModifierCount;
            this.pDrmFormatModifierProperties = pDrmFormatModifierProperties;
        }
    }
    public unsafe struct VkDrmFormatModifierPropertiesEXT
    {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkFormatFeatureFlagBits drmFormatModifierTilingFeatures;
        public VkDrmFormatModifierPropertiesEXT(ulong drmFormatModifier, uint drmFormatModifierPlaneCount, VkFormatFeatureFlagBits drmFormatModifierTilingFeatures)
        {
            this.drmFormatModifier = drmFormatModifier;
            this.drmFormatModifierPlaneCount = drmFormatModifierPlaneCount;
            this.drmFormatModifierTilingFeatures = drmFormatModifierTilingFeatures;
        }
    }
    public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageDrmFormatModifierInfoExt;
        public void* pNext;
        public ulong drmFormatModifier;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkPhysicalDeviceImageDrmFormatModifierInfoEXT(VkStructureType sType, void* pNext, ulong drmFormatModifier, VkSharingMode sharingMode, uint queueFamilyIndexCount, uint* pQueueFamilyIndices)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.drmFormatModifier = drmFormatModifier;
            this.sharingMode = sharingMode;
            this.queueFamilyIndexCount = queueFamilyIndexCount;
            this.pQueueFamilyIndices = pQueueFamilyIndices;
        }
    }
    public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageDrmFormatModifierListCreateInfoExt;
        public void* pNext;
        public uint drmFormatModifierCount;
        public ulong* pDrmFormatModifiers;
        public VkImageDrmFormatModifierListCreateInfoEXT(VkStructureType sType, void* pNext, uint drmFormatModifierCount, ulong* pDrmFormatModifiers)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.drmFormatModifierCount = drmFormatModifierCount;
            this.pDrmFormatModifiers = pDrmFormatModifiers;
        }
    }
    public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageDrmFormatModifierExplicitCreateInfoExt;
        public void* pNext;
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkSubresourceLayout* pPlaneLayouts;
        public VkImageDrmFormatModifierExplicitCreateInfoEXT(VkStructureType sType, void* pNext, ulong drmFormatModifier, uint drmFormatModifierPlaneCount, VkSubresourceLayout* pPlaneLayouts)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.drmFormatModifier = drmFormatModifier;
            this.drmFormatModifierPlaneCount = drmFormatModifierPlaneCount;
            this.pPlaneLayouts = pPlaneLayouts;
        }
    }
    public unsafe struct VkImageDrmFormatModifierPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageDrmFormatModifierPropertiesExt;
        public void* pNext;
        public ulong drmFormatModifier;
        public VkImageDrmFormatModifierPropertiesEXT(VkStructureType sType, void* pNext, ulong drmFormatModifier)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.drmFormatModifier = drmFormatModifier;
        }
    }
    public unsafe struct VkImageStencilUsageCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageStencilUsageCreateInfo;
        public void* pNext;
        public VkImageUsageFlagBits stencilUsage;
        public VkImageStencilUsageCreateInfo(VkStructureType sType, void* pNext, VkImageUsageFlagBits stencilUsage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stencilUsage = stencilUsage;
        }
    }
    public unsafe struct VkImageStencilUsageCreateInfoEXT
    {
        public VkImageStencilUsageCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceMemoryOverallocationCreateInfoAmd;
        public void* pNext;
        public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
        public VkDeviceMemoryOverallocationCreateInfoAMD(VkStructureType sType, void* pNext, VkMemoryOverallocationBehaviorAMD overallocationBehavior)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.overallocationBehavior = overallocationBehavior;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentDensityMapFeaturesExt;
        public void* pNext;
        public int fragmentDensityMap;
        public int fragmentDensityMapDynamic;
        public int fragmentDensityMapNonSubsampledImages;
        public VkPhysicalDeviceFragmentDensityMapFeaturesEXT(VkStructureType sType, void* pNext, int fragmentDensityMap, int fragmentDensityMapDynamic, int fragmentDensityMapNonSubsampledImages)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fragmentDensityMap = fragmentDensityMap;
            this.fragmentDensityMapDynamic = fragmentDensityMapDynamic;
            this.fragmentDensityMapNonSubsampledImages = fragmentDensityMapNonSubsampledImages;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentDensityMap2FeaturesExt;
        public void* pNext;
        public int fragmentDensityMapDeferred;
        public VkPhysicalDeviceFragmentDensityMap2FeaturesEXT(VkStructureType sType, void* pNext, int fragmentDensityMapDeferred)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fragmentDensityMapDeferred = fragmentDensityMapDeferred;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentDensityMapOffsetFeaturesQcom;
        public void* pNext;
        public int fragmentDensityMapOffset;
        public VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM(VkStructureType sType, void* pNext, int fragmentDensityMapOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fragmentDensityMapOffset = fragmentDensityMapOffset;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentDensityMapPropertiesExt;
        public void* pNext;
        public VkExtent2D minFragmentDensityTexelSize;
        public VkExtent2D maxFragmentDensityTexelSize;
        public int fragmentDensityInvocations;
        public VkPhysicalDeviceFragmentDensityMapPropertiesEXT(VkStructureType sType, void* pNext, VkExtent2D minFragmentDensityTexelSize, VkExtent2D maxFragmentDensityTexelSize, int fragmentDensityInvocations)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minFragmentDensityTexelSize = minFragmentDensityTexelSize;
            this.maxFragmentDensityTexelSize = maxFragmentDensityTexelSize;
            this.fragmentDensityInvocations = fragmentDensityInvocations;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentDensityMap2PropertiesExt;
        public void* pNext;
        public int subsampledLoads;
        public int subsampledCoarseReconstructionEarlyAccess;
        public uint maxSubsampledArrayLayers;
        public uint maxDescriptorSetSubsampledSamplers;
        public VkPhysicalDeviceFragmentDensityMap2PropertiesEXT(VkStructureType sType, void* pNext, int subsampledLoads, int subsampledCoarseReconstructionEarlyAccess, uint maxSubsampledArrayLayers, uint maxDescriptorSetSubsampledSamplers)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.subsampledLoads = subsampledLoads;
            this.subsampledCoarseReconstructionEarlyAccess = subsampledCoarseReconstructionEarlyAccess;
            this.maxSubsampledArrayLayers = maxSubsampledArrayLayers;
            this.maxDescriptorSetSubsampledSamplers = maxDescriptorSetSubsampledSamplers;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentDensityMapOffsetPropertiesQcom;
        public void* pNext;
        public VkExtent2D fragmentDensityOffsetGranularity;
        public VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM(VkStructureType sType, void* pNext, VkExtent2D fragmentDensityOffsetGranularity)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fragmentDensityOffsetGranularity = fragmentDensityOffsetGranularity;
        }
    }
    public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassFragmentDensityMapCreateInfoExt;
        public void* pNext;
        public VkAttachmentReference fragmentDensityMapAttachment;
        public VkRenderPassFragmentDensityMapCreateInfoEXT(VkStructureType sType, void* pNext, VkAttachmentReference fragmentDensityMapAttachment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fragmentDensityMapAttachment = fragmentDensityMapAttachment;
        }
    }
    public unsafe struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubpassFragmentDensityMapOffsetEndInfoQcom;
        public void* pNext;
        public uint fragmentDensityOffsetCount;
        public VkOffset2D* pFragmentDensityOffsets;
        public VkSubpassFragmentDensityMapOffsetEndInfoQCOM(VkStructureType sType, void* pNext, uint fragmentDensityOffsetCount, VkOffset2D* pFragmentDensityOffsets)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fragmentDensityOffsetCount = fragmentDensityOffsetCount;
            this.pFragmentDensityOffsets = pFragmentDensityOffsets;
        }
    }
    public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceScalarBlockLayoutFeatures;
        public void* pNext;
        public int scalarBlockLayout;
        public VkPhysicalDeviceScalarBlockLayoutFeatures(VkStructureType sType, void* pNext, int scalarBlockLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.scalarBlockLayout = scalarBlockLayout;
        }
    }
    public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT
    {
        public VkPhysicalDeviceScalarBlockLayoutFeaturesEXT()
        {
        }
    }
    public unsafe struct VkSurfaceProtectedCapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfaceProtectedCapabilitiesKhr;
        public void* pNext;
        public int supportsProtected;
        public VkSurfaceProtectedCapabilitiesKHR(VkStructureType sType, void* pNext, int supportsProtected)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.supportsProtected = supportsProtected;
        }
    }
    public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceUniformBufferStandardLayoutFeatures;
        public void* pNext;
        public int uniformBufferStandardLayout;
        public VkPhysicalDeviceUniformBufferStandardLayoutFeatures(VkStructureType sType, void* pNext, int uniformBufferStandardLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.uniformBufferStandardLayout = uniformBufferStandardLayout;
        }
    }
    public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR
    {
        public VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDepthClipEnableFeaturesExt;
        public void* pNext;
        public int depthClipEnable;
        public VkPhysicalDeviceDepthClipEnableFeaturesEXT(VkStructureType sType, void* pNext, int depthClipEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.depthClipEnable = depthClipEnable;
        }
    }
    public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRasterizationDepthClipStateCreateInfoExt;
        public void* pNext;
        public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
        public int depthClipEnable;
        public VkPipelineRasterizationDepthClipStateCreateInfoEXT(VkStructureType sType, void* pNext, VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags, int depthClipEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.depthClipEnable = depthClipEnable;
        }
    }
    public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMemoryBudgetPropertiesExt;
        public void* pNext;
        public fixed ulong heapBudget[16];
        public fixed ulong heapUsage[16];
        public VkPhysicalDeviceMemoryBudgetPropertiesEXT(){ }
    }
    public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMemoryPriorityFeaturesExt;
        public void* pNext;
        public int memoryPriority;
        public VkPhysicalDeviceMemoryPriorityFeaturesEXT(VkStructureType sType, void* pNext, int memoryPriority)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryPriority = memoryPriority;
        }
    }
    public unsafe struct VkMemoryPriorityAllocateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryPriorityAllocateInfoExt;
        public void* pNext;
        public float priority;
        public VkMemoryPriorityAllocateInfoEXT(VkStructureType sType, void* pNext, float priority)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.priority = priority;
        }
    }
    public unsafe struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePageableDeviceLocalMemoryFeaturesExt;
        public void* pNext;
        public int pageableDeviceLocalMemory;
        public VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT(VkStructureType sType, void* pNext, int pageableDeviceLocalMemory)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pageableDeviceLocalMemory = pageableDeviceLocalMemory;
        }
    }
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceBufferDeviceAddressFeatures;
        public void* pNext;
        public int bufferDeviceAddress;
        public int bufferDeviceAddressCaptureReplay;
        public int bufferDeviceAddressMultiDevice;
        public VkPhysicalDeviceBufferDeviceAddressFeatures(VkStructureType sType, void* pNext, int bufferDeviceAddress, int bufferDeviceAddressCaptureReplay, int bufferDeviceAddressMultiDevice)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.bufferDeviceAddress = bufferDeviceAddress;
            this.bufferDeviceAddressCaptureReplay = bufferDeviceAddressCaptureReplay;
            this.bufferDeviceAddressMultiDevice = bufferDeviceAddressMultiDevice;
        }
    }
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesKHR
    {
        public VkPhysicalDeviceBufferDeviceAddressFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceBufferDeviceAddressFeaturesExt;
        public void* pNext;
        public int bufferDeviceAddress;
        public int bufferDeviceAddressCaptureReplay;
        public int bufferDeviceAddressMultiDevice;
        public VkPhysicalDeviceBufferDeviceAddressFeaturesEXT(VkStructureType sType, void* pNext, int bufferDeviceAddress, int bufferDeviceAddressCaptureReplay, int bufferDeviceAddressMultiDevice)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.bufferDeviceAddress = bufferDeviceAddress;
            this.bufferDeviceAddressCaptureReplay = bufferDeviceAddressCaptureReplay;
            this.bufferDeviceAddressMultiDevice = bufferDeviceAddressMultiDevice;
        }
    }
    public unsafe struct VkPhysicalDeviceBufferAddressFeaturesEXT
    {
        public VkPhysicalDeviceBufferAddressFeaturesEXT()
        {
        }
    }
    public unsafe struct VkBufferDeviceAddressInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferDeviceAddressInfo;
        public void* pNext;
        public VkBuffer buffer;
        public VkBufferDeviceAddressInfo(VkStructureType sType, void* pNext, VkBuffer buffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.buffer = buffer;
        }
    }
    public unsafe struct VkBufferDeviceAddressInfoKHR
    {
        public VkBufferDeviceAddressInfoKHR()
        {
        }
    }
    public unsafe struct VkBufferDeviceAddressInfoEXT
    {
        public VkBufferDeviceAddressInfoEXT()
        {
        }
    }
    public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferOpaqueCaptureAddressCreateInfo;
        public void* pNext;
        public ulong opaqueCaptureAddress;
        public VkBufferOpaqueCaptureAddressCreateInfo(VkStructureType sType, void* pNext, ulong opaqueCaptureAddress)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.opaqueCaptureAddress = opaqueCaptureAddress;
        }
    }
    public unsafe struct VkBufferOpaqueCaptureAddressCreateInfoKHR
    {
        public VkBufferOpaqueCaptureAddressCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkBufferDeviceAddressCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferDeviceAddressCreateInfoExt;
        public void* pNext;
        public ulong deviceAddress;
        public VkBufferDeviceAddressCreateInfoEXT(VkStructureType sType, void* pNext, ulong deviceAddress)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceAddress = deviceAddress;
        }
    }
    public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageViewImageFormatInfoExt;
        public void* pNext;
        public VkImageViewType imageViewType;
        public VkPhysicalDeviceImageViewImageFormatInfoEXT(VkStructureType sType, void* pNext, VkImageViewType imageViewType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageViewType = imageViewType;
        }
    }
    public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeFilterCubicImageViewImageFormatPropertiesExt;
        public void* pNext;
        public int filterCubic;
        public int filterCubicMinmax;
        public VkFilterCubicImageViewImageFormatPropertiesEXT(VkStructureType sType, void* pNext, int filterCubic, int filterCubicMinmax)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.filterCubic = filterCubic;
            this.filterCubicMinmax = filterCubicMinmax;
        }
    }
    public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImagelessFramebufferFeatures;
        public void* pNext;
        public int imagelessFramebuffer;
        public VkPhysicalDeviceImagelessFramebufferFeatures(VkStructureType sType, void* pNext, int imagelessFramebuffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imagelessFramebuffer = imagelessFramebuffer;
        }
    }
    public unsafe struct VkPhysicalDeviceImagelessFramebufferFeaturesKHR
    {
        public VkPhysicalDeviceImagelessFramebufferFeaturesKHR()
        {
        }
    }
    public unsafe struct VkFramebufferAttachmentsCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeFramebufferAttachmentsCreateInfo;
        public void* pNext;
        public uint attachmentImageInfoCount;
        public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
        public VkFramebufferAttachmentsCreateInfo(VkStructureType sType, void* pNext, uint attachmentImageInfoCount, VkFramebufferAttachmentImageInfo* pAttachmentImageInfos)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.attachmentImageInfoCount = attachmentImageInfoCount;
            this.pAttachmentImageInfos = pAttachmentImageInfos;
        }
    }
    public unsafe struct VkFramebufferAttachmentsCreateInfoKHR
    {
        public VkFramebufferAttachmentsCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkFramebufferAttachmentImageInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeFramebufferAttachmentImageInfo;
        public void* pNext;
        public VkImageCreateFlagBits flags;
        public VkImageUsageFlagBits usage;
        public uint width;
        public uint height;
        public uint layerCount;
        public uint viewFormatCount;
        public VkFormat* pViewFormats;
        public VkFramebufferAttachmentImageInfo(VkStructureType sType, void* pNext, VkImageCreateFlagBits flags, VkImageUsageFlagBits usage, uint width, uint height, uint layerCount, uint viewFormatCount, VkFormat* pViewFormats)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.usage = usage;
            this.width = width;
            this.height = height;
            this.layerCount = layerCount;
            this.viewFormatCount = viewFormatCount;
            this.pViewFormats = pViewFormats;
        }
    }
    public unsafe struct VkFramebufferAttachmentImageInfoKHR
    {
        public VkFramebufferAttachmentImageInfoKHR()
        {
        }
    }
    public unsafe struct VkRenderPassAttachmentBeginInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassAttachmentBeginInfo;
        public void* pNext;
        public uint attachmentCount;
        public VkImageView* pAttachments;
        public VkRenderPassAttachmentBeginInfo(VkStructureType sType, void* pNext, uint attachmentCount, VkImageView* pAttachments)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.attachmentCount = attachmentCount;
            this.pAttachments = pAttachments;
        }
    }
    public unsafe struct VkRenderPassAttachmentBeginInfoKHR
    {
        public VkRenderPassAttachmentBeginInfoKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceTextureCompressionAstcHdrFeatures;
        public void* pNext;
        public int textureCompressionASTC_HDR;
        public VkPhysicalDeviceTextureCompressionASTCHDRFeatures(VkStructureType sType, void* pNext, int textureCompressionASTC_HDR)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.textureCompressionASTC_HDR = textureCompressionASTC_HDR;
        }
    }
    public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
    {
        public VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCooperativeMatrixFeaturesNv;
        public void* pNext;
        public int cooperativeMatrix;
        public int cooperativeMatrixRobustBufferAccess;
        public VkPhysicalDeviceCooperativeMatrixFeaturesNV(VkStructureType sType, void* pNext, int cooperativeMatrix, int cooperativeMatrixRobustBufferAccess)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.cooperativeMatrix = cooperativeMatrix;
            this.cooperativeMatrixRobustBufferAccess = cooperativeMatrixRobustBufferAccess;
        }
    }
    public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCooperativeMatrixPropertiesNv;
        public void* pNext;
        public VkShaderStageFlagBits cooperativeMatrixSupportedStages;
        public VkPhysicalDeviceCooperativeMatrixPropertiesNV(VkStructureType sType, void* pNext, VkShaderStageFlagBits cooperativeMatrixSupportedStages)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.cooperativeMatrixSupportedStages = cooperativeMatrixSupportedStages;
        }
    }
    public unsafe struct VkCooperativeMatrixPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeCooperativeMatrixPropertiesNv;
        public void* pNext;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public VkComponentTypeKHR AType;
        public VkComponentTypeKHR BType;
        public VkComponentTypeKHR CType;
        public VkComponentTypeKHR DType;
        public VkScopeKHR scope;
        public VkCooperativeMatrixPropertiesNV(VkStructureType sType, void* pNext, uint MSize, uint NSize, uint KSize, VkComponentTypeKHR AType, VkComponentTypeKHR BType, VkComponentTypeKHR CType, VkComponentTypeKHR DType, VkScopeKHR scope)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.MSize = MSize;
            this.NSize = NSize;
            this.KSize = KSize;
            this.AType = AType;
            this.BType = BType;
            this.CType = CType;
            this.DType = DType;
            this.scope = scope;
        }
    }
    public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceYcbcrImageArraysFeaturesExt;
        public void* pNext;
        public int ycbcrImageArrays;
        public VkPhysicalDeviceYcbcrImageArraysFeaturesEXT(VkStructureType sType, void* pNext, int ycbcrImageArrays)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.ycbcrImageArrays = ycbcrImageArrays;
        }
    }
    public unsafe struct VkImageViewHandleInfoNVX
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageViewHandleInfoNvx;
        public void* pNext;
        public VkImageView imageView;
        public VkDescriptorType descriptorType;
        public VkSampler sampler;
        public VkImageViewHandleInfoNVX(VkStructureType sType, void* pNext, VkImageView imageView, VkDescriptorType descriptorType, VkSampler sampler)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageView = imageView;
            this.descriptorType = descriptorType;
            this.sampler = sampler;
        }
    }
    public unsafe struct VkImageViewAddressPropertiesNVX
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageViewAddressPropertiesNvx;
        public void* pNext;
        public ulong deviceAddress;
        public ulong size;
        public VkImageViewAddressPropertiesNVX(VkStructureType sType, void* pNext, ulong deviceAddress, ulong size)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceAddress = deviceAddress;
            this.size = size;
        }
    }
    public unsafe struct VkPresentFrameTokenGGP
    {
        public VkStructureType sType = VkStructureType.StructureTypePresentFrameTokenGgp;
        public void* pNext;
        // Unsupported type for field frameToken
        public VkPresentFrameTokenGGP(){ }
    }
    public unsafe struct VkPipelineCreationFeedback
    {
        public VkPipelineCreationFeedbackFlagBits flags;
        public ulong duration;
        public VkPipelineCreationFeedback(VkPipelineCreationFeedbackFlagBits flags, ulong duration)
        {
            this.flags = flags;
            this.duration = duration;
        }
    }
    public unsafe struct VkPipelineCreationFeedbackEXT
    {
        public VkPipelineCreationFeedbackEXT()
        {
        }
    }
    public unsafe struct VkPipelineCreationFeedbackCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineCreationFeedbackCreateInfo;
        public void* pNext;
        public VkPipelineCreationFeedback* pPipelineCreationFeedback;
        public uint pipelineStageCreationFeedbackCount;
        public VkPipelineCreationFeedback* pPipelineStageCreationFeedbacks;
        public VkPipelineCreationFeedbackCreateInfo(VkStructureType sType, void* pNext, VkPipelineCreationFeedback* pPipelineCreationFeedback, uint pipelineStageCreationFeedbackCount, VkPipelineCreationFeedback* pPipelineStageCreationFeedbacks)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pPipelineCreationFeedback = pPipelineCreationFeedback;
            this.pipelineStageCreationFeedbackCount = pipelineStageCreationFeedbackCount;
            this.pPipelineStageCreationFeedbacks = pPipelineStageCreationFeedbacks;
        }
    }
    public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT
    {
        public VkPipelineCreationFeedbackCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfaceFullScreenExclusiveInfoExt;
        public void* pNext;
        public VkFullScreenExclusiveEXT fullScreenExclusive;
        public VkSurfaceFullScreenExclusiveInfoEXT(VkStructureType sType, void* pNext, VkFullScreenExclusiveEXT fullScreenExclusive)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fullScreenExclusive = fullScreenExclusive;
        }
    }
    public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfaceFullScreenExclusiveWin32InfoExt;
        public void* pNext;
        public IntPtr hmonitor;
        public VkSurfaceFullScreenExclusiveWin32InfoEXT(VkStructureType sType, void* pNext, IntPtr hmonitor)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.hmonitor = hmonitor;
        }
    }
    public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfaceCapabilitiesFullScreenExclusiveExt;
        public void* pNext;
        public int fullScreenExclusiveSupported;
        public VkSurfaceCapabilitiesFullScreenExclusiveEXT(VkStructureType sType, void* pNext, int fullScreenExclusiveSupported)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fullScreenExclusiveSupported = fullScreenExclusiveSupported;
        }
    }
    public unsafe struct VkPhysicalDevicePresentBarrierFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePresentBarrierFeaturesNv;
        public void* pNext;
        public int presentBarrier;
        public VkPhysicalDevicePresentBarrierFeaturesNV(VkStructureType sType, void* pNext, int presentBarrier)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentBarrier = presentBarrier;
        }
    }
    public unsafe struct VkSurfaceCapabilitiesPresentBarrierNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfaceCapabilitiesPresentBarrierNv;
        public void* pNext;
        public int presentBarrierSupported;
        public VkSurfaceCapabilitiesPresentBarrierNV(VkStructureType sType, void* pNext, int presentBarrierSupported)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentBarrierSupported = presentBarrierSupported;
        }
    }
    public unsafe struct VkSwapchainPresentBarrierCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeSwapchainPresentBarrierCreateInfoNv;
        public void* pNext;
        public int presentBarrierEnable;
        public VkSwapchainPresentBarrierCreateInfoNV(VkStructureType sType, void* pNext, int presentBarrierEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentBarrierEnable = presentBarrierEnable;
        }
    }
    public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePerformanceQueryFeaturesKhr;
        public void* pNext;
        public int performanceCounterQueryPools;
        public int performanceCounterMultipleQueryPools;
        public VkPhysicalDevicePerformanceQueryFeaturesKHR(VkStructureType sType, void* pNext, int performanceCounterQueryPools, int performanceCounterMultipleQueryPools)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.performanceCounterQueryPools = performanceCounterQueryPools;
            this.performanceCounterMultipleQueryPools = performanceCounterMultipleQueryPools;
        }
    }
    public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePerformanceQueryPropertiesKhr;
        public void* pNext;
        public int allowCommandBufferQueryCopies;
        public VkPhysicalDevicePerformanceQueryPropertiesKHR(VkStructureType sType, void* pNext, int allowCommandBufferQueryCopies)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.allowCommandBufferQueryCopies = allowCommandBufferQueryCopies;
        }
    }
    public unsafe struct VkPerformanceCounterKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePerformanceCounterKhr;
        public void* pNext;
        public VkPerformanceCounterUnitKHR unit;
        public VkPerformanceCounterScopeKHR scope;
        public VkPerformanceCounterStorageKHR storage;
        public fixed byte uuid[16];
        public VkPerformanceCounterKHR(){ }
    }
    public unsafe struct VkPerformanceCounterDescriptionKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePerformanceCounterDescriptionKhr;
        public void* pNext;
        public VkPerformanceCounterDescriptionFlagBitsKHR flags;
        [InlineArray(256)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        [InlineArray(256)]
        public struct categoryInlineArray1
        {
            public byte element;
        }
        public categoryInlineArray1 category;
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
        public VkPerformanceCounterDescriptionKHR(){ }
    }
    public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueryPoolPerformanceCreateInfoKhr;
        public void* pNext;
        public uint queueFamilyIndex;
        public uint counterIndexCount;
        public uint* pCounterIndices;
        public VkQueryPoolPerformanceCreateInfoKHR(VkStructureType sType, void* pNext, uint queueFamilyIndex, uint counterIndexCount, uint* pCounterIndices)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.queueFamilyIndex = queueFamilyIndex;
            this.counterIndexCount = counterIndexCount;
            this.pCounterIndices = pCounterIndices;
        }
    }
    /// <summary>Union of all the possible return types a counter result could return</summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkPerformanceCounterResultKHR
    {
        [FieldOffset(0)]
        public int int32;
        [FieldOffset(0)]
        public long int64;
        [FieldOffset(0)]
        public uint uint32;
        [FieldOffset(0)]
        public ulong uint64;
        [FieldOffset(0)]
        public float float32;
        [FieldOffset(0)]
        public double float64;
    }
    public unsafe struct VkAcquireProfilingLockInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAcquireProfilingLockInfoKhr;
        public void* pNext;
        public VkAcquireProfilingLockFlagBitsKHR flags;
        public ulong timeout;
        public VkAcquireProfilingLockInfoKHR(VkStructureType sType, void* pNext, VkAcquireProfilingLockFlagBitsKHR flags, ulong timeout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.timeout = timeout;
        }
    }
    public unsafe struct VkPerformanceQuerySubmitInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePerformanceQuerySubmitInfoKhr;
        public void* pNext;
        public uint counterPassIndex;
        public VkPerformanceQuerySubmitInfoKHR(VkStructureType sType, void* pNext, uint counterPassIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.counterPassIndex = counterPassIndex;
        }
    }
    public unsafe struct VkPerformanceQueryReservationInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPerformanceQueriesPerPool;
        public VkPerformanceQueryReservationInfoKHR(VkStructureType sType, void* pNext, uint maxPerformanceQueriesPerPool)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxPerformanceQueriesPerPool = maxPerformanceQueriesPerPool;
        }
    }
    public unsafe struct VkHeadlessSurfaceCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeHeadlessSurfaceCreateInfoExt;
        public void* pNext;
        public VkHeadlessSurfaceCreateFlagsEXT flags;
        public VkHeadlessSurfaceCreateInfoEXT(VkStructureType sType, void* pNext, VkHeadlessSurfaceCreateFlagsEXT flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCoverageReductionModeFeaturesNv;
        public void* pNext;
        public int coverageReductionMode;
        public VkPhysicalDeviceCoverageReductionModeFeaturesNV(VkStructureType sType, void* pNext, int coverageReductionMode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.coverageReductionMode = coverageReductionMode;
        }
    }
    public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineCoverageReductionStateCreateInfoNv;
        public void* pNext;
        public VkPipelineCoverageReductionStateCreateFlagsNV flags;
        public VkCoverageReductionModeNV coverageReductionMode;
        public VkPipelineCoverageReductionStateCreateInfoNV(VkStructureType sType, void* pNext, VkPipelineCoverageReductionStateCreateFlagsNV flags, VkCoverageReductionModeNV coverageReductionMode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.coverageReductionMode = coverageReductionMode;
        }
    }
    public unsafe struct VkFramebufferMixedSamplesCombinationNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeFramebufferMixedSamplesCombinationNv;
        public void* pNext;
        public VkCoverageReductionModeNV coverageReductionMode;
        public VkSampleCountFlagBits rasterizationSamples;
        public VkSampleCountFlagBits depthStencilSamples;
        public VkSampleCountFlagBits colorSamples;
        public VkFramebufferMixedSamplesCombinationNV(VkStructureType sType, void* pNext, VkCoverageReductionModeNV coverageReductionMode, VkSampleCountFlagBits rasterizationSamples, VkSampleCountFlagBits depthStencilSamples, VkSampleCountFlagBits colorSamples)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.coverageReductionMode = coverageReductionMode;
            this.rasterizationSamples = rasterizationSamples;
            this.depthStencilSamples = depthStencilSamples;
            this.colorSamples = colorSamples;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderIntegerFunctions2FeaturesIntel;
        public void* pNext;
        public int shaderIntegerFunctions2;
        public VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL(VkStructureType sType, void* pNext, int shaderIntegerFunctions2)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderIntegerFunctions2 = shaderIntegerFunctions2;
        }
    }
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkPerformanceValueDataINTEL
    {
        [FieldOffset(0)]
        public uint value32;
        [FieldOffset(0)]
        public ulong value64;
        [FieldOffset(0)]
        public float valueFloat;
        [FieldOffset(0)]
        public int valueBool;
        [FieldOffset(0)]
        public byte* valueString;
    }
    public unsafe struct VkPerformanceValueINTEL
    {
        public VkPerformanceValueTypeINTEL type;
        public VkPerformanceValueDataINTEL data;
        public VkPerformanceValueINTEL(VkPerformanceValueTypeINTEL type, VkPerformanceValueDataINTEL data)
        {
            this.type = type;
            this.data = data;
        }
    }
    public unsafe struct VkInitializePerformanceApiInfoINTEL
    {
        public VkStructureType sType = VkStructureType.StructureTypeInitializePerformanceApiInfoIntel;
        public void* pNext;
        public void* pUserData;
        public VkInitializePerformanceApiInfoINTEL(VkStructureType sType, void* pNext, void* pUserData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pUserData = pUserData;
        }
    }
    public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueryPoolPerformanceQueryCreateInfoIntel;
        public void* pNext;
        public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
        public VkQueryPoolPerformanceQueryCreateInfoINTEL(VkStructureType sType, void* pNext, VkQueryPoolSamplingModeINTEL performanceCountersSampling)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.performanceCountersSampling = performanceCountersSampling;
        }
    }
    public unsafe struct VkQueryPoolCreateInfoINTEL
    {
        public VkQueryPoolCreateInfoINTEL()
        {
        }
    }
    public unsafe struct VkPerformanceMarkerInfoINTEL
    {
        public VkStructureType sType = VkStructureType.StructureTypePerformanceMarkerInfoIntel;
        public void* pNext;
        public ulong marker;
        public VkPerformanceMarkerInfoINTEL(VkStructureType sType, void* pNext, ulong marker)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.marker = marker;
        }
    }
    public unsafe struct VkPerformanceStreamMarkerInfoINTEL
    {
        public VkStructureType sType = VkStructureType.StructureTypePerformanceStreamMarkerInfoIntel;
        public void* pNext;
        public uint marker;
        public VkPerformanceStreamMarkerInfoINTEL(VkStructureType sType, void* pNext, uint marker)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.marker = marker;
        }
    }
    public unsafe struct VkPerformanceOverrideInfoINTEL
    {
        public VkStructureType sType = VkStructureType.StructureTypePerformanceOverrideInfoIntel;
        public void* pNext;
        public VkPerformanceOverrideTypeINTEL type;
        public int enable;
        public ulong parameter;
        public VkPerformanceOverrideInfoINTEL(VkStructureType sType, void* pNext, VkPerformanceOverrideTypeINTEL type, int enable, ulong parameter)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.type = type;
            this.enable = enable;
            this.parameter = parameter;
        }
    }
    public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
    {
        public VkStructureType sType = VkStructureType.StructureTypePerformanceConfigurationAcquireInfoIntel;
        public void* pNext;
        public VkPerformanceConfigurationTypeINTEL type;
        public VkPerformanceConfigurationAcquireInfoINTEL(VkStructureType sType, void* pNext, VkPerformanceConfigurationTypeINTEL type)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.type = type;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderClockFeaturesKhr;
        public void* pNext;
        public int shaderSubgroupClock;
        public int shaderDeviceClock;
        public VkPhysicalDeviceShaderClockFeaturesKHR(VkStructureType sType, void* pNext, int shaderSubgroupClock, int shaderDeviceClock)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderSubgroupClock = shaderSubgroupClock;
            this.shaderDeviceClock = shaderDeviceClock;
        }
    }
    public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceIndexTypeUint8FeaturesKhr;
        public void* pNext;
        public int indexTypeUint8;
        public VkPhysicalDeviceIndexTypeUint8FeaturesKHR(VkStructureType sType, void* pNext, int indexTypeUint8)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.indexTypeUint8 = indexTypeUint8;
        }
    }
    public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
    {
        public VkPhysicalDeviceIndexTypeUint8FeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderSmBuiltinsPropertiesNv;
        public void* pNext;
        public uint shaderSMCount;
        public uint shaderWarpsPerSM;
        public VkPhysicalDeviceShaderSMBuiltinsPropertiesNV(VkStructureType sType, void* pNext, uint shaderSMCount, uint shaderWarpsPerSM)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderSMCount = shaderSMCount;
            this.shaderWarpsPerSM = shaderWarpsPerSM;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderSmBuiltinsFeaturesNv;
        public void* pNext;
        public int shaderSMBuiltins;
        public VkPhysicalDeviceShaderSMBuiltinsFeaturesNV(VkStructureType sType, void* pNext, int shaderSMBuiltins)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderSMBuiltins = shaderSMBuiltins;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentShaderInterlockFeaturesExt;
        public void* pNext;
        public int fragmentShaderSampleInterlock;
        public int fragmentShaderPixelInterlock;
        public int fragmentShaderShadingRateInterlock;
        public VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT(VkStructureType sType, void* pNext, int fragmentShaderSampleInterlock, int fragmentShaderPixelInterlock, int fragmentShaderShadingRateInterlock)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fragmentShaderSampleInterlock = fragmentShaderSampleInterlock;
            this.fragmentShaderPixelInterlock = fragmentShaderPixelInterlock;
            this.fragmentShaderShadingRateInterlock = fragmentShaderShadingRateInterlock;
        }
    }
    public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeatures;
        public void* pNext;
        public int separateDepthStencilLayouts;
        public VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures(VkStructureType sType, void* pNext, int separateDepthStencilLayouts)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.separateDepthStencilLayouts = separateDepthStencilLayouts;
        }
    }
    public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
    {
        public VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR()
        {
        }
    }
    public unsafe struct VkAttachmentReferenceStencilLayout
    {
        public VkStructureType sType = VkStructureType.StructureTypeAttachmentReferenceStencilLayout;
        public void* pNext;
        public VkImageLayout stencilLayout;
        public VkAttachmentReferenceStencilLayout(VkStructureType sType, void* pNext, VkImageLayout stencilLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stencilLayout = stencilLayout;
        }
    }
    public unsafe struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePrimitiveTopologyListRestartFeaturesExt;
        public void* pNext;
        public int primitiveTopologyListRestart;
        public int primitiveTopologyPatchListRestart;
        public VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT(VkStructureType sType, void* pNext, int primitiveTopologyListRestart, int primitiveTopologyPatchListRestart)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.primitiveTopologyListRestart = primitiveTopologyListRestart;
            this.primitiveTopologyPatchListRestart = primitiveTopologyPatchListRestart;
        }
    }
    public unsafe struct VkAttachmentReferenceStencilLayoutKHR
    {
        public VkAttachmentReferenceStencilLayoutKHR()
        {
        }
    }
    public unsafe struct VkAttachmentDescriptionStencilLayout
    {
        public VkStructureType sType = VkStructureType.StructureTypeAttachmentDescriptionStencilLayout;
        public void* pNext;
        public VkImageLayout stencilInitialLayout;
        public VkImageLayout stencilFinalLayout;
        public VkAttachmentDescriptionStencilLayout(VkStructureType sType, void* pNext, VkImageLayout stencilInitialLayout, VkImageLayout stencilFinalLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stencilInitialLayout = stencilInitialLayout;
            this.stencilFinalLayout = stencilFinalLayout;
        }
    }
    public unsafe struct VkAttachmentDescriptionStencilLayoutKHR
    {
        public VkAttachmentDescriptionStencilLayoutKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePipelineExecutablePropertiesFeaturesKhr;
        public void* pNext;
        public int pipelineExecutableInfo;
        public VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR(VkStructureType sType, void* pNext, int pipelineExecutableInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineExecutableInfo = pipelineExecutableInfo;
        }
    }
    public unsafe struct VkPipelineInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineInfoKhr;
        public void* pNext;
        public VkPipeline pipeline;
        public VkPipelineInfoKHR(VkStructureType sType, void* pNext, VkPipeline pipeline)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipeline = pipeline;
        }
    }
    public unsafe struct VkPipelineInfoEXT
    {
        public VkPipelineInfoEXT()
        {
        }
    }
    public unsafe struct VkPipelineExecutablePropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineExecutablePropertiesKhr;
        public void* pNext;
        public VkShaderStageFlagBits stages;
        [InlineArray(256)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
        public uint subgroupSize;
        public VkPipelineExecutablePropertiesKHR(){ }
    }
    public unsafe struct VkPipelineExecutableInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineExecutableInfoKhr;
        public void* pNext;
        public VkPipeline pipeline;
        public uint executableIndex;
        public VkPipelineExecutableInfoKHR(VkStructureType sType, void* pNext, VkPipeline pipeline, uint executableIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipeline = pipeline;
            this.executableIndex = executableIndex;
        }
    }
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkPipelineExecutableStatisticValueKHR
    {
        [FieldOffset(0)]
        public int b32;
        [FieldOffset(0)]
        public long i64;
        [FieldOffset(0)]
        public ulong u64;
        [FieldOffset(0)]
        public double f64;
    }
    public unsafe struct VkPipelineExecutableStatisticKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineExecutableStatisticKhr;
        public void* pNext;
        [InlineArray(256)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
        public VkPipelineExecutableStatisticFormatKHR format;
        public VkPipelineExecutableStatisticValueKHR value;
        public VkPipelineExecutableStatisticKHR(){ }
    }
    public unsafe struct VkPipelineExecutableInternalRepresentationKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineExecutableInternalRepresentationKhr;
        public void* pNext;
        [InlineArray(256)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
        public int isText;
        public nuint dataSize;
        public void* pData;
        public VkPipelineExecutableInternalRepresentationKHR(){ }
    }
    public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderDemoteToHelperInvocationFeatures;
        public void* pNext;
        public int shaderDemoteToHelperInvocation;
        public VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures(VkStructureType sType, void* pNext, int shaderDemoteToHelperInvocation)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderDemoteToHelperInvocation = shaderDemoteToHelperInvocation;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
    {
        public VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceTexelBufferAlignmentFeaturesExt;
        public void* pNext;
        public int texelBufferAlignment;
        public VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT(VkStructureType sType, void* pNext, int texelBufferAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.texelBufferAlignment = texelBufferAlignment;
        }
    }
    public unsafe struct VkPhysicalDeviceTexelBufferAlignmentProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceTexelBufferAlignmentProperties;
        public void* pNext;
        public ulong storageTexelBufferOffsetAlignmentBytes;
        public int storageTexelBufferOffsetSingleTexelAlignment;
        public ulong uniformTexelBufferOffsetAlignmentBytes;
        public int uniformTexelBufferOffsetSingleTexelAlignment;
        public VkPhysicalDeviceTexelBufferAlignmentProperties(VkStructureType sType, void* pNext, ulong storageTexelBufferOffsetAlignmentBytes, int storageTexelBufferOffsetSingleTexelAlignment, ulong uniformTexelBufferOffsetAlignmentBytes, int uniformTexelBufferOffsetSingleTexelAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.storageTexelBufferOffsetAlignmentBytes = storageTexelBufferOffsetAlignmentBytes;
            this.storageTexelBufferOffsetSingleTexelAlignment = storageTexelBufferOffsetSingleTexelAlignment;
            this.uniformTexelBufferOffsetAlignmentBytes = uniformTexelBufferOffsetAlignmentBytes;
            this.uniformTexelBufferOffsetSingleTexelAlignment = uniformTexelBufferOffsetSingleTexelAlignment;
        }
    }
    public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSubgroupSizeControlFeatures;
        public void* pNext;
        public int subgroupSizeControl;
        public int computeFullSubgroups;
        public VkPhysicalDeviceSubgroupSizeControlFeatures(VkStructureType sType, void* pNext, int subgroupSizeControl, int computeFullSubgroups)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.subgroupSizeControl = subgroupSizeControl;
            this.computeFullSubgroups = computeFullSubgroups;
        }
    }
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
    {
        public VkPhysicalDeviceSubgroupSizeControlFeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSubgroupSizeControlProperties;
        public void* pNext;
        public uint minSubgroupSize;
        public uint maxSubgroupSize;
        public uint maxComputeWorkgroupSubgroups;
        public VkShaderStageFlagBits requiredSubgroupSizeStages;
        public VkPhysicalDeviceSubgroupSizeControlProperties(VkStructureType sType, void* pNext, uint minSubgroupSize, uint maxSubgroupSize, uint maxComputeWorkgroupSubgroups, VkShaderStageFlagBits requiredSubgroupSizeStages)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minSubgroupSize = minSubgroupSize;
            this.maxSubgroupSize = maxSubgroupSize;
            this.maxComputeWorkgroupSubgroups = maxComputeWorkgroupSubgroups;
            this.requiredSubgroupSizeStages = requiredSubgroupSizeStages;
        }
    }
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
    {
        public VkPhysicalDeviceSubgroupSizeControlPropertiesEXT()
        {
        }
    }
    public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfo;
        public void* pNext;
        public uint requiredSubgroupSize;
        public VkPipelineShaderStageRequiredSubgroupSizeCreateInfo(VkStructureType sType, void* pNext, uint requiredSubgroupSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.requiredSubgroupSize = requiredSubgroupSize;
        }
    }
    public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
    {
        public VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkShaderRequiredSubgroupSizeCreateInfoEXT
    {
        public VkShaderRequiredSubgroupSizeCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubpassShadingPipelineCreateInfoHuawei;
        public void* pNext;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkSubpassShadingPipelineCreateInfoHUAWEI(VkStructureType sType, void* pNext, VkRenderPass renderPass, uint subpass)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.renderPass = renderPass;
            this.subpass = subpass;
        }
    }
    public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSubpassShadingPropertiesHuawei;
        public void* pNext;
        public uint maxSubpassShadingWorkgroupSizeAspectRatio;
        public VkPhysicalDeviceSubpassShadingPropertiesHUAWEI(VkStructureType sType, void* pNext, uint maxSubpassShadingWorkgroupSizeAspectRatio)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxSubpassShadingWorkgroupSizeAspectRatio = maxSubpassShadingWorkgroupSizeAspectRatio;
        }
    }
    public unsafe struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceClusterCullingShaderPropertiesHuawei;
        public void* pNext;
        public fixed uint maxWorkGroupCount[3];
        public fixed uint maxWorkGroupSize[3];
        public uint maxOutputClusterCount;
        public ulong indirectBufferOffsetAlignment;
        public VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI(){ }
    }
    public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryOpaqueCaptureAddressAllocateInfo;
        public void* pNext;
        public ulong opaqueCaptureAddress;
        public VkMemoryOpaqueCaptureAddressAllocateInfo(VkStructureType sType, void* pNext, ulong opaqueCaptureAddress)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.opaqueCaptureAddress = opaqueCaptureAddress;
        }
    }
    public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
    {
        public VkMemoryOpaqueCaptureAddressAllocateInfoKHR()
        {
        }
    }
    public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceMemoryOpaqueCaptureAddressInfo;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkDeviceMemoryOpaqueCaptureAddressInfo(VkStructureType sType, void* pNext, VkDeviceMemory memory)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memory = memory;
        }
    }
    public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfoKHR
    {
        public VkDeviceMemoryOpaqueCaptureAddressInfoKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLineRasterizationFeaturesKhr;
        public void* pNext;
        public int rectangularLines;
        public int bresenhamLines;
        public int smoothLines;
        public int stippledRectangularLines;
        public int stippledBresenhamLines;
        public int stippledSmoothLines;
        public VkPhysicalDeviceLineRasterizationFeaturesKHR(VkStructureType sType, void* pNext, int rectangularLines, int bresenhamLines, int smoothLines, int stippledRectangularLines, int stippledBresenhamLines, int stippledSmoothLines)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rectangularLines = rectangularLines;
            this.bresenhamLines = bresenhamLines;
            this.smoothLines = smoothLines;
            this.stippledRectangularLines = stippledRectangularLines;
            this.stippledBresenhamLines = stippledBresenhamLines;
            this.stippledSmoothLines = stippledSmoothLines;
        }
    }
    public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
    {
        public VkPhysicalDeviceLineRasterizationFeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLineRasterizationPropertiesKhr;
        public void* pNext;
        public uint lineSubPixelPrecisionBits;
        public VkPhysicalDeviceLineRasterizationPropertiesKHR(VkStructureType sType, void* pNext, uint lineSubPixelPrecisionBits)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.lineSubPixelPrecisionBits = lineSubPixelPrecisionBits;
        }
    }
    public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
    {
        public VkPhysicalDeviceLineRasterizationPropertiesEXT()
        {
        }
    }
    public unsafe struct VkPipelineRasterizationLineStateCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRasterizationLineStateCreateInfoKhr;
        public void* pNext;
        public VkLineRasterizationModeKHR lineRasterizationMode;
        public int stippledLineEnable;
        public uint lineStippleFactor;
        public ushort lineStipplePattern;
        public VkPipelineRasterizationLineStateCreateInfoKHR(VkStructureType sType, void* pNext, VkLineRasterizationModeKHR lineRasterizationMode, int stippledLineEnable, uint lineStippleFactor, ushort lineStipplePattern)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.lineRasterizationMode = lineRasterizationMode;
            this.stippledLineEnable = stippledLineEnable;
            this.lineStippleFactor = lineStippleFactor;
            this.lineStipplePattern = lineStipplePattern;
        }
    }
    public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
    {
        public VkPipelineRasterizationLineStateCreateInfoEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePipelineCreationCacheControlFeatures;
        public void* pNext;
        public int pipelineCreationCacheControl;
        public VkPhysicalDevicePipelineCreationCacheControlFeatures(VkStructureType sType, void* pNext, int pipelineCreationCacheControl)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineCreationCacheControl = pipelineCreationCacheControl;
        }
    }
    public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT
    {
        public VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVulkan11Features;
        public void* pNext;
        public int storageBuffer16BitAccess;
        public int uniformAndStorageBuffer16BitAccess;
        public int storagePushConstant16;
        public int storageInputOutput16;
        public int multiview;
        public int multiviewGeometryShader;
        public int multiviewTessellationShader;
        public int variablePointersStorageBuffer;
        public int variablePointers;
        public int protectedMemory;
        public int samplerYcbcrConversion;
        public int shaderDrawParameters;
        public VkPhysicalDeviceVulkan11Features(VkStructureType sType, void* pNext, int storageBuffer16BitAccess, int uniformAndStorageBuffer16BitAccess, int storagePushConstant16, int storageInputOutput16, int multiview, int multiviewGeometryShader, int multiviewTessellationShader, int variablePointersStorageBuffer, int variablePointers, int protectedMemory, int samplerYcbcrConversion, int shaderDrawParameters)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.storageBuffer16BitAccess = storageBuffer16BitAccess;
            this.uniformAndStorageBuffer16BitAccess = uniformAndStorageBuffer16BitAccess;
            this.storagePushConstant16 = storagePushConstant16;
            this.storageInputOutput16 = storageInputOutput16;
            this.multiview = multiview;
            this.multiviewGeometryShader = multiviewGeometryShader;
            this.multiviewTessellationShader = multiviewTessellationShader;
            this.variablePointersStorageBuffer = variablePointersStorageBuffer;
            this.variablePointers = variablePointers;
            this.protectedMemory = protectedMemory;
            this.samplerYcbcrConversion = samplerYcbcrConversion;
            this.shaderDrawParameters = shaderDrawParameters;
        }
    }
    public unsafe struct VkPhysicalDeviceVulkan11Properties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVulkan11Properties;
        public void* pNext;
        public fixed byte deviceUUID[16];
        public fixed byte driverUUID[16];
        public fixed byte deviceLUID[8];
        public uint deviceNodeMask;
        public int deviceLUIDValid;
        public uint subgroupSize;
        public VkShaderStageFlagBits subgroupSupportedStages;
        public VkSubgroupFeatureFlagBits subgroupSupportedOperations;
        public int subgroupQuadOperationsInAllStages;
        public VkPointClippingBehavior pointClippingBehavior;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
        public int protectedNoFault;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
        public VkPhysicalDeviceVulkan11Properties(){ }
    }
    public unsafe struct VkPhysicalDeviceVulkan12Features
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVulkan12Features;
        public void* pNext;
        public int samplerMirrorClampToEdge;
        public int drawIndirectCount;
        public int storageBuffer8BitAccess;
        public int uniformAndStorageBuffer8BitAccess;
        public int storagePushConstant8;
        public int shaderBufferInt64Atomics;
        public int shaderSharedInt64Atomics;
        public int shaderFloat16;
        public int shaderInt8;
        public int descriptorIndexing;
        public int shaderInputAttachmentArrayDynamicIndexing;
        public int shaderUniformTexelBufferArrayDynamicIndexing;
        public int shaderStorageTexelBufferArrayDynamicIndexing;
        public int shaderUniformBufferArrayNonUniformIndexing;
        public int shaderSampledImageArrayNonUniformIndexing;
        public int shaderStorageBufferArrayNonUniformIndexing;
        public int shaderStorageImageArrayNonUniformIndexing;
        public int shaderInputAttachmentArrayNonUniformIndexing;
        public int shaderUniformTexelBufferArrayNonUniformIndexing;
        public int shaderStorageTexelBufferArrayNonUniformIndexing;
        public int descriptorBindingUniformBufferUpdateAfterBind;
        public int descriptorBindingSampledImageUpdateAfterBind;
        public int descriptorBindingStorageImageUpdateAfterBind;
        public int descriptorBindingStorageBufferUpdateAfterBind;
        public int descriptorBindingUniformTexelBufferUpdateAfterBind;
        public int descriptorBindingStorageTexelBufferUpdateAfterBind;
        public int descriptorBindingUpdateUnusedWhilePending;
        public int descriptorBindingPartiallyBound;
        public int descriptorBindingVariableDescriptorCount;
        public int runtimeDescriptorArray;
        public int samplerFilterMinmax;
        public int scalarBlockLayout;
        public int imagelessFramebuffer;
        public int uniformBufferStandardLayout;
        public int shaderSubgroupExtendedTypes;
        public int separateDepthStencilLayouts;
        public int hostQueryReset;
        public int timelineSemaphore;
        public int bufferDeviceAddress;
        public int bufferDeviceAddressCaptureReplay;
        public int bufferDeviceAddressMultiDevice;
        public int vulkanMemoryModel;
        public int vulkanMemoryModelDeviceScope;
        public int vulkanMemoryModelAvailabilityVisibilityChains;
        public int shaderOutputViewportIndex;
        public int shaderOutputLayer;
        public int subgroupBroadcastDynamicId;
        public VkPhysicalDeviceVulkan12Features(VkStructureType sType, void* pNext, int samplerMirrorClampToEdge, int drawIndirectCount, int storageBuffer8BitAccess, int uniformAndStorageBuffer8BitAccess, int storagePushConstant8, int shaderBufferInt64Atomics, int shaderSharedInt64Atomics, int shaderFloat16, int shaderInt8, int descriptorIndexing, int shaderInputAttachmentArrayDynamicIndexing, int shaderUniformTexelBufferArrayDynamicIndexing, int shaderStorageTexelBufferArrayDynamicIndexing, int shaderUniformBufferArrayNonUniformIndexing, int shaderSampledImageArrayNonUniformIndexing, int shaderStorageBufferArrayNonUniformIndexing, int shaderStorageImageArrayNonUniformIndexing, int shaderInputAttachmentArrayNonUniformIndexing, int shaderUniformTexelBufferArrayNonUniformIndexing, int shaderStorageTexelBufferArrayNonUniformIndexing, int descriptorBindingUniformBufferUpdateAfterBind, int descriptorBindingSampledImageUpdateAfterBind, int descriptorBindingStorageImageUpdateAfterBind, int descriptorBindingStorageBufferUpdateAfterBind, int descriptorBindingUniformTexelBufferUpdateAfterBind, int descriptorBindingStorageTexelBufferUpdateAfterBind, int descriptorBindingUpdateUnusedWhilePending, int descriptorBindingPartiallyBound, int descriptorBindingVariableDescriptorCount, int runtimeDescriptorArray, int samplerFilterMinmax, int scalarBlockLayout, int imagelessFramebuffer, int uniformBufferStandardLayout, int shaderSubgroupExtendedTypes, int separateDepthStencilLayouts, int hostQueryReset, int timelineSemaphore, int bufferDeviceAddress, int bufferDeviceAddressCaptureReplay, int bufferDeviceAddressMultiDevice, int vulkanMemoryModel, int vulkanMemoryModelDeviceScope, int vulkanMemoryModelAvailabilityVisibilityChains, int shaderOutputViewportIndex, int shaderOutputLayer, int subgroupBroadcastDynamicId)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.samplerMirrorClampToEdge = samplerMirrorClampToEdge;
            this.drawIndirectCount = drawIndirectCount;
            this.storageBuffer8BitAccess = storageBuffer8BitAccess;
            this.uniformAndStorageBuffer8BitAccess = uniformAndStorageBuffer8BitAccess;
            this.storagePushConstant8 = storagePushConstant8;
            this.shaderBufferInt64Atomics = shaderBufferInt64Atomics;
            this.shaderSharedInt64Atomics = shaderSharedInt64Atomics;
            this.shaderFloat16 = shaderFloat16;
            this.shaderInt8 = shaderInt8;
            this.descriptorIndexing = descriptorIndexing;
            this.shaderInputAttachmentArrayDynamicIndexing = shaderInputAttachmentArrayDynamicIndexing;
            this.shaderUniformTexelBufferArrayDynamicIndexing = shaderUniformTexelBufferArrayDynamicIndexing;
            this.shaderStorageTexelBufferArrayDynamicIndexing = shaderStorageTexelBufferArrayDynamicIndexing;
            this.shaderUniformBufferArrayNonUniformIndexing = shaderUniformBufferArrayNonUniformIndexing;
            this.shaderSampledImageArrayNonUniformIndexing = shaderSampledImageArrayNonUniformIndexing;
            this.shaderStorageBufferArrayNonUniformIndexing = shaderStorageBufferArrayNonUniformIndexing;
            this.shaderStorageImageArrayNonUniformIndexing = shaderStorageImageArrayNonUniformIndexing;
            this.shaderInputAttachmentArrayNonUniformIndexing = shaderInputAttachmentArrayNonUniformIndexing;
            this.shaderUniformTexelBufferArrayNonUniformIndexing = shaderUniformTexelBufferArrayNonUniformIndexing;
            this.shaderStorageTexelBufferArrayNonUniformIndexing = shaderStorageTexelBufferArrayNonUniformIndexing;
            this.descriptorBindingUniformBufferUpdateAfterBind = descriptorBindingUniformBufferUpdateAfterBind;
            this.descriptorBindingSampledImageUpdateAfterBind = descriptorBindingSampledImageUpdateAfterBind;
            this.descriptorBindingStorageImageUpdateAfterBind = descriptorBindingStorageImageUpdateAfterBind;
            this.descriptorBindingStorageBufferUpdateAfterBind = descriptorBindingStorageBufferUpdateAfterBind;
            this.descriptorBindingUniformTexelBufferUpdateAfterBind = descriptorBindingUniformTexelBufferUpdateAfterBind;
            this.descriptorBindingStorageTexelBufferUpdateAfterBind = descriptorBindingStorageTexelBufferUpdateAfterBind;
            this.descriptorBindingUpdateUnusedWhilePending = descriptorBindingUpdateUnusedWhilePending;
            this.descriptorBindingPartiallyBound = descriptorBindingPartiallyBound;
            this.descriptorBindingVariableDescriptorCount = descriptorBindingVariableDescriptorCount;
            this.runtimeDescriptorArray = runtimeDescriptorArray;
            this.samplerFilterMinmax = samplerFilterMinmax;
            this.scalarBlockLayout = scalarBlockLayout;
            this.imagelessFramebuffer = imagelessFramebuffer;
            this.uniformBufferStandardLayout = uniformBufferStandardLayout;
            this.shaderSubgroupExtendedTypes = shaderSubgroupExtendedTypes;
            this.separateDepthStencilLayouts = separateDepthStencilLayouts;
            this.hostQueryReset = hostQueryReset;
            this.timelineSemaphore = timelineSemaphore;
            this.bufferDeviceAddress = bufferDeviceAddress;
            this.bufferDeviceAddressCaptureReplay = bufferDeviceAddressCaptureReplay;
            this.bufferDeviceAddressMultiDevice = bufferDeviceAddressMultiDevice;
            this.vulkanMemoryModel = vulkanMemoryModel;
            this.vulkanMemoryModelDeviceScope = vulkanMemoryModelDeviceScope;
            this.vulkanMemoryModelAvailabilityVisibilityChains = vulkanMemoryModelAvailabilityVisibilityChains;
            this.shaderOutputViewportIndex = shaderOutputViewportIndex;
            this.shaderOutputLayer = shaderOutputLayer;
            this.subgroupBroadcastDynamicId = subgroupBroadcastDynamicId;
        }
    }
    public unsafe struct VkPhysicalDeviceVulkan12Properties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVulkan12Properties;
        public void* pNext;
        public VkDriverId driverID;
        [InlineArray(256)]
        public struct driverNameInlineArray1
        {
            public byte element;
        }
        public driverNameInlineArray1 driverName;
        [InlineArray(256)]
        public struct driverInfoInlineArray1
        {
            public byte element;
        }
        public driverInfoInlineArray1 driverInfo;
        public VkConformanceVersion conformanceVersion;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public int shaderSignedZeroInfNanPreserveFloat16;
        public int shaderSignedZeroInfNanPreserveFloat32;
        public int shaderSignedZeroInfNanPreserveFloat64;
        public int shaderDenormPreserveFloat16;
        public int shaderDenormPreserveFloat32;
        public int shaderDenormPreserveFloat64;
        public int shaderDenormFlushToZeroFloat16;
        public int shaderDenormFlushToZeroFloat32;
        public int shaderDenormFlushToZeroFloat64;
        public int shaderRoundingModeRTEFloat16;
        public int shaderRoundingModeRTEFloat32;
        public int shaderRoundingModeRTEFloat64;
        public int shaderRoundingModeRTZFloat16;
        public int shaderRoundingModeRTZFloat32;
        public int shaderRoundingModeRTZFloat64;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public int shaderUniformBufferArrayNonUniformIndexingNative;
        public int shaderSampledImageArrayNonUniformIndexingNative;
        public int shaderStorageBufferArrayNonUniformIndexingNative;
        public int shaderStorageImageArrayNonUniformIndexingNative;
        public int shaderInputAttachmentArrayNonUniformIndexingNative;
        public int robustBufferAccessUpdateAfterBind;
        public int quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
        public VkResolveModeFlagBits supportedDepthResolveModes;
        public VkResolveModeFlagBits supportedStencilResolveModes;
        public int independentResolveNone;
        public int independentResolve;
        public int filterMinmaxSingleComponentFormats;
        public int filterMinmaxImageComponentMapping;
        public ulong maxTimelineSemaphoreValueDifference;
        public VkSampleCountFlagBits framebufferIntegerColorSampleCounts;
        public VkPhysicalDeviceVulkan12Properties(){ }
    }
    public unsafe struct VkPhysicalDeviceVulkan13Features
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVulkan13Features;
        public void* pNext;
        public int robustImageAccess;
        public int inlineUniformBlock;
        public int descriptorBindingInlineUniformBlockUpdateAfterBind;
        public int pipelineCreationCacheControl;
        public int privateData;
        public int shaderDemoteToHelperInvocation;
        public int shaderTerminateInvocation;
        public int subgroupSizeControl;
        public int computeFullSubgroups;
        public int synchronization2;
        public int textureCompressionASTC_HDR;
        public int shaderZeroInitializeWorkgroupMemory;
        public int dynamicRendering;
        public int shaderIntegerDotProduct;
        public int maintenance4;
        public VkPhysicalDeviceVulkan13Features(VkStructureType sType, void* pNext, int robustImageAccess, int inlineUniformBlock, int descriptorBindingInlineUniformBlockUpdateAfterBind, int pipelineCreationCacheControl, int privateData, int shaderDemoteToHelperInvocation, int shaderTerminateInvocation, int subgroupSizeControl, int computeFullSubgroups, int synchronization2, int textureCompressionASTC_HDR, int shaderZeroInitializeWorkgroupMemory, int dynamicRendering, int shaderIntegerDotProduct, int maintenance4)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.robustImageAccess = robustImageAccess;
            this.inlineUniformBlock = inlineUniformBlock;
            this.descriptorBindingInlineUniformBlockUpdateAfterBind = descriptorBindingInlineUniformBlockUpdateAfterBind;
            this.pipelineCreationCacheControl = pipelineCreationCacheControl;
            this.privateData = privateData;
            this.shaderDemoteToHelperInvocation = shaderDemoteToHelperInvocation;
            this.shaderTerminateInvocation = shaderTerminateInvocation;
            this.subgroupSizeControl = subgroupSizeControl;
            this.computeFullSubgroups = computeFullSubgroups;
            this.synchronization2 = synchronization2;
            this.textureCompressionASTC_HDR = textureCompressionASTC_HDR;
            this.shaderZeroInitializeWorkgroupMemory = shaderZeroInitializeWorkgroupMemory;
            this.dynamicRendering = dynamicRendering;
            this.shaderIntegerDotProduct = shaderIntegerDotProduct;
            this.maintenance4 = maintenance4;
        }
    }
    public unsafe struct VkPhysicalDeviceVulkan13Properties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVulkan13Properties;
        public void* pNext;
        public uint minSubgroupSize;
        public uint maxSubgroupSize;
        public uint maxComputeWorkgroupSubgroups;
        public VkShaderStageFlagBits requiredSubgroupSizeStages;
        public uint maxInlineUniformBlockSize;
        public uint maxPerStageDescriptorInlineUniformBlocks;
        public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint maxDescriptorSetInlineUniformBlocks;
        public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        public uint maxInlineUniformTotalSize;
        public int integerDotProduct8BitUnsignedAccelerated;
        public int integerDotProduct8BitSignedAccelerated;
        public int integerDotProduct8BitMixedSignednessAccelerated;
        public int integerDotProduct4x8BitPackedUnsignedAccelerated;
        public int integerDotProduct4x8BitPackedSignedAccelerated;
        public int integerDotProduct4x8BitPackedMixedSignednessAccelerated;
        public int integerDotProduct16BitUnsignedAccelerated;
        public int integerDotProduct16BitSignedAccelerated;
        public int integerDotProduct16BitMixedSignednessAccelerated;
        public int integerDotProduct32BitUnsignedAccelerated;
        public int integerDotProduct32BitSignedAccelerated;
        public int integerDotProduct32BitMixedSignednessAccelerated;
        public int integerDotProduct64BitUnsignedAccelerated;
        public int integerDotProduct64BitSignedAccelerated;
        public int integerDotProduct64BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating8BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating16BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating32BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating64BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
        public ulong storageTexelBufferOffsetAlignmentBytes;
        public int storageTexelBufferOffsetSingleTexelAlignment;
        public ulong uniformTexelBufferOffsetAlignmentBytes;
        public int uniformTexelBufferOffsetSingleTexelAlignment;
        public ulong maxBufferSize;
        public VkPhysicalDeviceVulkan13Properties(VkStructureType sType, void* pNext, uint minSubgroupSize, uint maxSubgroupSize, uint maxComputeWorkgroupSubgroups, VkShaderStageFlagBits requiredSubgroupSizeStages, uint maxInlineUniformBlockSize, uint maxPerStageDescriptorInlineUniformBlocks, uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks, uint maxDescriptorSetInlineUniformBlocks, uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks, uint maxInlineUniformTotalSize, int integerDotProduct8BitUnsignedAccelerated, int integerDotProduct8BitSignedAccelerated, int integerDotProduct8BitMixedSignednessAccelerated, int integerDotProduct4x8BitPackedUnsignedAccelerated, int integerDotProduct4x8BitPackedSignedAccelerated, int integerDotProduct4x8BitPackedMixedSignednessAccelerated, int integerDotProduct16BitUnsignedAccelerated, int integerDotProduct16BitSignedAccelerated, int integerDotProduct16BitMixedSignednessAccelerated, int integerDotProduct32BitUnsignedAccelerated, int integerDotProduct32BitSignedAccelerated, int integerDotProduct32BitMixedSignednessAccelerated, int integerDotProduct64BitUnsignedAccelerated, int integerDotProduct64BitSignedAccelerated, int integerDotProduct64BitMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating8BitUnsignedAccelerated, int integerDotProductAccumulatingSaturating8BitSignedAccelerated, int integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated, int integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated, int integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating16BitUnsignedAccelerated, int integerDotProductAccumulatingSaturating16BitSignedAccelerated, int integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating32BitUnsignedAccelerated, int integerDotProductAccumulatingSaturating32BitSignedAccelerated, int integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating64BitUnsignedAccelerated, int integerDotProductAccumulatingSaturating64BitSignedAccelerated, int integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated, ulong storageTexelBufferOffsetAlignmentBytes, int storageTexelBufferOffsetSingleTexelAlignment, ulong uniformTexelBufferOffsetAlignmentBytes, int uniformTexelBufferOffsetSingleTexelAlignment, ulong maxBufferSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minSubgroupSize = minSubgroupSize;
            this.maxSubgroupSize = maxSubgroupSize;
            this.maxComputeWorkgroupSubgroups = maxComputeWorkgroupSubgroups;
            this.requiredSubgroupSizeStages = requiredSubgroupSizeStages;
            this.maxInlineUniformBlockSize = maxInlineUniformBlockSize;
            this.maxPerStageDescriptorInlineUniformBlocks = maxPerStageDescriptorInlineUniformBlocks;
            this.maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
            this.maxDescriptorSetInlineUniformBlocks = maxDescriptorSetInlineUniformBlocks;
            this.maxDescriptorSetUpdateAfterBindInlineUniformBlocks = maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
            this.maxInlineUniformTotalSize = maxInlineUniformTotalSize;
            this.integerDotProduct8BitUnsignedAccelerated = integerDotProduct8BitUnsignedAccelerated;
            this.integerDotProduct8BitSignedAccelerated = integerDotProduct8BitSignedAccelerated;
            this.integerDotProduct8BitMixedSignednessAccelerated = integerDotProduct8BitMixedSignednessAccelerated;
            this.integerDotProduct4x8BitPackedUnsignedAccelerated = integerDotProduct4x8BitPackedUnsignedAccelerated;
            this.integerDotProduct4x8BitPackedSignedAccelerated = integerDotProduct4x8BitPackedSignedAccelerated;
            this.integerDotProduct4x8BitPackedMixedSignednessAccelerated = integerDotProduct4x8BitPackedMixedSignednessAccelerated;
            this.integerDotProduct16BitUnsignedAccelerated = integerDotProduct16BitUnsignedAccelerated;
            this.integerDotProduct16BitSignedAccelerated = integerDotProduct16BitSignedAccelerated;
            this.integerDotProduct16BitMixedSignednessAccelerated = integerDotProduct16BitMixedSignednessAccelerated;
            this.integerDotProduct32BitUnsignedAccelerated = integerDotProduct32BitUnsignedAccelerated;
            this.integerDotProduct32BitSignedAccelerated = integerDotProduct32BitSignedAccelerated;
            this.integerDotProduct32BitMixedSignednessAccelerated = integerDotProduct32BitMixedSignednessAccelerated;
            this.integerDotProduct64BitUnsignedAccelerated = integerDotProduct64BitUnsignedAccelerated;
            this.integerDotProduct64BitSignedAccelerated = integerDotProduct64BitSignedAccelerated;
            this.integerDotProduct64BitMixedSignednessAccelerated = integerDotProduct64BitMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating8BitUnsignedAccelerated = integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating8BitSignedAccelerated = integerDotProductAccumulatingSaturating8BitSignedAccelerated;
            this.integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated = integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated = integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
            this.integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated = integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating16BitUnsignedAccelerated = integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating16BitSignedAccelerated = integerDotProductAccumulatingSaturating16BitSignedAccelerated;
            this.integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating32BitUnsignedAccelerated = integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating32BitSignedAccelerated = integerDotProductAccumulatingSaturating32BitSignedAccelerated;
            this.integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating64BitUnsignedAccelerated = integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating64BitSignedAccelerated = integerDotProductAccumulatingSaturating64BitSignedAccelerated;
            this.integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
            this.storageTexelBufferOffsetAlignmentBytes = storageTexelBufferOffsetAlignmentBytes;
            this.storageTexelBufferOffsetSingleTexelAlignment = storageTexelBufferOffsetSingleTexelAlignment;
            this.uniformTexelBufferOffsetAlignmentBytes = uniformTexelBufferOffsetAlignmentBytes;
            this.uniformTexelBufferOffsetSingleTexelAlignment = uniformTexelBufferOffsetSingleTexelAlignment;
            this.maxBufferSize = maxBufferSize;
        }
    }
    public unsafe struct VkPipelineCompilerControlCreateInfoAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineCompilerControlCreateInfoAmd;
        public void* pNext;
        public VkPipelineCompilerControlFlagBitsAMD compilerControlFlags;
        public VkPipelineCompilerControlCreateInfoAMD(VkStructureType sType, void* pNext, VkPipelineCompilerControlFlagBitsAMD compilerControlFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.compilerControlFlags = compilerControlFlags;
        }
    }
    public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCoherentMemoryFeaturesAmd;
        public void* pNext;
        public int deviceCoherentMemory;
        public VkPhysicalDeviceCoherentMemoryFeaturesAMD(VkStructureType sType, void* pNext, int deviceCoherentMemory)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceCoherentMemory = deviceCoherentMemory;
        }
    }
    public unsafe struct VkFaultData
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFaultLevel faultLevel;
        public VkFaultType faultType;
        public VkFaultData(VkStructureType sType, void* pNext, VkFaultLevel faultLevel, VkFaultType faultType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.faultLevel = faultLevel;
            this.faultType = faultType;
        }
    }
    public unsafe struct VkFaultCallbackInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint faultCount;
        public VkFaultData* pFaults;
        public delegate* unmanaged[Cdecl]<int, uint, VkFaultData*, void> pfnFaultCallback;
        public VkFaultCallbackInfo(VkStructureType sType, void* pNext, uint faultCount, VkFaultData* pFaults, delegate* unmanaged[Cdecl]<int, uint, VkFaultData*, void> pfnFaultCallback)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.faultCount = faultCount;
            this.pFaults = pFaults;
            this.pfnFaultCallback = pfnFaultCallback;
        }
    }
    public unsafe struct VkPhysicalDeviceToolProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceToolProperties;
        public void* pNext;
        [InlineArray(256)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        [InlineArray(256)]
        public struct versionInlineArray1
        {
            public byte element;
        }
        public versionInlineArray1 version;
        public VkToolPurposeFlagBits purposes;
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
        [InlineArray(256)]
        public struct layerInlineArray1
        {
            public byte element;
        }
        public layerInlineArray1 layer;
        public VkPhysicalDeviceToolProperties(){ }
    }
    public unsafe struct VkPhysicalDeviceToolPropertiesEXT
    {
        public VkPhysicalDeviceToolPropertiesEXT()
        {
        }
    }
    public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerCustomBorderColorCreateInfoExt;
        public void* pNext;
        public VkClearColorValue customBorderColor;
        public VkFormat format;
        public VkSamplerCustomBorderColorCreateInfoEXT(VkStructureType sType, void* pNext, VkClearColorValue customBorderColor, VkFormat format)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.customBorderColor = customBorderColor;
            this.format = format;
        }
    }
    public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCustomBorderColorPropertiesExt;
        public void* pNext;
        public uint maxCustomBorderColorSamplers;
        public VkPhysicalDeviceCustomBorderColorPropertiesEXT(VkStructureType sType, void* pNext, uint maxCustomBorderColorSamplers)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxCustomBorderColorSamplers = maxCustomBorderColorSamplers;
        }
    }
    public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCustomBorderColorFeaturesExt;
        public void* pNext;
        public int customBorderColors;
        public int customBorderColorWithoutFormat;
        public VkPhysicalDeviceCustomBorderColorFeaturesEXT(VkStructureType sType, void* pNext, int customBorderColors, int customBorderColorWithoutFormat)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.customBorderColors = customBorderColors;
            this.customBorderColorWithoutFormat = customBorderColorWithoutFormat;
        }
    }
    public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerBorderColorComponentMappingCreateInfoExt;
        public void* pNext;
        public VkComponentMapping components;
        public int srgb;
        public VkSamplerBorderColorComponentMappingCreateInfoEXT(VkStructureType sType, void* pNext, VkComponentMapping components, int srgb)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.components = components;
            this.srgb = srgb;
        }
    }
    public unsafe struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceBorderColorSwizzleFeaturesExt;
        public void* pNext;
        public int borderColorSwizzle;
        public int borderColorSwizzleFromImage;
        public VkPhysicalDeviceBorderColorSwizzleFeaturesEXT(VkStructureType sType, void* pNext, int borderColorSwizzle, int borderColorSwizzleFromImage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.borderColorSwizzle = borderColorSwizzle;
            this.borderColorSwizzleFromImage = borderColorSwizzleFromImage;
        }
    }
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkDeviceOrHostAddressKHR
    {
        [FieldOffset(0)]
        public ulong deviceAddress;
        [FieldOffset(0)]
        public void* hostAddress;
    }
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkDeviceOrHostAddressConstKHR
    {
        [FieldOffset(0)]
        public ulong deviceAddress;
        [FieldOffset(0)]
        public void* hostAddress;
    }
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkDeviceOrHostAddressConstAMDX
    {
        [FieldOffset(0)]
        public ulong deviceAddress;
        [FieldOffset(0)]
        public void* hostAddress;
    }
    public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureGeometryTrianglesDataKhr;
        public void* pNext;
        public VkFormat vertexFormat;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public ulong vertexStride;
        public uint maxVertex;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexData;
        public VkDeviceOrHostAddressConstKHR transformData;
        public VkAccelerationStructureGeometryTrianglesDataKHR(VkStructureType sType, void* pNext, VkFormat vertexFormat, VkDeviceOrHostAddressConstKHR vertexData, ulong vertexStride, uint maxVertex, VkIndexType indexType, VkDeviceOrHostAddressConstKHR indexData, VkDeviceOrHostAddressConstKHR transformData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.vertexFormat = vertexFormat;
            this.vertexData = vertexData;
            this.vertexStride = vertexStride;
            this.maxVertex = maxVertex;
            this.indexType = indexType;
            this.indexData = indexData;
            this.transformData = transformData;
        }
    }
    public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureGeometryAabbsDataKhr;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR data;
        public ulong stride;
        public VkAccelerationStructureGeometryAabbsDataKHR(VkStructureType sType, void* pNext, VkDeviceOrHostAddressConstKHR data, ulong stride)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.data = data;
            this.stride = stride;
        }
    }
    public unsafe struct VkAccelerationStructureGeometryInstancesDataKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureGeometryInstancesDataKhr;
        public void* pNext;
        public int arrayOfPointers;
        public VkDeviceOrHostAddressConstKHR data;
        public VkAccelerationStructureGeometryInstancesDataKHR(VkStructureType sType, void* pNext, int arrayOfPointers, VkDeviceOrHostAddressConstKHR data)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.arrayOfPointers = arrayOfPointers;
            this.data = data;
        }
    }
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkAccelerationStructureGeometryDataKHR
    {
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryTrianglesDataKHR triangles;
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryAabbsDataKHR aabbs;
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryInstancesDataKHR instances;
    }
    public unsafe struct VkAccelerationStructureGeometryKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureGeometryKhr;
        public void* pNext;
        public VkGeometryTypeKHR geometryType;
        public VkAccelerationStructureGeometryDataKHR geometry;
        public VkGeometryFlagBitsKHR flags;
        public VkAccelerationStructureGeometryKHR(VkStructureType sType, void* pNext, VkGeometryTypeKHR geometryType, VkAccelerationStructureGeometryDataKHR geometry, VkGeometryFlagBitsKHR flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.geometryType = geometryType;
            this.geometry = geometry;
            this.flags = flags;
        }
    }
    public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureBuildGeometryInfoKhr;
        public void* pNext;
        public VkAccelerationStructureTypeKHR type;
        public VkBuildAccelerationStructureFlagBitsKHR flags;
        public VkBuildAccelerationStructureModeKHR mode;
        public VkAccelerationStructureKHR srcAccelerationStructure;
        public VkAccelerationStructureKHR dstAccelerationStructure;
        public uint geometryCount;
        public VkAccelerationStructureGeometryKHR* pGeometries;
        public VkAccelerationStructureGeometryKHR** ppGeometries;
        public VkDeviceOrHostAddressKHR scratchData;
        public VkAccelerationStructureBuildGeometryInfoKHR(VkStructureType sType, void* pNext, VkAccelerationStructureTypeKHR type, VkBuildAccelerationStructureFlagBitsKHR flags, VkBuildAccelerationStructureModeKHR mode, VkAccelerationStructureKHR srcAccelerationStructure, VkAccelerationStructureKHR dstAccelerationStructure, uint geometryCount, VkAccelerationStructureGeometryKHR* pGeometries, VkAccelerationStructureGeometryKHR** ppGeometries, VkDeviceOrHostAddressKHR scratchData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.type = type;
            this.flags = flags;
            this.mode = mode;
            this.srcAccelerationStructure = srcAccelerationStructure;
            this.dstAccelerationStructure = dstAccelerationStructure;
            this.geometryCount = geometryCount;
            this.pGeometries = pGeometries;
            this.ppGeometries = ppGeometries;
            this.scratchData = scratchData;
        }
    }
    public unsafe struct VkAccelerationStructureBuildRangeInfoKHR
    {
        public uint primitiveCount;
        public uint primitiveOffset;
        public uint firstVertex;
        public uint transformOffset;
        public VkAccelerationStructureBuildRangeInfoKHR(uint primitiveCount, uint primitiveOffset, uint firstVertex, uint transformOffset)
        {
            this.primitiveCount = primitiveCount;
            this.primitiveOffset = primitiveOffset;
            this.firstVertex = firstVertex;
            this.transformOffset = transformOffset;
        }
    }
    public unsafe struct VkAccelerationStructureCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureCreateInfoKhr;
        public void* pNext;
        public VkAccelerationStructureCreateFlagBitsKHR createFlags;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public VkAccelerationStructureTypeKHR type;
        public ulong deviceAddress;
        public VkAccelerationStructureCreateInfoKHR(VkStructureType sType, void* pNext, VkAccelerationStructureCreateFlagBitsKHR createFlags, VkBuffer buffer, ulong offset, ulong size, VkAccelerationStructureTypeKHR type, ulong deviceAddress)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.createFlags = createFlags;
            this.buffer = buffer;
            this.offset = offset;
            this.size = size;
            this.type = type;
            this.deviceAddress = deviceAddress;
        }
    }
    public unsafe struct VkAabbPositionsKHR
    {
        public float minX;
        public float minY;
        public float minZ;
        public float maxX;
        public float maxY;
        public float maxZ;
        public VkAabbPositionsKHR(float minX, float minY, float minZ, float maxX, float maxY, float maxZ)
        {
            this.minX = minX;
            this.minY = minY;
            this.minZ = minZ;
            this.maxX = maxX;
            this.maxY = maxY;
            this.maxZ = maxZ;
        }
    }
    public unsafe struct VkAabbPositionsNV
    {
        public VkAabbPositionsNV()
        {
        }
    }
    public unsafe struct VkTransformMatrixKHR
    {
        public Matrix4x3 matrix;
        public VkTransformMatrixKHR(Matrix4x3 matrix)
        {
            this.matrix = matrix;
        }
    }
    public unsafe struct VkTransformMatrixNV
    {
        public VkTransformMatrixNV()
        {
        }
    }
    public unsafe struct VkAccelerationStructureInstanceKHR
    {
        public VkTransformMatrixKHR transform;
        private uint _bitfield0;
         // TODO: Accessor property for instanceCustomIndex, size: 24, offset: 0
        public uint instanceCustomIndex
        {
            get => (uint)((_bitfield0 >> 0) & 0xFFFFFFu);
            set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFu << 0)) | ((((uint)value) & 0xFFFFFFu) << 0);
        }
         // TODO: Accessor property for mask, size: 8, offset: 24
        public uint mask
        {
            get => (uint)((_bitfield0 >> 24) & 0xFFu);
            set => _bitfield0 = (_bitfield0 & ~(0xFFu << 24)) | ((((uint)value) & 0xFFu) << 24);
        }
        private uint _bitfield1;
         // TODO: Accessor property for instanceShaderBindingTableRecordOffset, size: 24, offset: 0
        public uint instanceShaderBindingTableRecordOffset
        {
            get => (uint)((_bitfield1 >> 0) & 0xFFFFFFu);
            set => _bitfield1 = (_bitfield1 & ~(0xFFFFFFu << 0)) | ((((uint)value) & 0xFFFFFFu) << 0);
        }
         // TODO: Accessor property for flags, size: 8, offset: 24
        public VkGeometryInstanceFlagBitsKHR flags
        {
            get => (VkGeometryInstanceFlagBitsKHR)((_bitfield1 >> 24) & 0xFFu);
            set => _bitfield1 = (_bitfield1 & ~(0xFFu << 24)) | ((((uint)value) & 0xFFu) << 24);
        }
        public ulong accelerationStructureReference;
    }
    public unsafe struct VkAccelerationStructureInstanceNV
    {
        public VkAccelerationStructureInstanceNV()
        {
        }
    }
    public unsafe struct VkAccelerationStructureDeviceAddressInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureDeviceAddressInfoKhr;
        public void* pNext;
        public VkAccelerationStructureKHR accelerationStructure;
        public VkAccelerationStructureDeviceAddressInfoKHR(VkStructureType sType, void* pNext, VkAccelerationStructureKHR accelerationStructure)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.accelerationStructure = accelerationStructure;
        }
    }
    public unsafe struct VkAccelerationStructureVersionInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureVersionInfoKhr;
        public void* pNext;
        public byte* pVersionData;
        public VkAccelerationStructureVersionInfoKHR(VkStructureType sType, void* pNext, byte* pVersionData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pVersionData = pVersionData;
        }
    }
    public unsafe struct VkCopyAccelerationStructureInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyAccelerationStructureInfoKhr;
        public void* pNext;
        public VkAccelerationStructureKHR src;
        public VkAccelerationStructureKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        public VkCopyAccelerationStructureInfoKHR(VkStructureType sType, void* pNext, VkAccelerationStructureKHR src, VkAccelerationStructureKHR dst, VkCopyAccelerationStructureModeKHR mode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.src = src;
            this.dst = dst;
            this.mode = mode;
        }
    }
    public unsafe struct VkCopyAccelerationStructureToMemoryInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyAccelerationStructureToMemoryInfoKhr;
        public void* pNext;
        public VkAccelerationStructureKHR src;
        public VkDeviceOrHostAddressKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        public VkCopyAccelerationStructureToMemoryInfoKHR(VkStructureType sType, void* pNext, VkAccelerationStructureKHR src, VkDeviceOrHostAddressKHR dst, VkCopyAccelerationStructureModeKHR mode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.src = src;
            this.dst = dst;
            this.mode = mode;
        }
    }
    public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyMemoryToAccelerationStructureInfoKhr;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR src;
        public VkAccelerationStructureKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        public VkCopyMemoryToAccelerationStructureInfoKHR(VkStructureType sType, void* pNext, VkDeviceOrHostAddressConstKHR src, VkAccelerationStructureKHR dst, VkCopyAccelerationStructureModeKHR mode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.src = src;
            this.dst = dst;
            this.mode = mode;
        }
    }
    public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeRayTracingPipelineInterfaceCreateInfoKhr;
        public void* pNext;
        public uint maxPipelineRayPayloadSize;
        public uint maxPipelineRayHitAttributeSize;
        public VkRayTracingPipelineInterfaceCreateInfoKHR(VkStructureType sType, void* pNext, uint maxPipelineRayPayloadSize, uint maxPipelineRayHitAttributeSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxPipelineRayPayloadSize = maxPipelineRayPayloadSize;
            this.maxPipelineRayHitAttributeSize = maxPipelineRayHitAttributeSize;
        }
    }
    public unsafe struct VkPipelineLibraryCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineLibraryCreateInfoKhr;
        public void* pNext;
        public uint libraryCount;
        public VkPipeline* pLibraries;
        public VkPipelineLibraryCreateInfoKHR(VkStructureType sType, void* pNext, uint libraryCount, VkPipeline* pLibraries)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.libraryCount = libraryCount;
            this.pLibraries = pLibraries;
        }
    }
    public unsafe struct VkRefreshObjectKHR
    {
        public VkObjectType objectType;
        public ulong objectHandle;
        public VkRefreshObjectFlagBitsKHR flags;
        public VkRefreshObjectKHR(VkObjectType objectType, ulong objectHandle, VkRefreshObjectFlagBitsKHR flags)
        {
            this.objectType = objectType;
            this.objectHandle = objectHandle;
            this.flags = flags;
        }
    }
    public unsafe struct VkRefreshObjectListKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeRefreshObjectListKhr;
        public void* pNext;
        public uint objectCount;
        public VkRefreshObjectKHR* pObjects;
        public VkRefreshObjectListKHR(VkStructureType sType, void* pNext, uint objectCount, VkRefreshObjectKHR* pObjects)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.objectCount = objectCount;
            this.pObjects = pObjects;
        }
    }
    public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExtendedDynamicStateFeaturesExt;
        public void* pNext;
        public int extendedDynamicState;
        public VkPhysicalDeviceExtendedDynamicStateFeaturesEXT(VkStructureType sType, void* pNext, int extendedDynamicState)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.extendedDynamicState = extendedDynamicState;
        }
    }
    public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExtendedDynamicState2FeaturesExt;
        public void* pNext;
        public int extendedDynamicState2;
        public int extendedDynamicState2LogicOp;
        public int extendedDynamicState2PatchControlPoints;
        public VkPhysicalDeviceExtendedDynamicState2FeaturesEXT(VkStructureType sType, void* pNext, int extendedDynamicState2, int extendedDynamicState2LogicOp, int extendedDynamicState2PatchControlPoints)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.extendedDynamicState2 = extendedDynamicState2;
            this.extendedDynamicState2LogicOp = extendedDynamicState2LogicOp;
            this.extendedDynamicState2PatchControlPoints = extendedDynamicState2PatchControlPoints;
        }
    }
    public unsafe struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExtendedDynamicState3FeaturesExt;
        public void* pNext;
        public int extendedDynamicState3TessellationDomainOrigin;
        public int extendedDynamicState3DepthClampEnable;
        public int extendedDynamicState3PolygonMode;
        public int extendedDynamicState3RasterizationSamples;
        public int extendedDynamicState3SampleMask;
        public int extendedDynamicState3AlphaToCoverageEnable;
        public int extendedDynamicState3AlphaToOneEnable;
        public int extendedDynamicState3LogicOpEnable;
        public int extendedDynamicState3ColorBlendEnable;
        public int extendedDynamicState3ColorBlendEquation;
        public int extendedDynamicState3ColorWriteMask;
        public int extendedDynamicState3RasterizationStream;
        public int extendedDynamicState3ConservativeRasterizationMode;
        public int extendedDynamicState3ExtraPrimitiveOverestimationSize;
        public int extendedDynamicState3DepthClipEnable;
        public int extendedDynamicState3SampleLocationsEnable;
        public int extendedDynamicState3ColorBlendAdvanced;
        public int extendedDynamicState3ProvokingVertexMode;
        public int extendedDynamicState3LineRasterizationMode;
        public int extendedDynamicState3LineStippleEnable;
        public int extendedDynamicState3DepthClipNegativeOneToOne;
        public int extendedDynamicState3ViewportWScalingEnable;
        public int extendedDynamicState3ViewportSwizzle;
        public int extendedDynamicState3CoverageToColorEnable;
        public int extendedDynamicState3CoverageToColorLocation;
        public int extendedDynamicState3CoverageModulationMode;
        public int extendedDynamicState3CoverageModulationTableEnable;
        public int extendedDynamicState3CoverageModulationTable;
        public int extendedDynamicState3CoverageReductionMode;
        public int extendedDynamicState3RepresentativeFragmentTestEnable;
        public int extendedDynamicState3ShadingRateImageEnable;
        public VkPhysicalDeviceExtendedDynamicState3FeaturesEXT(VkStructureType sType, void* pNext, int extendedDynamicState3TessellationDomainOrigin, int extendedDynamicState3DepthClampEnable, int extendedDynamicState3PolygonMode, int extendedDynamicState3RasterizationSamples, int extendedDynamicState3SampleMask, int extendedDynamicState3AlphaToCoverageEnable, int extendedDynamicState3AlphaToOneEnable, int extendedDynamicState3LogicOpEnable, int extendedDynamicState3ColorBlendEnable, int extendedDynamicState3ColorBlendEquation, int extendedDynamicState3ColorWriteMask, int extendedDynamicState3RasterizationStream, int extendedDynamicState3ConservativeRasterizationMode, int extendedDynamicState3ExtraPrimitiveOverestimationSize, int extendedDynamicState3DepthClipEnable, int extendedDynamicState3SampleLocationsEnable, int extendedDynamicState3ColorBlendAdvanced, int extendedDynamicState3ProvokingVertexMode, int extendedDynamicState3LineRasterizationMode, int extendedDynamicState3LineStippleEnable, int extendedDynamicState3DepthClipNegativeOneToOne, int extendedDynamicState3ViewportWScalingEnable, int extendedDynamicState3ViewportSwizzle, int extendedDynamicState3CoverageToColorEnable, int extendedDynamicState3CoverageToColorLocation, int extendedDynamicState3CoverageModulationMode, int extendedDynamicState3CoverageModulationTableEnable, int extendedDynamicState3CoverageModulationTable, int extendedDynamicState3CoverageReductionMode, int extendedDynamicState3RepresentativeFragmentTestEnable, int extendedDynamicState3ShadingRateImageEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.extendedDynamicState3TessellationDomainOrigin = extendedDynamicState3TessellationDomainOrigin;
            this.extendedDynamicState3DepthClampEnable = extendedDynamicState3DepthClampEnable;
            this.extendedDynamicState3PolygonMode = extendedDynamicState3PolygonMode;
            this.extendedDynamicState3RasterizationSamples = extendedDynamicState3RasterizationSamples;
            this.extendedDynamicState3SampleMask = extendedDynamicState3SampleMask;
            this.extendedDynamicState3AlphaToCoverageEnable = extendedDynamicState3AlphaToCoverageEnable;
            this.extendedDynamicState3AlphaToOneEnable = extendedDynamicState3AlphaToOneEnable;
            this.extendedDynamicState3LogicOpEnable = extendedDynamicState3LogicOpEnable;
            this.extendedDynamicState3ColorBlendEnable = extendedDynamicState3ColorBlendEnable;
            this.extendedDynamicState3ColorBlendEquation = extendedDynamicState3ColorBlendEquation;
            this.extendedDynamicState3ColorWriteMask = extendedDynamicState3ColorWriteMask;
            this.extendedDynamicState3RasterizationStream = extendedDynamicState3RasterizationStream;
            this.extendedDynamicState3ConservativeRasterizationMode = extendedDynamicState3ConservativeRasterizationMode;
            this.extendedDynamicState3ExtraPrimitiveOverestimationSize = extendedDynamicState3ExtraPrimitiveOverestimationSize;
            this.extendedDynamicState3DepthClipEnable = extendedDynamicState3DepthClipEnable;
            this.extendedDynamicState3SampleLocationsEnable = extendedDynamicState3SampleLocationsEnable;
            this.extendedDynamicState3ColorBlendAdvanced = extendedDynamicState3ColorBlendAdvanced;
            this.extendedDynamicState3ProvokingVertexMode = extendedDynamicState3ProvokingVertexMode;
            this.extendedDynamicState3LineRasterizationMode = extendedDynamicState3LineRasterizationMode;
            this.extendedDynamicState3LineStippleEnable = extendedDynamicState3LineStippleEnable;
            this.extendedDynamicState3DepthClipNegativeOneToOne = extendedDynamicState3DepthClipNegativeOneToOne;
            this.extendedDynamicState3ViewportWScalingEnable = extendedDynamicState3ViewportWScalingEnable;
            this.extendedDynamicState3ViewportSwizzle = extendedDynamicState3ViewportSwizzle;
            this.extendedDynamicState3CoverageToColorEnable = extendedDynamicState3CoverageToColorEnable;
            this.extendedDynamicState3CoverageToColorLocation = extendedDynamicState3CoverageToColorLocation;
            this.extendedDynamicState3CoverageModulationMode = extendedDynamicState3CoverageModulationMode;
            this.extendedDynamicState3CoverageModulationTableEnable = extendedDynamicState3CoverageModulationTableEnable;
            this.extendedDynamicState3CoverageModulationTable = extendedDynamicState3CoverageModulationTable;
            this.extendedDynamicState3CoverageReductionMode = extendedDynamicState3CoverageReductionMode;
            this.extendedDynamicState3RepresentativeFragmentTestEnable = extendedDynamicState3RepresentativeFragmentTestEnable;
            this.extendedDynamicState3ShadingRateImageEnable = extendedDynamicState3ShadingRateImageEnable;
        }
    }
    public unsafe struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExtendedDynamicState3PropertiesExt;
        public void* pNext;
        public int dynamicPrimitiveTopologyUnrestricted;
        public VkPhysicalDeviceExtendedDynamicState3PropertiesEXT(VkStructureType sType, void* pNext, int dynamicPrimitiveTopologyUnrestricted)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dynamicPrimitiveTopologyUnrestricted = dynamicPrimitiveTopologyUnrestricted;
        }
    }
    public unsafe struct VkColorBlendEquationEXT
    {
        public VkBlendFactor srcColorBlendFactor;
        public VkBlendFactor dstColorBlendFactor;
        public VkBlendOp colorBlendOp;
        public VkBlendFactor srcAlphaBlendFactor;
        public VkBlendFactor dstAlphaBlendFactor;
        public VkBlendOp alphaBlendOp;
        public VkColorBlendEquationEXT(VkBlendFactor srcColorBlendFactor, VkBlendFactor dstColorBlendFactor, VkBlendOp colorBlendOp, VkBlendFactor srcAlphaBlendFactor, VkBlendFactor dstAlphaBlendFactor, VkBlendOp alphaBlendOp)
        {
            this.srcColorBlendFactor = srcColorBlendFactor;
            this.dstColorBlendFactor = dstColorBlendFactor;
            this.colorBlendOp = colorBlendOp;
            this.srcAlphaBlendFactor = srcAlphaBlendFactor;
            this.dstAlphaBlendFactor = dstAlphaBlendFactor;
            this.alphaBlendOp = alphaBlendOp;
        }
    }
    public unsafe struct VkColorBlendAdvancedEXT
    {
        public VkBlendOp advancedBlendOp;
        public int srcPremultiplied;
        public int dstPremultiplied;
        public VkBlendOverlapEXT blendOverlap;
        public int clampResults;
        public VkColorBlendAdvancedEXT(VkBlendOp advancedBlendOp, int srcPremultiplied, int dstPremultiplied, VkBlendOverlapEXT blendOverlap, int clampResults)
        {
            this.advancedBlendOp = advancedBlendOp;
            this.srcPremultiplied = srcPremultiplied;
            this.dstPremultiplied = dstPremultiplied;
            this.blendOverlap = blendOverlap;
            this.clampResults = clampResults;
        }
    }
    public unsafe struct VkRenderPassTransformBeginInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassTransformBeginInfoQcom;
        public void* pNext;
        public VkSurfaceTransformFlagBitsKHR transform;
        public VkRenderPassTransformBeginInfoQCOM(VkStructureType sType, void* pNext, VkSurfaceTransformFlagBitsKHR transform)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.transform = transform;
        }
    }
    public unsafe struct VkCopyCommandTransformInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyCommandTransformInfoQcom;
        public void* pNext;
        public VkSurfaceTransformFlagBitsKHR transform;
        public VkCopyCommandTransformInfoQCOM(VkStructureType sType, void* pNext, VkSurfaceTransformFlagBitsKHR transform)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.transform = transform;
        }
    }
    public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeCommandBufferInheritanceRenderPassTransformInfoQcom;
        public void* pNext;
        public VkSurfaceTransformFlagBitsKHR transform;
        public VkRect2D renderArea;
        public VkCommandBufferInheritanceRenderPassTransformInfoQCOM(VkStructureType sType, void* pNext, VkSurfaceTransformFlagBitsKHR transform, VkRect2D renderArea)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.transform = transform;
            this.renderArea = renderArea;
        }
    }
    public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDiagnosticsConfigFeaturesNv;
        public void* pNext;
        public int diagnosticsConfig;
        public VkPhysicalDeviceDiagnosticsConfigFeaturesNV(VkStructureType sType, void* pNext, int diagnosticsConfig)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.diagnosticsConfig = diagnosticsConfig;
        }
    }
    public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceDiagnosticsConfigCreateInfoNv;
        public void* pNext;
        public VkDeviceDiagnosticsConfigFlagBitsNV flags;
        public VkDeviceDiagnosticsConfigCreateInfoNV(VkStructureType sType, void* pNext, VkDeviceDiagnosticsConfigFlagBitsNV flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkPipelineOfflineCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte pipelineIdentifier[16];
        public VkPipelineMatchControl matchControl;
        public ulong poolEntrySize;
    }
    public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceZeroInitializeWorkgroupMemoryFeatures;
        public void* pNext;
        public int shaderZeroInitializeWorkgroupMemory;
        public VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures(VkStructureType sType, void* pNext, int shaderZeroInitializeWorkgroupMemory)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderZeroInitializeWorkgroupMemory = shaderZeroInitializeWorkgroupMemory;
        }
    }
    public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR
    {
        public VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr;
        public void* pNext;
        public int shaderSubgroupUniformControlFlow;
        public VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR(VkStructureType sType, void* pNext, int shaderSubgroupUniformControlFlow)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderSubgroupUniformControlFlow = shaderSubgroupUniformControlFlow;
        }
    }
    public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRobustness2FeaturesExt;
        public void* pNext;
        public int robustBufferAccess2;
        public int robustImageAccess2;
        public int nullDescriptor;
        public VkPhysicalDeviceRobustness2FeaturesEXT(VkStructureType sType, void* pNext, int robustBufferAccess2, int robustImageAccess2, int nullDescriptor)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.robustBufferAccess2 = robustBufferAccess2;
            this.robustImageAccess2 = robustImageAccess2;
            this.nullDescriptor = nullDescriptor;
        }
    }
    public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRobustness2PropertiesExt;
        public void* pNext;
        public ulong robustStorageBufferAccessSizeAlignment;
        public ulong robustUniformBufferAccessSizeAlignment;
        public VkPhysicalDeviceRobustness2PropertiesEXT(VkStructureType sType, void* pNext, ulong robustStorageBufferAccessSizeAlignment, ulong robustUniformBufferAccessSizeAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.robustStorageBufferAccessSizeAlignment = robustStorageBufferAccessSizeAlignment;
            this.robustUniformBufferAccessSizeAlignment = robustUniformBufferAccessSizeAlignment;
        }
    }
    public unsafe struct VkPhysicalDeviceImageRobustnessFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageRobustnessFeatures;
        public void* pNext;
        public int robustImageAccess;
        public VkPhysicalDeviceImageRobustnessFeatures(VkStructureType sType, void* pNext, int robustImageAccess)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.robustImageAccess = robustImageAccess;
        }
    }
    public unsafe struct VkPhysicalDeviceImageRobustnessFeaturesEXT
    {
        public VkPhysicalDeviceImageRobustnessFeaturesEXT()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr;
        public void* pNext;
        public int workgroupMemoryExplicitLayout;
        public int workgroupMemoryExplicitLayoutScalarBlockLayout;
        public int workgroupMemoryExplicitLayout8BitAccess;
        public int workgroupMemoryExplicitLayout16BitAccess;
        public VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR(VkStructureType sType, void* pNext, int workgroupMemoryExplicitLayout, int workgroupMemoryExplicitLayoutScalarBlockLayout, int workgroupMemoryExplicitLayout8BitAccess, int workgroupMemoryExplicitLayout16BitAccess)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.workgroupMemoryExplicitLayout = workgroupMemoryExplicitLayout;
            this.workgroupMemoryExplicitLayoutScalarBlockLayout = workgroupMemoryExplicitLayoutScalarBlockLayout;
            this.workgroupMemoryExplicitLayout8BitAccess = workgroupMemoryExplicitLayout8BitAccess;
            this.workgroupMemoryExplicitLayout16BitAccess = workgroupMemoryExplicitLayout16BitAccess;
        }
    }
    public unsafe struct VkPhysicalDevicePortabilitySubsetFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePortabilitySubsetFeaturesKhr;
        public void* pNext;
        public int constantAlphaColorBlendFactors;
        public int events;
        public int imageViewFormatReinterpretation;
        public int imageViewFormatSwizzle;
        public int imageView2DOn3DImage;
        public int multisampleArrayImage;
        public int mutableComparisonSamplers;
        public int pointPolygons;
        public int samplerMipLodBias;
        public int separateStencilMaskRef;
        public int shaderSampleRateInterpolationFunctions;
        public int tessellationIsolines;
        public int tessellationPointMode;
        public int triangleFans;
        public int vertexAttributeAccessBeyondStride;
        public VkPhysicalDevicePortabilitySubsetFeaturesKHR(VkStructureType sType, void* pNext, int constantAlphaColorBlendFactors, int events, int imageViewFormatReinterpretation, int imageViewFormatSwizzle, int imageView2DOn3DImage, int multisampleArrayImage, int mutableComparisonSamplers, int pointPolygons, int samplerMipLodBias, int separateStencilMaskRef, int shaderSampleRateInterpolationFunctions, int tessellationIsolines, int tessellationPointMode, int triangleFans, int vertexAttributeAccessBeyondStride)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.constantAlphaColorBlendFactors = constantAlphaColorBlendFactors;
            this.events = events;
            this.imageViewFormatReinterpretation = imageViewFormatReinterpretation;
            this.imageViewFormatSwizzle = imageViewFormatSwizzle;
            this.imageView2DOn3DImage = imageView2DOn3DImage;
            this.multisampleArrayImage = multisampleArrayImage;
            this.mutableComparisonSamplers = mutableComparisonSamplers;
            this.pointPolygons = pointPolygons;
            this.samplerMipLodBias = samplerMipLodBias;
            this.separateStencilMaskRef = separateStencilMaskRef;
            this.shaderSampleRateInterpolationFunctions = shaderSampleRateInterpolationFunctions;
            this.tessellationIsolines = tessellationIsolines;
            this.tessellationPointMode = tessellationPointMode;
            this.triangleFans = triangleFans;
            this.vertexAttributeAccessBeyondStride = vertexAttributeAccessBeyondStride;
        }
    }
    public unsafe struct VkPhysicalDevicePortabilitySubsetPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePortabilitySubsetPropertiesKhr;
        public void* pNext;
        public uint minVertexInputBindingStrideAlignment;
        public VkPhysicalDevicePortabilitySubsetPropertiesKHR(VkStructureType sType, void* pNext, uint minVertexInputBindingStrideAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minVertexInputBindingStrideAlignment = minVertexInputBindingStrideAlignment;
        }
    }
    public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevice4444FormatsFeaturesExt;
        public void* pNext;
        public int formatA4R4G4B4;
        public int formatA4B4G4R4;
        public VkPhysicalDevice4444FormatsFeaturesEXT(VkStructureType sType, void* pNext, int formatA4R4G4B4, int formatA4B4G4R4)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.formatA4R4G4B4 = formatA4R4G4B4;
            this.formatA4B4G4R4 = formatA4B4G4R4;
        }
    }
    public unsafe struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSubpassShadingFeaturesHuawei;
        public void* pNext;
        public int subpassShading;
        public VkPhysicalDeviceSubpassShadingFeaturesHUAWEI(VkStructureType sType, void* pNext, int subpassShading)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.subpassShading = subpassShading;
        }
    }
    public unsafe struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceClusterCullingShaderFeaturesHuawei;
        public void* pNext;
        public int clustercullingShader;
        public int multiviewClusterCullingShader;
        public VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI(VkStructureType sType, void* pNext, int clustercullingShader, int multiviewClusterCullingShader)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.clustercullingShader = clustercullingShader;
            this.multiviewClusterCullingShader = multiviewClusterCullingShader;
        }
    }
    public unsafe struct VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceClusterCullingShaderVrsFeaturesHuawei;
        public void* pNext;
        public int clusterShadingRate;
        public VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI(VkStructureType sType, void* pNext, int clusterShadingRate)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.clusterShadingRate = clusterShadingRate;
        }
    }
    public unsafe struct VkBufferCopy2
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferCopy2;
        public void* pNext;
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
        public VkBufferCopy2(VkStructureType sType, void* pNext, ulong srcOffset, ulong dstOffset, ulong size)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcOffset = srcOffset;
            this.dstOffset = dstOffset;
            this.size = size;
        }
    }
    public unsafe struct VkBufferCopy2KHR
    {
        public VkBufferCopy2KHR()
        {
        }
    }
    public unsafe struct VkImageCopy2
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageCopy2;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
        public VkImageCopy2(VkStructureType sType, void* pNext, VkImageSubresourceLayers srcSubresource, VkOffset3D srcOffset, VkImageSubresourceLayers dstSubresource, VkOffset3D dstOffset, VkExtent3D extent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcSubresource = srcSubresource;
            this.srcOffset = srcOffset;
            this.dstSubresource = dstSubresource;
            this.dstOffset = dstOffset;
            this.extent = extent;
        }
    }
    public unsafe struct VkImageCopy2KHR
    {
        public VkImageCopy2KHR()
        {
        }
    }
    public unsafe struct VkImageBlit2
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageBlit2;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        [InlineArray(2)]
        public struct srcOffsetsInlineArray1
        {
            public VkOffset3D element;
        }
        public srcOffsetsInlineArray1 srcOffsets;
        public VkImageSubresourceLayers dstSubresource;
        [InlineArray(2)]
        public struct dstOffsetsInlineArray1
        {
            public VkOffset3D element;
        }
        public dstOffsetsInlineArray1 dstOffsets;
        public VkImageBlit2(){ }
    }
    public unsafe struct VkImageBlit2KHR
    {
        public VkImageBlit2KHR()
        {
        }
    }
    public unsafe struct VkBufferImageCopy2
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferImageCopy2;
        public void* pNext;
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        public VkBufferImageCopy2(VkStructureType sType, void* pNext, ulong bufferOffset, uint bufferRowLength, uint bufferImageHeight, VkImageSubresourceLayers imageSubresource, VkOffset3D imageOffset, VkExtent3D imageExtent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.bufferOffset = bufferOffset;
            this.bufferRowLength = bufferRowLength;
            this.bufferImageHeight = bufferImageHeight;
            this.imageSubresource = imageSubresource;
            this.imageOffset = imageOffset;
            this.imageExtent = imageExtent;
        }
    }
    public unsafe struct VkBufferImageCopy2KHR
    {
        public VkBufferImageCopy2KHR()
        {
        }
    }
    public unsafe struct VkImageResolve2
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageResolve2;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
        public VkImageResolve2(VkStructureType sType, void* pNext, VkImageSubresourceLayers srcSubresource, VkOffset3D srcOffset, VkImageSubresourceLayers dstSubresource, VkOffset3D dstOffset, VkExtent3D extent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcSubresource = srcSubresource;
            this.srcOffset = srcOffset;
            this.dstSubresource = dstSubresource;
            this.dstOffset = dstOffset;
            this.extent = extent;
        }
    }
    public unsafe struct VkImageResolve2KHR
    {
        public VkImageResolve2KHR()
        {
        }
    }
    public unsafe struct VkCopyBufferInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyBufferInfo2;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferCopy2* pRegions;
        public VkCopyBufferInfo2(VkStructureType sType, void* pNext, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy2* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcBuffer = srcBuffer;
            this.dstBuffer = dstBuffer;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkCopyBufferInfo2KHR
    {
        public VkCopyBufferInfo2KHR()
        {
        }
    }
    public unsafe struct VkCopyImageInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyImageInfo2;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageCopy2* pRegions;
        public VkCopyImageInfo2(VkStructureType sType, void* pNext, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy2* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcImage = srcImage;
            this.srcImageLayout = srcImageLayout;
            this.dstImage = dstImage;
            this.dstImageLayout = dstImageLayout;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkCopyImageInfo2KHR
    {
        public VkCopyImageInfo2KHR()
        {
        }
    }
    public unsafe struct VkBlitImageInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeBlitImageInfo2;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageBlit2* pRegions;
        public VkFilter filter;
        public VkBlitImageInfo2(VkStructureType sType, void* pNext, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit2* pRegions, VkFilter filter)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcImage = srcImage;
            this.srcImageLayout = srcImageLayout;
            this.dstImage = dstImage;
            this.dstImageLayout = dstImageLayout;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
            this.filter = filter;
        }
    }
    public unsafe struct VkBlitImageInfo2KHR
    {
        public VkBlitImageInfo2KHR()
        {
        }
    }
    public unsafe struct VkCopyBufferToImageInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyBufferToImageInfo2;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkBufferImageCopy2* pRegions;
        public VkCopyBufferToImageInfo2(VkStructureType sType, void* pNext, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy2* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcBuffer = srcBuffer;
            this.dstImage = dstImage;
            this.dstImageLayout = dstImageLayout;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkCopyBufferToImageInfo2KHR
    {
        public VkCopyBufferToImageInfo2KHR()
        {
        }
    }
    public unsafe struct VkCopyImageToBufferInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyImageToBufferInfo2;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferImageCopy2* pRegions;
        public VkCopyImageToBufferInfo2(VkStructureType sType, void* pNext, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy2* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcImage = srcImage;
            this.srcImageLayout = srcImageLayout;
            this.dstBuffer = dstBuffer;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkCopyImageToBufferInfo2KHR
    {
        public VkCopyImageToBufferInfo2KHR()
        {
        }
    }
    public unsafe struct VkResolveImageInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeResolveImageInfo2;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageResolve2* pRegions;
        public VkResolveImageInfo2(VkStructureType sType, void* pNext, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve2* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcImage = srcImage;
            this.srcImageLayout = srcImageLayout;
            this.dstImage = dstImage;
            this.dstImageLayout = dstImageLayout;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkResolveImageInfo2KHR
    {
        public VkResolveImageInfo2KHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderImageAtomicInt64FeaturesExt;
        public void* pNext;
        public int shaderImageInt64Atomics;
        public int sparseImageInt64Atomics;
        public VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT(VkStructureType sType, void* pNext, int shaderImageInt64Atomics, int sparseImageInt64Atomics)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderImageInt64Atomics = shaderImageInt64Atomics;
            this.sparseImageInt64Atomics = sparseImageInt64Atomics;
        }
    }
    public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeFragmentShadingRateAttachmentInfoKhr;
        public void* pNext;
        public VkAttachmentReference2* pFragmentShadingRateAttachment;
        public VkExtent2D shadingRateAttachmentTexelSize;
        public VkFragmentShadingRateAttachmentInfoKHR(VkStructureType sType, void* pNext, VkAttachmentReference2* pFragmentShadingRateAttachment, VkExtent2D shadingRateAttachmentTexelSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pFragmentShadingRateAttachment = pFragmentShadingRateAttachment;
            this.shadingRateAttachmentTexelSize = shadingRateAttachmentTexelSize;
        }
    }
    public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineFragmentShadingRateStateCreateInfoKhr;
        public void* pNext;
        public VkExtent2D fragmentSize;
        [InlineArray(2)]
        public struct combinerOpsInlineArray1
        {
            public VkFragmentShadingRateCombinerOpKHR element;
        }
        public combinerOpsInlineArray1 combinerOps;
        public VkPipelineFragmentShadingRateStateCreateInfoKHR(){ }
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentShadingRateFeaturesKhr;
        public void* pNext;
        public int pipelineFragmentShadingRate;
        public int primitiveFragmentShadingRate;
        public int attachmentFragmentShadingRate;
        public VkPhysicalDeviceFragmentShadingRateFeaturesKHR(VkStructureType sType, void* pNext, int pipelineFragmentShadingRate, int primitiveFragmentShadingRate, int attachmentFragmentShadingRate)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineFragmentShadingRate = pipelineFragmentShadingRate;
            this.primitiveFragmentShadingRate = primitiveFragmentShadingRate;
            this.attachmentFragmentShadingRate = attachmentFragmentShadingRate;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentShadingRatePropertiesKhr;
        public void* pNext;
        public VkExtent2D minFragmentShadingRateAttachmentTexelSize;
        public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;
        public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
        public int primitiveFragmentShadingRateWithMultipleViewports;
        public int layeredShadingRateAttachments;
        public int fragmentShadingRateNonTrivialCombinerOps;
        public VkExtent2D maxFragmentSize;
        public uint maxFragmentSizeAspectRatio;
        public uint maxFragmentShadingRateCoverageSamples;
        public VkSampleCountFlagBits maxFragmentShadingRateRasterizationSamples;
        public int fragmentShadingRateWithShaderDepthStencilWrites;
        public int fragmentShadingRateWithSampleMask;
        public int fragmentShadingRateWithShaderSampleMask;
        public int fragmentShadingRateWithConservativeRasterization;
        public int fragmentShadingRateWithFragmentShaderInterlock;
        public int fragmentShadingRateWithCustomSampleLocations;
        public int fragmentShadingRateStrictMultiplyCombiner;
        public VkPhysicalDeviceFragmentShadingRatePropertiesKHR(VkStructureType sType, void* pNext, VkExtent2D minFragmentShadingRateAttachmentTexelSize, VkExtent2D maxFragmentShadingRateAttachmentTexelSize, uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio, int primitiveFragmentShadingRateWithMultipleViewports, int layeredShadingRateAttachments, int fragmentShadingRateNonTrivialCombinerOps, VkExtent2D maxFragmentSize, uint maxFragmentSizeAspectRatio, uint maxFragmentShadingRateCoverageSamples, VkSampleCountFlagBits maxFragmentShadingRateRasterizationSamples, int fragmentShadingRateWithShaderDepthStencilWrites, int fragmentShadingRateWithSampleMask, int fragmentShadingRateWithShaderSampleMask, int fragmentShadingRateWithConservativeRasterization, int fragmentShadingRateWithFragmentShaderInterlock, int fragmentShadingRateWithCustomSampleLocations, int fragmentShadingRateStrictMultiplyCombiner)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minFragmentShadingRateAttachmentTexelSize = minFragmentShadingRateAttachmentTexelSize;
            this.maxFragmentShadingRateAttachmentTexelSize = maxFragmentShadingRateAttachmentTexelSize;
            this.maxFragmentShadingRateAttachmentTexelSizeAspectRatio = maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
            this.primitiveFragmentShadingRateWithMultipleViewports = primitiveFragmentShadingRateWithMultipleViewports;
            this.layeredShadingRateAttachments = layeredShadingRateAttachments;
            this.fragmentShadingRateNonTrivialCombinerOps = fragmentShadingRateNonTrivialCombinerOps;
            this.maxFragmentSize = maxFragmentSize;
            this.maxFragmentSizeAspectRatio = maxFragmentSizeAspectRatio;
            this.maxFragmentShadingRateCoverageSamples = maxFragmentShadingRateCoverageSamples;
            this.maxFragmentShadingRateRasterizationSamples = maxFragmentShadingRateRasterizationSamples;
            this.fragmentShadingRateWithShaderDepthStencilWrites = fragmentShadingRateWithShaderDepthStencilWrites;
            this.fragmentShadingRateWithSampleMask = fragmentShadingRateWithSampleMask;
            this.fragmentShadingRateWithShaderSampleMask = fragmentShadingRateWithShaderSampleMask;
            this.fragmentShadingRateWithConservativeRasterization = fragmentShadingRateWithConservativeRasterization;
            this.fragmentShadingRateWithFragmentShaderInterlock = fragmentShadingRateWithFragmentShaderInterlock;
            this.fragmentShadingRateWithCustomSampleLocations = fragmentShadingRateWithCustomSampleLocations;
            this.fragmentShadingRateStrictMultiplyCombiner = fragmentShadingRateStrictMultiplyCombiner;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentShadingRateKhr;
        public void* pNext;
        public VkSampleCountFlagBits sampleCounts;
        public VkExtent2D fragmentSize;
        public VkPhysicalDeviceFragmentShadingRateKHR(VkStructureType sType, void* pNext, VkSampleCountFlagBits sampleCounts, VkExtent2D fragmentSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sampleCounts = sampleCounts;
            this.fragmentSize = fragmentSize;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderTerminateInvocationFeatures;
        public void* pNext;
        public int shaderTerminateInvocation;
        public VkPhysicalDeviceShaderTerminateInvocationFeatures(VkStructureType sType, void* pNext, int shaderTerminateInvocation)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderTerminateInvocation = shaderTerminateInvocation;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR
    {
        public VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentShadingRateEnumsFeaturesNv;
        public void* pNext;
        public int fragmentShadingRateEnums;
        public int supersampleFragmentShadingRates;
        public int noInvocationFragmentShadingRates;
        public VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV(VkStructureType sType, void* pNext, int fragmentShadingRateEnums, int supersampleFragmentShadingRates, int noInvocationFragmentShadingRates)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fragmentShadingRateEnums = fragmentShadingRateEnums;
            this.supersampleFragmentShadingRates = supersampleFragmentShadingRates;
            this.noInvocationFragmentShadingRates = noInvocationFragmentShadingRates;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentShadingRateEnumsPropertiesNv;
        public void* pNext;
        public VkSampleCountFlagBits maxFragmentShadingRateInvocationCount;
        public VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV(VkStructureType sType, void* pNext, VkSampleCountFlagBits maxFragmentShadingRateInvocationCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxFragmentShadingRateInvocationCount = maxFragmentShadingRateInvocationCount;
        }
    }
    public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineFragmentShadingRateEnumStateCreateInfoNv;
        public void* pNext;
        public VkFragmentShadingRateTypeNV shadingRateType;
        public VkFragmentShadingRateNV shadingRate;
        [InlineArray(2)]
        public struct combinerOpsInlineArray1
        {
            public VkFragmentShadingRateCombinerOpKHR element;
        }
        public combinerOpsInlineArray1 combinerOps;
        public VkPipelineFragmentShadingRateEnumStateCreateInfoNV(){ }
    }
    public unsafe struct VkAccelerationStructureBuildSizesInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureBuildSizesInfoKhr;
        public void* pNext;
        public ulong accelerationStructureSize;
        public ulong updateScratchSize;
        public ulong buildScratchSize;
        public VkAccelerationStructureBuildSizesInfoKHR(VkStructureType sType, void* pNext, ulong accelerationStructureSize, ulong updateScratchSize, ulong buildScratchSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.accelerationStructureSize = accelerationStructureSize;
            this.updateScratchSize = updateScratchSize;
            this.buildScratchSize = buildScratchSize;
        }
    }
    public unsafe struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImage2dViewOf3dFeaturesExt;
        public void* pNext;
        public int image2DViewOf3D;
        public int sampler2DViewOf3D;
        public VkPhysicalDeviceImage2DViewOf3DFeaturesEXT(VkStructureType sType, void* pNext, int image2DViewOf3D, int sampler2DViewOf3D)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image2DViewOf3D = image2DViewOf3D;
            this.sampler2DViewOf3D = sampler2DViewOf3D;
        }
    }
    public unsafe struct VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageSlicedViewOf3dFeaturesExt;
        public void* pNext;
        public int imageSlicedViewOf3D;
        public VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT(VkStructureType sType, void* pNext, int imageSlicedViewOf3D)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageSlicedViewOf3D = imageSlicedViewOf3D;
        }
    }
    public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesExt;
        public void* pNext;
        public int attachmentFeedbackLoopDynamicState;
        public VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT(VkStructureType sType, void* pNext, int attachmentFeedbackLoopDynamicState)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.attachmentFeedbackLoopDynamicState = attachmentFeedbackLoopDynamicState;
        }
    }
    public unsafe struct VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLegacyVertexAttributesFeaturesExt;
        public void* pNext;
        public int legacyVertexAttributes;
        public VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT(VkStructureType sType, void* pNext, int legacyVertexAttributes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.legacyVertexAttributes = legacyVertexAttributes;
        }
    }
    public unsafe struct VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLegacyVertexAttributesPropertiesExt;
        public void* pNext;
        public int nativeUnalignedPerformance;
        public VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT(VkStructureType sType, void* pNext, int nativeUnalignedPerformance)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.nativeUnalignedPerformance = nativeUnalignedPerformance;
        }
    }
    public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMutableDescriptorTypeFeaturesExt;
        public void* pNext;
        public int mutableDescriptorType;
        public VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT(VkStructureType sType, void* pNext, int mutableDescriptorType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.mutableDescriptorType = mutableDescriptorType;
        }
    }
    public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
    {
        public VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE()
        {
        }
    }
    public unsafe struct VkMutableDescriptorTypeListEXT
    {
        public uint descriptorTypeCount;
        public VkDescriptorType* pDescriptorTypes;
        public VkMutableDescriptorTypeListEXT(uint descriptorTypeCount, VkDescriptorType* pDescriptorTypes)
        {
            this.descriptorTypeCount = descriptorTypeCount;
            this.pDescriptorTypes = pDescriptorTypes;
        }
    }
    public unsafe struct VkMutableDescriptorTypeListVALVE
    {
        public VkMutableDescriptorTypeListVALVE()
        {
        }
    }
    public unsafe struct VkMutableDescriptorTypeCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMutableDescriptorTypeCreateInfoExt;
        public void* pNext;
        public uint mutableDescriptorTypeListCount;
        public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
        public VkMutableDescriptorTypeCreateInfoEXT(VkStructureType sType, void* pNext, uint mutableDescriptorTypeListCount, VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.mutableDescriptorTypeListCount = mutableDescriptorTypeListCount;
            this.pMutableDescriptorTypeLists = pMutableDescriptorTypeLists;
        }
    }
    public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
    {
        public VkMutableDescriptorTypeCreateInfoVALVE()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceDepthClipControlFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDepthClipControlFeaturesExt;
        public void* pNext;
        public int depthClipControl;
        public VkPhysicalDeviceDepthClipControlFeaturesEXT(VkStructureType sType, void* pNext, int depthClipControl)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.depthClipControl = depthClipControl;
        }
    }
    public unsafe struct VkPipelineViewportDepthClipControlCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineViewportDepthClipControlCreateInfoExt;
        public void* pNext;
        public int negativeOneToOne;
        public VkPipelineViewportDepthClipControlCreateInfoEXT(VkStructureType sType, void* pNext, int negativeOneToOne)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.negativeOneToOne = negativeOneToOne;
        }
    }
    public unsafe struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVertexInputDynamicStateFeaturesExt;
        public void* pNext;
        public int vertexInputDynamicState;
        public VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT(VkStructureType sType, void* pNext, int vertexInputDynamicState)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.vertexInputDynamicState = vertexInputDynamicState;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalMemoryRdmaFeaturesNv;
        public void* pNext;
        public int externalMemoryRDMA;
        public VkPhysicalDeviceExternalMemoryRDMAFeaturesNV(VkStructureType sType, void* pNext, int externalMemoryRDMA)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.externalMemoryRDMA = externalMemoryRDMA;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKhr;
        public void* pNext;
        public int shaderRelaxedExtendedInstruction;
        public VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR(VkStructureType sType, void* pNext, int shaderRelaxedExtendedInstruction)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderRelaxedExtendedInstruction = shaderRelaxedExtendedInstruction;
        }
    }
    public unsafe struct VkVertexInputBindingDescription2EXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeVertexInputBindingDescription2Ext;
        public void* pNext;
        public uint binding;
        public uint stride;
        public VkVertexInputRate inputRate;
        public uint divisor;
        public VkVertexInputBindingDescription2EXT(VkStructureType sType, void* pNext, uint binding, uint stride, VkVertexInputRate inputRate, uint divisor)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.binding = binding;
            this.stride = stride;
            this.inputRate = inputRate;
            this.divisor = divisor;
        }
    }
    public unsafe struct VkVertexInputAttributeDescription2EXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeVertexInputAttributeDescription2Ext;
        public void* pNext;
        public uint location;
        public uint binding;
        public VkFormat format;
        public uint offset;
        public VkVertexInputAttributeDescription2EXT(VkStructureType sType, void* pNext, uint location, uint binding, VkFormat format, uint offset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.location = location;
            this.binding = binding;
            this.format = format;
            this.offset = offset;
        }
    }
    public unsafe struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceColorWriteEnableFeaturesExt;
        public void* pNext;
        public int colorWriteEnable;
        public VkPhysicalDeviceColorWriteEnableFeaturesEXT(VkStructureType sType, void* pNext, int colorWriteEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.colorWriteEnable = colorWriteEnable;
        }
    }
    public unsafe struct VkPipelineColorWriteCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineColorWriteCreateInfoExt;
        public void* pNext;
        public uint attachmentCount;
        public int* pColorWriteEnables;
        public VkPipelineColorWriteCreateInfoEXT(VkStructureType sType, void* pNext, uint attachmentCount, int* pColorWriteEnables)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.attachmentCount = attachmentCount;
            this.pColorWriteEnables = pColorWriteEnables;
        }
    }
    public unsafe struct VkMemoryBarrier2
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryBarrier2;
        public void* pNext;
        public VkPipelineStageFlagBits2 srcStageMask;
        public VkAccessFlagBits2 srcAccessMask;
        public VkPipelineStageFlagBits2 dstStageMask;
        public VkAccessFlagBits2 dstAccessMask;
        public VkMemoryBarrier2(VkStructureType sType, void* pNext, VkPipelineStageFlagBits2 srcStageMask, VkAccessFlagBits2 srcAccessMask, VkPipelineStageFlagBits2 dstStageMask, VkAccessFlagBits2 dstAccessMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcStageMask = srcStageMask;
            this.srcAccessMask = srcAccessMask;
            this.dstStageMask = dstStageMask;
            this.dstAccessMask = dstAccessMask;
        }
    }
    public unsafe struct VkMemoryBarrier2KHR
    {
        public VkMemoryBarrier2KHR()
        {
        }
    }
    public unsafe struct VkImageMemoryBarrier2
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageMemoryBarrier2;
        public void* pNext;
        public VkPipelineStageFlagBits2 srcStageMask;
        public VkAccessFlagBits2 srcAccessMask;
        public VkPipelineStageFlagBits2 dstStageMask;
        public VkAccessFlagBits2 dstAccessMask;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkImage image;
        public VkImageSubresourceRange subresourceRange;
        public VkImageMemoryBarrier2(VkStructureType sType, void* pNext, VkPipelineStageFlagBits2 srcStageMask, VkAccessFlagBits2 srcAccessMask, VkPipelineStageFlagBits2 dstStageMask, VkAccessFlagBits2 dstAccessMask, VkImageLayout oldLayout, VkImageLayout newLayout, uint srcQueueFamilyIndex, uint dstQueueFamilyIndex, VkImage image, VkImageSubresourceRange subresourceRange)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcStageMask = srcStageMask;
            this.srcAccessMask = srcAccessMask;
            this.dstStageMask = dstStageMask;
            this.dstAccessMask = dstAccessMask;
            this.oldLayout = oldLayout;
            this.newLayout = newLayout;
            this.srcQueueFamilyIndex = srcQueueFamilyIndex;
            this.dstQueueFamilyIndex = dstQueueFamilyIndex;
            this.image = image;
            this.subresourceRange = subresourceRange;
        }
    }
    public unsafe struct VkImageMemoryBarrier2KHR
    {
        public VkImageMemoryBarrier2KHR()
        {
        }
    }
    public unsafe struct VkBufferMemoryBarrier2
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferMemoryBarrier2;
        public void* pNext;
        public VkPipelineStageFlagBits2 srcStageMask;
        public VkAccessFlagBits2 srcAccessMask;
        public VkPipelineStageFlagBits2 dstStageMask;
        public VkAccessFlagBits2 dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public VkBufferMemoryBarrier2(VkStructureType sType, void* pNext, VkPipelineStageFlagBits2 srcStageMask, VkAccessFlagBits2 srcAccessMask, VkPipelineStageFlagBits2 dstStageMask, VkAccessFlagBits2 dstAccessMask, uint srcQueueFamilyIndex, uint dstQueueFamilyIndex, VkBuffer buffer, ulong offset, ulong size)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.srcStageMask = srcStageMask;
            this.srcAccessMask = srcAccessMask;
            this.dstStageMask = dstStageMask;
            this.dstAccessMask = dstAccessMask;
            this.srcQueueFamilyIndex = srcQueueFamilyIndex;
            this.dstQueueFamilyIndex = dstQueueFamilyIndex;
            this.buffer = buffer;
            this.offset = offset;
            this.size = size;
        }
    }
    public unsafe struct VkBufferMemoryBarrier2KHR
    {
        public VkBufferMemoryBarrier2KHR()
        {
        }
    }
    public unsafe struct VkDependencyInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeDependencyInfo;
        public void* pNext;
        public VkDependencyFlagBits dependencyFlags;
        public uint memoryBarrierCount;
        public VkMemoryBarrier2* pMemoryBarriers;
        public uint bufferMemoryBarrierCount;
        public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
        public uint imageMemoryBarrierCount;
        public VkImageMemoryBarrier2* pImageMemoryBarriers;
        public VkDependencyInfo(VkStructureType sType, void* pNext, VkDependencyFlagBits dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier2* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier2* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier2* pImageMemoryBarriers)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dependencyFlags = dependencyFlags;
            this.memoryBarrierCount = memoryBarrierCount;
            this.pMemoryBarriers = pMemoryBarriers;
            this.bufferMemoryBarrierCount = bufferMemoryBarrierCount;
            this.pBufferMemoryBarriers = pBufferMemoryBarriers;
            this.imageMemoryBarrierCount = imageMemoryBarrierCount;
            this.pImageMemoryBarriers = pImageMemoryBarriers;
        }
    }
    public unsafe struct VkDependencyInfoKHR
    {
        public VkDependencyInfoKHR()
        {
        }
    }
    public unsafe struct VkSemaphoreSubmitInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeSemaphoreSubmitInfo;
        public void* pNext;
        public VkSemaphore semaphore;
        public ulong value;
        public VkPipelineStageFlagBits2 stageMask;
        public uint deviceIndex;
        public VkSemaphoreSubmitInfo(VkStructureType sType, void* pNext, VkSemaphore semaphore, ulong value, VkPipelineStageFlagBits2 stageMask, uint deviceIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.value = value;
            this.stageMask = stageMask;
            this.deviceIndex = deviceIndex;
        }
    }
    public unsafe struct VkSemaphoreSubmitInfoKHR
    {
        public VkSemaphoreSubmitInfoKHR()
        {
        }
    }
    public unsafe struct VkCommandBufferSubmitInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeCommandBufferSubmitInfo;
        public void* pNext;
        public VkCommandBuffer commandBuffer;
        public uint deviceMask;
        public VkCommandBufferSubmitInfo(VkStructureType sType, void* pNext, VkCommandBuffer commandBuffer, uint deviceMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.commandBuffer = commandBuffer;
            this.deviceMask = deviceMask;
        }
    }
    public unsafe struct VkCommandBufferSubmitInfoKHR
    {
        public VkCommandBufferSubmitInfoKHR()
        {
        }
    }
    public unsafe struct VkSubmitInfo2
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubmitInfo2;
        public void* pNext;
        public VkSubmitFlagBits flags;
        public uint waitSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
        public uint commandBufferInfoCount;
        public VkCommandBufferSubmitInfo* pCommandBufferInfos;
        public uint signalSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
        public VkSubmitInfo2(VkStructureType sType, void* pNext, VkSubmitFlagBits flags, uint waitSemaphoreInfoCount, VkSemaphoreSubmitInfo* pWaitSemaphoreInfos, uint commandBufferInfoCount, VkCommandBufferSubmitInfo* pCommandBufferInfos, uint signalSemaphoreInfoCount, VkSemaphoreSubmitInfo* pSignalSemaphoreInfos)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.waitSemaphoreInfoCount = waitSemaphoreInfoCount;
            this.pWaitSemaphoreInfos = pWaitSemaphoreInfos;
            this.commandBufferInfoCount = commandBufferInfoCount;
            this.pCommandBufferInfos = pCommandBufferInfos;
            this.signalSemaphoreInfoCount = signalSemaphoreInfoCount;
            this.pSignalSemaphoreInfos = pSignalSemaphoreInfos;
        }
    }
    public unsafe struct VkSubmitInfo2KHR
    {
        public VkSubmitInfo2KHR()
        {
        }
    }
    public unsafe struct VkQueueFamilyCheckpointProperties2NV
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueueFamilyCheckpointProperties2Nv;
        public void* pNext;
        public VkPipelineStageFlagBits2 checkpointExecutionStageMask;
        public VkQueueFamilyCheckpointProperties2NV(VkStructureType sType, void* pNext, VkPipelineStageFlagBits2 checkpointExecutionStageMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.checkpointExecutionStageMask = checkpointExecutionStageMask;
        }
    }
    public unsafe struct VkCheckpointData2NV
    {
        public VkStructureType sType = VkStructureType.StructureTypeCheckpointData2Nv;
        public void* pNext;
        public VkPipelineStageFlagBits2 stage;
        public void* pCheckpointMarker;
        public VkCheckpointData2NV(VkStructureType sType, void* pNext, VkPipelineStageFlagBits2 stage, void* pCheckpointMarker)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stage = stage;
            this.pCheckpointMarker = pCheckpointMarker;
        }
    }
    public unsafe struct VkPhysicalDeviceSynchronization2Features
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSynchronization2Features;
        public void* pNext;
        public int synchronization2;
        public VkPhysicalDeviceSynchronization2Features(VkStructureType sType, void* pNext, int synchronization2)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.synchronization2 = synchronization2;
        }
    }
    public unsafe struct VkPhysicalDeviceSynchronization2FeaturesKHR
    {
        public VkPhysicalDeviceSynchronization2FeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceHostImageCopyFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceHostImageCopyFeaturesExt;
        public void* pNext;
        public int hostImageCopy;
        public VkPhysicalDeviceHostImageCopyFeaturesEXT(VkStructureType sType, void* pNext, int hostImageCopy)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.hostImageCopy = hostImageCopy;
        }
    }
    public unsafe struct VkPhysicalDeviceHostImageCopyPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceHostImageCopyPropertiesExt;
        public void* pNext;
        public uint copySrcLayoutCount;
        public VkImageLayout* pCopySrcLayouts;
        public uint copyDstLayoutCount;
        public VkImageLayout* pCopyDstLayouts;
        public fixed byte optimalTilingLayoutUUID[16];
        public int identicalMemoryTypeRequirements;
        public VkPhysicalDeviceHostImageCopyPropertiesEXT(){ }
    }
    public unsafe struct VkMemoryToImageCopyEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryToImageCopyExt;
        public void* pNext;
        public void* pHostPointer;
        public uint memoryRowLength;
        public uint memoryImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        public VkMemoryToImageCopyEXT(VkStructureType sType, void* pNext, void* pHostPointer, uint memoryRowLength, uint memoryImageHeight, VkImageSubresourceLayers imageSubresource, VkOffset3D imageOffset, VkExtent3D imageExtent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pHostPointer = pHostPointer;
            this.memoryRowLength = memoryRowLength;
            this.memoryImageHeight = memoryImageHeight;
            this.imageSubresource = imageSubresource;
            this.imageOffset = imageOffset;
            this.imageExtent = imageExtent;
        }
    }
    public unsafe struct VkImageToMemoryCopyEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageToMemoryCopyExt;
        public void* pNext;
        public void* pHostPointer;
        public uint memoryRowLength;
        public uint memoryImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        public VkImageToMemoryCopyEXT(VkStructureType sType, void* pNext, void* pHostPointer, uint memoryRowLength, uint memoryImageHeight, VkImageSubresourceLayers imageSubresource, VkOffset3D imageOffset, VkExtent3D imageExtent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pHostPointer = pHostPointer;
            this.memoryRowLength = memoryRowLength;
            this.memoryImageHeight = memoryImageHeight;
            this.imageSubresource = imageSubresource;
            this.imageOffset = imageOffset;
            this.imageExtent = imageExtent;
        }
    }
    public unsafe struct VkCopyMemoryToImageInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyMemoryToImageInfoExt;
        public void* pNext;
        public VkHostImageCopyFlagBitsEXT flags;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkMemoryToImageCopyEXT* pRegions;
        public VkCopyMemoryToImageInfoEXT(VkStructureType sType, void* pNext, VkHostImageCopyFlagBitsEXT flags, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkMemoryToImageCopyEXT* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.dstImage = dstImage;
            this.dstImageLayout = dstImageLayout;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkCopyImageToMemoryInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyImageToMemoryInfoExt;
        public void* pNext;
        public VkHostImageCopyFlagBitsEXT flags;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public uint regionCount;
        public VkImageToMemoryCopyEXT* pRegions;
        public VkCopyImageToMemoryInfoEXT(VkStructureType sType, void* pNext, VkHostImageCopyFlagBitsEXT flags, VkImage srcImage, VkImageLayout srcImageLayout, uint regionCount, VkImageToMemoryCopyEXT* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.srcImage = srcImage;
            this.srcImageLayout = srcImageLayout;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkCopyImageToImageInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyImageToImageInfoExt;
        public void* pNext;
        public VkHostImageCopyFlagBitsEXT flags;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageCopy2* pRegions;
        public VkCopyImageToImageInfoEXT(VkStructureType sType, void* pNext, VkHostImageCopyFlagBitsEXT flags, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy2* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.srcImage = srcImage;
            this.srcImageLayout = srcImageLayout;
            this.dstImage = dstImage;
            this.dstImageLayout = dstImageLayout;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkHostImageLayoutTransitionInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeHostImageLayoutTransitionInfoExt;
        public void* pNext;
        public VkImage image;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public VkImageSubresourceRange subresourceRange;
        public VkHostImageLayoutTransitionInfoEXT(VkStructureType sType, void* pNext, VkImage image, VkImageLayout oldLayout, VkImageLayout newLayout, VkImageSubresourceRange subresourceRange)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image = image;
            this.oldLayout = oldLayout;
            this.newLayout = newLayout;
            this.subresourceRange = subresourceRange;
        }
    }
    public unsafe struct VkSubresourceHostMemcpySizeEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubresourceHostMemcpySizeExt;
        public void* pNext;
        public ulong size;
        public VkSubresourceHostMemcpySizeEXT(VkStructureType sType, void* pNext, ulong size)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.size = size;
        }
    }
    public unsafe struct VkHostImageCopyDevicePerformanceQueryEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeHostImageCopyDevicePerformanceQueryExt;
        public void* pNext;
        public int optimalDeviceAccess;
        public int identicalMemoryLayout;
        public VkHostImageCopyDevicePerformanceQueryEXT(VkStructureType sType, void* pNext, int optimalDeviceAccess, int identicalMemoryLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.optimalDeviceAccess = optimalDeviceAccess;
            this.identicalMemoryLayout = identicalMemoryLayout;
        }
    }
    public unsafe struct VkPhysicalDeviceVulkanSC10Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public int deviceNoDynamicHostAllocations;
        public int deviceDestroyFreesMemory;
        public int commandPoolMultipleCommandBuffersRecording;
        public int commandPoolResetCommandBuffer;
        public int commandBufferSimultaneousUse;
        public int secondaryCommandBufferNullOrImagelessFramebuffer;
        public int recycleDescriptorSetMemory;
        public int recyclePipelineMemory;
        public uint maxRenderPassSubpasses;
        public uint maxRenderPassDependencies;
        public uint maxSubpassInputAttachments;
        public uint maxSubpassPreserveAttachments;
        public uint maxFramebufferAttachments;
        public uint maxDescriptorSetLayoutBindings;
        public uint maxQueryFaultCount;
        public uint maxCallbackFaultCount;
        public uint maxCommandPoolCommandBuffers;
        public ulong maxCommandBufferSize;
        public VkPhysicalDeviceVulkanSC10Properties(VkStructureType sType, void* pNext, int deviceNoDynamicHostAllocations, int deviceDestroyFreesMemory, int commandPoolMultipleCommandBuffersRecording, int commandPoolResetCommandBuffer, int commandBufferSimultaneousUse, int secondaryCommandBufferNullOrImagelessFramebuffer, int recycleDescriptorSetMemory, int recyclePipelineMemory, uint maxRenderPassSubpasses, uint maxRenderPassDependencies, uint maxSubpassInputAttachments, uint maxSubpassPreserveAttachments, uint maxFramebufferAttachments, uint maxDescriptorSetLayoutBindings, uint maxQueryFaultCount, uint maxCallbackFaultCount, uint maxCommandPoolCommandBuffers, ulong maxCommandBufferSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceNoDynamicHostAllocations = deviceNoDynamicHostAllocations;
            this.deviceDestroyFreesMemory = deviceDestroyFreesMemory;
            this.commandPoolMultipleCommandBuffersRecording = commandPoolMultipleCommandBuffersRecording;
            this.commandPoolResetCommandBuffer = commandPoolResetCommandBuffer;
            this.commandBufferSimultaneousUse = commandBufferSimultaneousUse;
            this.secondaryCommandBufferNullOrImagelessFramebuffer = secondaryCommandBufferNullOrImagelessFramebuffer;
            this.recycleDescriptorSetMemory = recycleDescriptorSetMemory;
            this.recyclePipelineMemory = recyclePipelineMemory;
            this.maxRenderPassSubpasses = maxRenderPassSubpasses;
            this.maxRenderPassDependencies = maxRenderPassDependencies;
            this.maxSubpassInputAttachments = maxSubpassInputAttachments;
            this.maxSubpassPreserveAttachments = maxSubpassPreserveAttachments;
            this.maxFramebufferAttachments = maxFramebufferAttachments;
            this.maxDescriptorSetLayoutBindings = maxDescriptorSetLayoutBindings;
            this.maxQueryFaultCount = maxQueryFaultCount;
            this.maxCallbackFaultCount = maxCallbackFaultCount;
            this.maxCommandPoolCommandBuffers = maxCommandPoolCommandBuffers;
            this.maxCommandBufferSize = maxCommandBufferSize;
        }
    }
    public unsafe struct VkPipelinePoolSize
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong poolEntrySize;
        public uint poolEntryCount;
        public VkPipelinePoolSize(VkStructureType sType, void* pNext, ulong poolEntrySize, uint poolEntryCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.poolEntrySize = poolEntrySize;
            this.poolEntryCount = poolEntryCount;
        }
    }
    public unsafe struct VkDeviceObjectReservationCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pipelineCacheCreateInfoCount;
        public VkPipelineCacheCreateInfo* pPipelineCacheCreateInfos;
        public uint pipelinePoolSizeCount;
        public VkPipelinePoolSize* pPipelinePoolSizes;
        public uint semaphoreRequestCount;
        public uint commandBufferRequestCount;
        public uint fenceRequestCount;
        public uint deviceMemoryRequestCount;
        public uint bufferRequestCount;
        public uint imageRequestCount;
        public uint eventRequestCount;
        public uint queryPoolRequestCount;
        public uint bufferViewRequestCount;
        public uint imageViewRequestCount;
        public uint layeredImageViewRequestCount;
        public uint pipelineCacheRequestCount;
        public uint pipelineLayoutRequestCount;
        public uint renderPassRequestCount;
        public uint graphicsPipelineRequestCount;
        public uint computePipelineRequestCount;
        public uint descriptorSetLayoutRequestCount;
        public uint samplerRequestCount;
        public uint descriptorPoolRequestCount;
        public uint descriptorSetRequestCount;
        public uint framebufferRequestCount;
        public uint commandPoolRequestCount;
        public uint samplerYcbcrConversionRequestCount;
        public uint surfaceRequestCount;
        public uint swapchainRequestCount;
        public uint displayModeRequestCount;
        public uint subpassDescriptionRequestCount;
        public uint attachmentDescriptionRequestCount;
        public uint descriptorSetLayoutBindingRequestCount;
        public uint descriptorSetLayoutBindingLimit;
        public uint maxImageViewMipLevels;
        public uint maxImageViewArrayLayers;
        public uint maxLayeredImageViewMipLevels;
        public uint maxOcclusionQueriesPerPool;
        public uint maxPipelineStatisticsQueriesPerPool;
        public uint maxTimestampQueriesPerPool;
        public uint maxImmutableSamplersPerDescriptorSetLayout;
        public VkDeviceObjectReservationCreateInfo(VkStructureType sType, void* pNext, uint pipelineCacheCreateInfoCount, VkPipelineCacheCreateInfo* pPipelineCacheCreateInfos, uint pipelinePoolSizeCount, VkPipelinePoolSize* pPipelinePoolSizes, uint semaphoreRequestCount, uint commandBufferRequestCount, uint fenceRequestCount, uint deviceMemoryRequestCount, uint bufferRequestCount, uint imageRequestCount, uint eventRequestCount, uint queryPoolRequestCount, uint bufferViewRequestCount, uint imageViewRequestCount, uint layeredImageViewRequestCount, uint pipelineCacheRequestCount, uint pipelineLayoutRequestCount, uint renderPassRequestCount, uint graphicsPipelineRequestCount, uint computePipelineRequestCount, uint descriptorSetLayoutRequestCount, uint samplerRequestCount, uint descriptorPoolRequestCount, uint descriptorSetRequestCount, uint framebufferRequestCount, uint commandPoolRequestCount, uint samplerYcbcrConversionRequestCount, uint surfaceRequestCount, uint swapchainRequestCount, uint displayModeRequestCount, uint subpassDescriptionRequestCount, uint attachmentDescriptionRequestCount, uint descriptorSetLayoutBindingRequestCount, uint descriptorSetLayoutBindingLimit, uint maxImageViewMipLevels, uint maxImageViewArrayLayers, uint maxLayeredImageViewMipLevels, uint maxOcclusionQueriesPerPool, uint maxPipelineStatisticsQueriesPerPool, uint maxTimestampQueriesPerPool, uint maxImmutableSamplersPerDescriptorSetLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineCacheCreateInfoCount = pipelineCacheCreateInfoCount;
            this.pPipelineCacheCreateInfos = pPipelineCacheCreateInfos;
            this.pipelinePoolSizeCount = pipelinePoolSizeCount;
            this.pPipelinePoolSizes = pPipelinePoolSizes;
            this.semaphoreRequestCount = semaphoreRequestCount;
            this.commandBufferRequestCount = commandBufferRequestCount;
            this.fenceRequestCount = fenceRequestCount;
            this.deviceMemoryRequestCount = deviceMemoryRequestCount;
            this.bufferRequestCount = bufferRequestCount;
            this.imageRequestCount = imageRequestCount;
            this.eventRequestCount = eventRequestCount;
            this.queryPoolRequestCount = queryPoolRequestCount;
            this.bufferViewRequestCount = bufferViewRequestCount;
            this.imageViewRequestCount = imageViewRequestCount;
            this.layeredImageViewRequestCount = layeredImageViewRequestCount;
            this.pipelineCacheRequestCount = pipelineCacheRequestCount;
            this.pipelineLayoutRequestCount = pipelineLayoutRequestCount;
            this.renderPassRequestCount = renderPassRequestCount;
            this.graphicsPipelineRequestCount = graphicsPipelineRequestCount;
            this.computePipelineRequestCount = computePipelineRequestCount;
            this.descriptorSetLayoutRequestCount = descriptorSetLayoutRequestCount;
            this.samplerRequestCount = samplerRequestCount;
            this.descriptorPoolRequestCount = descriptorPoolRequestCount;
            this.descriptorSetRequestCount = descriptorSetRequestCount;
            this.framebufferRequestCount = framebufferRequestCount;
            this.commandPoolRequestCount = commandPoolRequestCount;
            this.samplerYcbcrConversionRequestCount = samplerYcbcrConversionRequestCount;
            this.surfaceRequestCount = surfaceRequestCount;
            this.swapchainRequestCount = swapchainRequestCount;
            this.displayModeRequestCount = displayModeRequestCount;
            this.subpassDescriptionRequestCount = subpassDescriptionRequestCount;
            this.attachmentDescriptionRequestCount = attachmentDescriptionRequestCount;
            this.descriptorSetLayoutBindingRequestCount = descriptorSetLayoutBindingRequestCount;
            this.descriptorSetLayoutBindingLimit = descriptorSetLayoutBindingLimit;
            this.maxImageViewMipLevels = maxImageViewMipLevels;
            this.maxImageViewArrayLayers = maxImageViewArrayLayers;
            this.maxLayeredImageViewMipLevels = maxLayeredImageViewMipLevels;
            this.maxOcclusionQueriesPerPool = maxOcclusionQueriesPerPool;
            this.maxPipelineStatisticsQueriesPerPool = maxPipelineStatisticsQueriesPerPool;
            this.maxTimestampQueriesPerPool = maxTimestampQueriesPerPool;
            this.maxImmutableSamplersPerDescriptorSetLayout = maxImmutableSamplersPerDescriptorSetLayout;
        }
    }
    public unsafe struct VkCommandPoolMemoryReservationCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong commandPoolReservedSize;
        public uint commandPoolMaxCommandBuffers;
        public VkCommandPoolMemoryReservationCreateInfo(VkStructureType sType, void* pNext, ulong commandPoolReservedSize, uint commandPoolMaxCommandBuffers)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.commandPoolReservedSize = commandPoolReservedSize;
            this.commandPoolMaxCommandBuffers = commandPoolMaxCommandBuffers;
        }
    }
    public unsafe struct VkCommandPoolMemoryConsumption
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong commandPoolAllocated;
        public ulong commandPoolReservedSize;
        public ulong commandBufferAllocated;
        public VkCommandPoolMemoryConsumption(VkStructureType sType, void* pNext, ulong commandPoolAllocated, ulong commandPoolReservedSize, ulong commandBufferAllocated)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.commandPoolAllocated = commandPoolAllocated;
            this.commandPoolReservedSize = commandPoolReservedSize;
            this.commandBufferAllocated = commandBufferAllocated;
        }
    }
    public unsafe struct VkPhysicalDeviceVulkanSC10Features
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderAtomicInstructions;
        public VkPhysicalDeviceVulkanSC10Features(VkStructureType sType, void* pNext, int shaderAtomicInstructions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderAtomicInstructions = shaderAtomicInstructions;
        }
    }
    public unsafe struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePrimitivesGeneratedQueryFeaturesExt;
        public void* pNext;
        public int primitivesGeneratedQuery;
        public int primitivesGeneratedQueryWithRasterizerDiscard;
        public int primitivesGeneratedQueryWithNonZeroStreams;
        public VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT(VkStructureType sType, void* pNext, int primitivesGeneratedQuery, int primitivesGeneratedQueryWithRasterizerDiscard, int primitivesGeneratedQueryWithNonZeroStreams)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.primitivesGeneratedQuery = primitivesGeneratedQuery;
            this.primitivesGeneratedQueryWithRasterizerDiscard = primitivesGeneratedQueryWithRasterizerDiscard;
            this.primitivesGeneratedQueryWithNonZeroStreams = primitivesGeneratedQueryWithNonZeroStreams;
        }
    }
    public unsafe struct VkPhysicalDeviceLegacyDitheringFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLegacyDitheringFeaturesExt;
        public void* pNext;
        public int legacyDithering;
        public VkPhysicalDeviceLegacyDitheringFeaturesEXT(VkStructureType sType, void* pNext, int legacyDithering)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.legacyDithering = legacyDithering;
        }
    }
    public unsafe struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMultisampledRenderToSingleSampledFeaturesExt;
        public void* pNext;
        public int multisampledRenderToSingleSampled;
        public VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT(VkStructureType sType, void* pNext, int multisampledRenderToSingleSampled)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.multisampledRenderToSingleSampled = multisampledRenderToSingleSampled;
        }
    }
    public unsafe struct VkSubpassResolvePerformanceQueryEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubpassResolvePerformanceQueryExt;
        public void* pNext;
        public int optimal;
        public VkSubpassResolvePerformanceQueryEXT(VkStructureType sType, void* pNext, int optimal)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.optimal = optimal;
        }
    }
    public unsafe struct VkMultisampledRenderToSingleSampledInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMultisampledRenderToSingleSampledInfoExt;
        public void* pNext;
        public int multisampledRenderToSingleSampledEnable;
        public VkSampleCountFlagBits rasterizationSamples;
        public VkMultisampledRenderToSingleSampledInfoEXT(VkStructureType sType, void* pNext, int multisampledRenderToSingleSampledEnable, VkSampleCountFlagBits rasterizationSamples)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.multisampledRenderToSingleSampledEnable = multisampledRenderToSingleSampledEnable;
            this.rasterizationSamples = rasterizationSamples;
        }
    }
    public unsafe struct VkPhysicalDevicePipelineProtectedAccessFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePipelineProtectedAccessFeaturesExt;
        public void* pNext;
        public int pipelineProtectedAccess;
        public VkPhysicalDevicePipelineProtectedAccessFeaturesEXT(VkStructureType sType, void* pNext, int pipelineProtectedAccess)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineProtectedAccess = pipelineProtectedAccess;
        }
    }
    public unsafe struct VkQueueFamilyVideoPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueueFamilyVideoPropertiesKhr;
        public void* pNext;
        public VkVideoCodecOperationFlagBitsKHR videoCodecOperations;
        public VkQueueFamilyVideoPropertiesKHR(VkStructureType sType, void* pNext, VkVideoCodecOperationFlagBitsKHR videoCodecOperations)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.videoCodecOperations = videoCodecOperations;
        }
    }
    public unsafe struct VkQueueFamilyQueryResultStatusPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueueFamilyQueryResultStatusPropertiesKhr;
        public void* pNext;
        public int queryResultStatusSupport;
        public VkQueueFamilyQueryResultStatusPropertiesKHR(VkStructureType sType, void* pNext, int queryResultStatusSupport)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.queryResultStatusSupport = queryResultStatusSupport;
        }
    }
    public unsafe struct VkVideoProfileListInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoProfileListInfoKhr;
        public void* pNext;
        public uint profileCount;
        public VkVideoProfileInfoKHR* pProfiles;
        public VkVideoProfileListInfoKHR(VkStructureType sType, void* pNext, uint profileCount, VkVideoProfileInfoKHR* pProfiles)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.profileCount = profileCount;
            this.pProfiles = pProfiles;
        }
    }
    public unsafe struct VkPhysicalDeviceVideoFormatInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVideoFormatInfoKhr;
        public void* pNext;
        public VkImageUsageFlagBits imageUsage;
        public VkPhysicalDeviceVideoFormatInfoKHR(VkStructureType sType, void* pNext, VkImageUsageFlagBits imageUsage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageUsage = imageUsage;
        }
    }
    public unsafe struct VkVideoFormatPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoFormatPropertiesKhr;
        public void* pNext;
        public VkFormat format;
        public VkComponentMapping componentMapping;
        public VkImageCreateFlagBits imageCreateFlags;
        public VkImageType imageType;
        public VkImageTiling imageTiling;
        public VkImageUsageFlagBits imageUsageFlags;
        public VkVideoFormatPropertiesKHR(VkStructureType sType, void* pNext, VkFormat format, VkComponentMapping componentMapping, VkImageCreateFlagBits imageCreateFlags, VkImageType imageType, VkImageTiling imageTiling, VkImageUsageFlagBits imageUsageFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.format = format;
            this.componentMapping = componentMapping;
            this.imageCreateFlags = imageCreateFlags;
            this.imageType = imageType;
            this.imageTiling = imageTiling;
            this.imageUsageFlags = imageUsageFlags;
        }
    }
    public unsafe struct VkVideoProfileInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoProfileInfoKhr;
        public void* pNext;
        public VkVideoCodecOperationFlagBitsKHR videoCodecOperation;
        public VkVideoChromaSubsamplingFlagBitsKHR chromaSubsampling;
        public VkVideoComponentBitDepthFlagBitsKHR lumaBitDepth;
        public VkVideoComponentBitDepthFlagBitsKHR chromaBitDepth;
        public VkVideoProfileInfoKHR(VkStructureType sType, void* pNext, VkVideoCodecOperationFlagBitsKHR videoCodecOperation, VkVideoChromaSubsamplingFlagBitsKHR chromaSubsampling, VkVideoComponentBitDepthFlagBitsKHR lumaBitDepth, VkVideoComponentBitDepthFlagBitsKHR chromaBitDepth)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.videoCodecOperation = videoCodecOperation;
            this.chromaSubsampling = chromaSubsampling;
            this.lumaBitDepth = lumaBitDepth;
            this.chromaBitDepth = chromaBitDepth;
        }
    }
    public unsafe struct VkVideoCapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoCapabilitiesKhr;
        public void* pNext;
        public VkVideoCapabilityFlagBitsKHR flags;
        public ulong minBitstreamBufferOffsetAlignment;
        public ulong minBitstreamBufferSizeAlignment;
        public VkExtent2D pictureAccessGranularity;
        public VkExtent2D minCodedExtent;
        public VkExtent2D maxCodedExtent;
        public uint maxDpbSlots;
        public uint maxActiveReferencePictures;
        public VkExtensionProperties stdHeaderVersion;
        public VkVideoCapabilitiesKHR(VkStructureType sType, void* pNext, VkVideoCapabilityFlagBitsKHR flags, ulong minBitstreamBufferOffsetAlignment, ulong minBitstreamBufferSizeAlignment, VkExtent2D pictureAccessGranularity, VkExtent2D minCodedExtent, VkExtent2D maxCodedExtent, uint maxDpbSlots, uint maxActiveReferencePictures, VkExtensionProperties stdHeaderVersion)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.minBitstreamBufferOffsetAlignment = minBitstreamBufferOffsetAlignment;
            this.minBitstreamBufferSizeAlignment = minBitstreamBufferSizeAlignment;
            this.pictureAccessGranularity = pictureAccessGranularity;
            this.minCodedExtent = minCodedExtent;
            this.maxCodedExtent = maxCodedExtent;
            this.maxDpbSlots = maxDpbSlots;
            this.maxActiveReferencePictures = maxActiveReferencePictures;
            this.stdHeaderVersion = stdHeaderVersion;
        }
    }
    public unsafe struct VkVideoSessionMemoryRequirementsKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoSessionMemoryRequirementsKhr;
        public void* pNext;
        public uint memoryBindIndex;
        public VkMemoryRequirements memoryRequirements;
        public VkVideoSessionMemoryRequirementsKHR(VkStructureType sType, void* pNext, uint memoryBindIndex, VkMemoryRequirements memoryRequirements)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryBindIndex = memoryBindIndex;
            this.memoryRequirements = memoryRequirements;
        }
    }
    public unsafe struct VkBindVideoSessionMemoryInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindVideoSessionMemoryInfoKhr;
        public void* pNext;
        public uint memoryBindIndex;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public ulong memorySize;
        public VkBindVideoSessionMemoryInfoKHR(VkStructureType sType, void* pNext, uint memoryBindIndex, VkDeviceMemory memory, ulong memoryOffset, ulong memorySize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryBindIndex = memoryBindIndex;
            this.memory = memory;
            this.memoryOffset = memoryOffset;
            this.memorySize = memorySize;
        }
    }
    public unsafe struct VkVideoPictureResourceInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoPictureResourceInfoKhr;
        public void* pNext;
        public VkOffset2D codedOffset;
        public VkExtent2D codedExtent;
        public uint baseArrayLayer;
        public VkImageView imageViewBinding;
        public VkVideoPictureResourceInfoKHR(VkStructureType sType, void* pNext, VkOffset2D codedOffset, VkExtent2D codedExtent, uint baseArrayLayer, VkImageView imageViewBinding)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.codedOffset = codedOffset;
            this.codedExtent = codedExtent;
            this.baseArrayLayer = baseArrayLayer;
            this.imageViewBinding = imageViewBinding;
        }
    }
    public unsafe struct VkVideoReferenceSlotInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoReferenceSlotInfoKhr;
        public void* pNext;
        public int slotIndex;
        public VkVideoPictureResourceInfoKHR* pPictureResource;
        public VkVideoReferenceSlotInfoKHR(VkStructureType sType, void* pNext, int slotIndex, VkVideoPictureResourceInfoKHR* pPictureResource)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.slotIndex = slotIndex;
            this.pPictureResource = pPictureResource;
        }
    }
    public unsafe struct VkVideoDecodeCapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeCapabilitiesKhr;
        public void* pNext;
        public VkVideoDecodeCapabilityFlagBitsKHR flags;
        public VkVideoDecodeCapabilitiesKHR(VkStructureType sType, void* pNext, VkVideoDecodeCapabilityFlagBitsKHR flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkVideoDecodeUsageInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeUsageInfoKhr;
        public void* pNext;
        public VkVideoDecodeUsageFlagBitsKHR videoUsageHints;
        public VkVideoDecodeUsageInfoKHR(VkStructureType sType, void* pNext, VkVideoDecodeUsageFlagBitsKHR videoUsageHints)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.videoUsageHints = videoUsageHints;
        }
    }
    public unsafe struct VkVideoDecodeInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeInfoKhr;
        public void* pNext;
        public VkVideoDecodeFlagsKHR flags;
        public VkBuffer srcBuffer;
        public ulong srcBufferOffset;
        public ulong srcBufferRange;
        public VkVideoPictureResourceInfoKHR dstPictureResource;
        public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        public VkVideoDecodeInfoKHR(VkStructureType sType, void* pNext, VkVideoDecodeFlagsKHR flags, VkBuffer srcBuffer, ulong srcBufferOffset, ulong srcBufferRange, VkVideoPictureResourceInfoKHR dstPictureResource, VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot, uint referenceSlotCount, VkVideoReferenceSlotInfoKHR* pReferenceSlots)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.srcBuffer = srcBuffer;
            this.srcBufferOffset = srcBufferOffset;
            this.srcBufferRange = srcBufferRange;
            this.dstPictureResource = dstPictureResource;
            this.pSetupReferenceSlot = pSetupReferenceSlot;
            this.referenceSlotCount = referenceSlotCount;
            this.pReferenceSlots = pReferenceSlots;
        }
    }
    public unsafe struct VkPhysicalDeviceVideoMaintenance1FeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVideoMaintenance1FeaturesKhr;
        public void* pNext;
        public int videoMaintenance1;
        public VkPhysicalDeviceVideoMaintenance1FeaturesKHR(VkStructureType sType, void* pNext, int videoMaintenance1)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.videoMaintenance1 = videoMaintenance1;
        }
    }
    public unsafe struct VkVideoInlineQueryInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoInlineQueryInfoKhr;
        public void* pNext;
        public VkQueryPool queryPool;
        public uint firstQuery;
        public uint queryCount;
        public VkVideoInlineQueryInfoKHR(VkStructureType sType, void* pNext, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.queryPool = queryPool;
            this.firstQuery = firstQuery;
            this.queryCount = queryCount;
        }
    }
    public unsafe struct VkVideoDecodeH264ProfileInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH264ProfileInfoKhr;
        public void* pNext;
        public StdVideoH264ProfileIdc stdProfileIdc;
        public VkVideoDecodeH264PictureLayoutFlagBitsKHR pictureLayout;
        public VkVideoDecodeH264ProfileInfoKHR(VkStructureType sType, void* pNext, StdVideoH264ProfileIdc stdProfileIdc, VkVideoDecodeH264PictureLayoutFlagBitsKHR pictureLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stdProfileIdc = stdProfileIdc;
            this.pictureLayout = pictureLayout;
        }
    }
    public unsafe struct VkVideoDecodeH264CapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH264CapabilitiesKhr;
        public void* pNext;
        public StdVideoH264LevelIdc maxLevelIdc;
        public VkOffset2D fieldOffsetGranularity;
        public VkVideoDecodeH264CapabilitiesKHR(VkStructureType sType, void* pNext, StdVideoH264LevelIdc maxLevelIdc, VkOffset2D fieldOffsetGranularity)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxLevelIdc = maxLevelIdc;
            this.fieldOffsetGranularity = fieldOffsetGranularity;
        }
    }
    public unsafe struct VkVideoDecodeH264SessionParametersAddInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH264SessionParametersAddInfoKhr;
        public void* pNext;
        public uint stdSPSCount;
        public StdVideoH264SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH264PictureParameterSet* pStdPPSs;
        public VkVideoDecodeH264SessionParametersAddInfoKHR(VkStructureType sType, void* pNext, uint stdSPSCount, StdVideoH264SequenceParameterSet* pStdSPSs, uint stdPPSCount, StdVideoH264PictureParameterSet* pStdPPSs)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stdSPSCount = stdSPSCount;
            this.pStdSPSs = pStdSPSs;
            this.stdPPSCount = stdPPSCount;
            this.pStdPPSs = pStdPPSs;
        }
    }
    public unsafe struct VkVideoDecodeH264SessionParametersCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH264SessionParametersCreateInfoKhr;
        public void* pNext;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
        public VkVideoDecodeH264SessionParametersCreateInfoKHR(VkStructureType sType, void* pNext, uint maxStdSPSCount, uint maxStdPPSCount, VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxStdSPSCount = maxStdSPSCount;
            this.maxStdPPSCount = maxStdPPSCount;
            this.pParametersAddInfo = pParametersAddInfo;
        }
    }
    public unsafe struct VkVideoDecodeH264PictureInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH264PictureInfoKhr;
        public void* pNext;
        public StdVideoDecodeH264PictureInfo* pStdPictureInfo;
        public uint sliceCount;
        public uint* pSliceOffsets;
        public VkVideoDecodeH264PictureInfoKHR(VkStructureType sType, void* pNext, StdVideoDecodeH264PictureInfo* pStdPictureInfo, uint sliceCount, uint* pSliceOffsets)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pStdPictureInfo = pStdPictureInfo;
            this.sliceCount = sliceCount;
            this.pSliceOffsets = pSliceOffsets;
        }
    }
    public unsafe struct VkVideoDecodeH264DpbSlotInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH264DpbSlotInfoKhr;
        public void* pNext;
        public StdVideoDecodeH264ReferenceInfo* pStdReferenceInfo;
        public VkVideoDecodeH264DpbSlotInfoKHR(VkStructureType sType, void* pNext, StdVideoDecodeH264ReferenceInfo* pStdReferenceInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pStdReferenceInfo = pStdReferenceInfo;
        }
    }
    public unsafe struct VkVideoDecodeH265ProfileInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH265ProfileInfoKhr;
        public void* pNext;
        public StdVideoH265ProfileIdc stdProfileIdc;
        public VkVideoDecodeH265ProfileInfoKHR(VkStructureType sType, void* pNext, StdVideoH265ProfileIdc stdProfileIdc)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stdProfileIdc = stdProfileIdc;
        }
    }
    public unsafe struct VkVideoDecodeH265CapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH265CapabilitiesKhr;
        public void* pNext;
        public StdVideoH265LevelIdc maxLevelIdc;
        public VkVideoDecodeH265CapabilitiesKHR(VkStructureType sType, void* pNext, StdVideoH265LevelIdc maxLevelIdc)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxLevelIdc = maxLevelIdc;
        }
    }
    public unsafe struct VkVideoDecodeH265SessionParametersAddInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH265SessionParametersAddInfoKhr;
        public void* pNext;
        public uint stdVPSCount;
        public StdVideoH265VideoParameterSet* pStdVPSs;
        public uint stdSPSCount;
        public StdVideoH265SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH265PictureParameterSet* pStdPPSs;
        public VkVideoDecodeH265SessionParametersAddInfoKHR(VkStructureType sType, void* pNext, uint stdVPSCount, StdVideoH265VideoParameterSet* pStdVPSs, uint stdSPSCount, StdVideoH265SequenceParameterSet* pStdSPSs, uint stdPPSCount, StdVideoH265PictureParameterSet* pStdPPSs)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stdVPSCount = stdVPSCount;
            this.pStdVPSs = pStdVPSs;
            this.stdSPSCount = stdSPSCount;
            this.pStdSPSs = pStdSPSs;
            this.stdPPSCount = stdPPSCount;
            this.pStdPPSs = pStdPPSs;
        }
    }
    public unsafe struct VkVideoDecodeH265SessionParametersCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH265SessionParametersCreateInfoKhr;
        public void* pNext;
        public uint maxStdVPSCount;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoDecodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
        public VkVideoDecodeH265SessionParametersCreateInfoKHR(VkStructureType sType, void* pNext, uint maxStdVPSCount, uint maxStdSPSCount, uint maxStdPPSCount, VkVideoDecodeH265SessionParametersAddInfoKHR* pParametersAddInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxStdVPSCount = maxStdVPSCount;
            this.maxStdSPSCount = maxStdSPSCount;
            this.maxStdPPSCount = maxStdPPSCount;
            this.pParametersAddInfo = pParametersAddInfo;
        }
    }
    public unsafe struct VkVideoDecodeH265PictureInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH265PictureInfoKhr;
        public void* pNext;
        public StdVideoDecodeH265PictureInfo* pStdPictureInfo;
        public uint sliceSegmentCount;
        public uint* pSliceSegmentOffsets;
        public VkVideoDecodeH265PictureInfoKHR(VkStructureType sType, void* pNext, StdVideoDecodeH265PictureInfo* pStdPictureInfo, uint sliceSegmentCount, uint* pSliceSegmentOffsets)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pStdPictureInfo = pStdPictureInfo;
            this.sliceSegmentCount = sliceSegmentCount;
            this.pSliceSegmentOffsets = pSliceSegmentOffsets;
        }
    }
    public unsafe struct VkVideoDecodeH265DpbSlotInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeH265DpbSlotInfoKhr;
        public void* pNext;
        public StdVideoDecodeH265ReferenceInfo* pStdReferenceInfo;
        public VkVideoDecodeH265DpbSlotInfoKHR(VkStructureType sType, void* pNext, StdVideoDecodeH265ReferenceInfo* pStdReferenceInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pStdReferenceInfo = pStdReferenceInfo;
        }
    }
    public unsafe struct VkVideoDecodeAV1ProfileInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeAv1ProfileInfoKhr;
        public void* pNext;
        public StdVideoAV1Profile stdProfile;
        public int filmGrainSupport;
        public VkVideoDecodeAV1ProfileInfoKHR(VkStructureType sType, void* pNext, StdVideoAV1Profile stdProfile, int filmGrainSupport)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stdProfile = stdProfile;
            this.filmGrainSupport = filmGrainSupport;
        }
    }
    public unsafe struct VkVideoDecodeAV1CapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeAv1CapabilitiesKhr;
        public void* pNext;
        public StdVideoAV1Level maxLevel;
        public VkVideoDecodeAV1CapabilitiesKHR(VkStructureType sType, void* pNext, StdVideoAV1Level maxLevel)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxLevel = maxLevel;
        }
    }
    public unsafe struct VkVideoDecodeAV1SessionParametersCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeAv1SessionParametersCreateInfoKhr;
        public void* pNext;
        public StdVideoAV1SequenceHeader* pStdSequenceHeader;
        public VkVideoDecodeAV1SessionParametersCreateInfoKHR(VkStructureType sType, void* pNext, StdVideoAV1SequenceHeader* pStdSequenceHeader)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pStdSequenceHeader = pStdSequenceHeader;
        }
    }
    public unsafe struct VkVideoDecodeAV1PictureInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeAv1PictureInfoKhr;
        public void* pNext;
        public StdVideoDecodeAV1PictureInfo* pStdPictureInfo;
        public fixed int referenceNameSlotIndices[7];
        public uint frameHeaderOffset;
        public uint tileCount;
        public uint* pTileOffsets;
        public uint* pTileSizes;
        public VkVideoDecodeAV1PictureInfoKHR(){ }
    }
    public unsafe struct VkVideoDecodeAV1DpbSlotInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoDecodeAv1DpbSlotInfoKhr;
        public void* pNext;
        public StdVideoDecodeAV1ReferenceInfo* pStdReferenceInfo;
        public VkVideoDecodeAV1DpbSlotInfoKHR(VkStructureType sType, void* pNext, StdVideoDecodeAV1ReferenceInfo* pStdReferenceInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pStdReferenceInfo = pStdReferenceInfo;
        }
    }
    public unsafe struct VkVideoSessionCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoSessionCreateInfoKhr;
        public void* pNext;
        public uint queueFamilyIndex;
        public VkVideoSessionCreateFlagBitsKHR flags;
        public VkVideoProfileInfoKHR* pVideoProfile;
        public VkFormat pictureFormat;
        public VkExtent2D maxCodedExtent;
        public VkFormat referencePictureFormat;
        public uint maxDpbSlots;
        public uint maxActiveReferencePictures;
        public VkExtensionProperties* pStdHeaderVersion;
        public VkVideoSessionCreateInfoKHR(VkStructureType sType, void* pNext, uint queueFamilyIndex, VkVideoSessionCreateFlagBitsKHR flags, VkVideoProfileInfoKHR* pVideoProfile, VkFormat pictureFormat, VkExtent2D maxCodedExtent, VkFormat referencePictureFormat, uint maxDpbSlots, uint maxActiveReferencePictures, VkExtensionProperties* pStdHeaderVersion)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.queueFamilyIndex = queueFamilyIndex;
            this.flags = flags;
            this.pVideoProfile = pVideoProfile;
            this.pictureFormat = pictureFormat;
            this.maxCodedExtent = maxCodedExtent;
            this.referencePictureFormat = referencePictureFormat;
            this.maxDpbSlots = maxDpbSlots;
            this.maxActiveReferencePictures = maxActiveReferencePictures;
            this.pStdHeaderVersion = pStdHeaderVersion;
        }
    }
    public unsafe struct VkVideoSessionParametersCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoSessionParametersCreateInfoKhr;
        public void* pNext;
        public VkVideoSessionParametersCreateFlagsKHR flags;
        public VkVideoSessionParametersKHR videoSessionParametersTemplate;
        public VkVideoSessionKHR videoSession;
        public VkVideoSessionParametersCreateInfoKHR(VkStructureType sType, void* pNext, VkVideoSessionParametersCreateFlagsKHR flags, VkVideoSessionParametersKHR videoSessionParametersTemplate, VkVideoSessionKHR videoSession)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.videoSessionParametersTemplate = videoSessionParametersTemplate;
            this.videoSession = videoSession;
        }
    }
    public unsafe struct VkVideoSessionParametersUpdateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoSessionParametersUpdateInfoKhr;
        public void* pNext;
        public uint updateSequenceCount;
        public VkVideoSessionParametersUpdateInfoKHR(VkStructureType sType, void* pNext, uint updateSequenceCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.updateSequenceCount = updateSequenceCount;
        }
    }
    public unsafe struct VkVideoEncodeSessionParametersGetInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeSessionParametersGetInfoKhr;
        public void* pNext;
        public VkVideoSessionParametersKHR videoSessionParameters;
        public VkVideoEncodeSessionParametersGetInfoKHR(VkStructureType sType, void* pNext, VkVideoSessionParametersKHR videoSessionParameters)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.videoSessionParameters = videoSessionParameters;
        }
    }
    public unsafe struct VkVideoEncodeSessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeSessionParametersFeedbackInfoKhr;
        public void* pNext;
        public int hasOverrides;
        public VkVideoEncodeSessionParametersFeedbackInfoKHR(VkStructureType sType, void* pNext, int hasOverrides)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.hasOverrides = hasOverrides;
        }
    }
    public unsafe struct VkVideoBeginCodingInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoBeginCodingInfoKhr;
        public void* pNext;
        public VkVideoBeginCodingFlagsKHR flags;
        public VkVideoSessionKHR videoSession;
        public VkVideoSessionParametersKHR videoSessionParameters;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        public VkVideoBeginCodingInfoKHR(VkStructureType sType, void* pNext, VkVideoBeginCodingFlagsKHR flags, VkVideoSessionKHR videoSession, VkVideoSessionParametersKHR videoSessionParameters, uint referenceSlotCount, VkVideoReferenceSlotInfoKHR* pReferenceSlots)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.videoSession = videoSession;
            this.videoSessionParameters = videoSessionParameters;
            this.referenceSlotCount = referenceSlotCount;
            this.pReferenceSlots = pReferenceSlots;
        }
    }
    public unsafe struct VkVideoEndCodingInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEndCodingInfoKhr;
        public void* pNext;
        public VkVideoEndCodingFlagsKHR flags;
        public VkVideoEndCodingInfoKHR(VkStructureType sType, void* pNext, VkVideoEndCodingFlagsKHR flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkVideoCodingControlInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoCodingControlInfoKhr;
        public void* pNext;
        public VkVideoCodingControlFlagBitsKHR flags;
        public VkVideoCodingControlInfoKHR(VkStructureType sType, void* pNext, VkVideoCodingControlFlagBitsKHR flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkVideoEncodeUsageInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeUsageInfoKhr;
        public void* pNext;
        public VkVideoEncodeUsageFlagBitsKHR videoUsageHints;
        public VkVideoEncodeContentFlagBitsKHR videoContentHints;
        public VkVideoEncodeTuningModeKHR tuningMode;
        public VkVideoEncodeUsageInfoKHR(VkStructureType sType, void* pNext, VkVideoEncodeUsageFlagBitsKHR videoUsageHints, VkVideoEncodeContentFlagBitsKHR videoContentHints, VkVideoEncodeTuningModeKHR tuningMode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.videoUsageHints = videoUsageHints;
            this.videoContentHints = videoContentHints;
            this.tuningMode = tuningMode;
        }
    }
    public unsafe struct VkVideoEncodeInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeInfoKhr;
        public void* pNext;
        public VkVideoEncodeFlagBitsKHR flags;
        public VkBuffer dstBuffer;
        public ulong dstBufferOffset;
        public ulong dstBufferRange;
        public VkVideoPictureResourceInfoKHR srcPictureResource;
        public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        public uint precedingExternallyEncodedBytes;
        public VkVideoEncodeInfoKHR(VkStructureType sType, void* pNext, VkVideoEncodeFlagBitsKHR flags, VkBuffer dstBuffer, ulong dstBufferOffset, ulong dstBufferRange, VkVideoPictureResourceInfoKHR srcPictureResource, VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot, uint referenceSlotCount, VkVideoReferenceSlotInfoKHR* pReferenceSlots, uint precedingExternallyEncodedBytes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.dstBuffer = dstBuffer;
            this.dstBufferOffset = dstBufferOffset;
            this.dstBufferRange = dstBufferRange;
            this.srcPictureResource = srcPictureResource;
            this.pSetupReferenceSlot = pSetupReferenceSlot;
            this.referenceSlotCount = referenceSlotCount;
            this.pReferenceSlots = pReferenceSlots;
            this.precedingExternallyEncodedBytes = precedingExternallyEncodedBytes;
        }
    }
    public unsafe struct VkQueryPoolVideoEncodeFeedbackCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueryPoolVideoEncodeFeedbackCreateInfoKhr;
        public void* pNext;
        public VkVideoEncodeFeedbackFlagBitsKHR encodeFeedbackFlags;
        public VkQueryPoolVideoEncodeFeedbackCreateInfoKHR(VkStructureType sType, void* pNext, VkVideoEncodeFeedbackFlagBitsKHR encodeFeedbackFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.encodeFeedbackFlags = encodeFeedbackFlags;
        }
    }
    public unsafe struct VkVideoEncodeQualityLevelInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeQualityLevelInfoKhr;
        public void* pNext;
        public uint qualityLevel;
        public VkVideoEncodeQualityLevelInfoKHR(VkStructureType sType, void* pNext, uint qualityLevel)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.qualityLevel = qualityLevel;
        }
    }
    public unsafe struct VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceVideoEncodeQualityLevelInfoKhr;
        public void* pNext;
        public VkVideoProfileInfoKHR* pVideoProfile;
        public uint qualityLevel;
        public VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR(VkStructureType sType, void* pNext, VkVideoProfileInfoKHR* pVideoProfile, uint qualityLevel)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pVideoProfile = pVideoProfile;
            this.qualityLevel = qualityLevel;
        }
    }
    public unsafe struct VkVideoEncodeQualityLevelPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeQualityLevelPropertiesKhr;
        public void* pNext;
        public VkVideoEncodeRateControlModeFlagBitsKHR preferredRateControlMode;
        public uint preferredRateControlLayerCount;
        public VkVideoEncodeQualityLevelPropertiesKHR(VkStructureType sType, void* pNext, VkVideoEncodeRateControlModeFlagBitsKHR preferredRateControlMode, uint preferredRateControlLayerCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.preferredRateControlMode = preferredRateControlMode;
            this.preferredRateControlLayerCount = preferredRateControlLayerCount;
        }
    }
    public unsafe struct VkVideoEncodeRateControlInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeRateControlInfoKhr;
        public void* pNext;
        public VkVideoEncodeRateControlFlagsKHR flags;
        public VkVideoEncodeRateControlModeFlagBitsKHR rateControlMode;
        public uint layerCount;
        public VkVideoEncodeRateControlLayerInfoKHR* pLayers;
        public uint virtualBufferSizeInMs;
        public uint initialVirtualBufferSizeInMs;
        public VkVideoEncodeRateControlInfoKHR(VkStructureType sType, void* pNext, VkVideoEncodeRateControlFlagsKHR flags, VkVideoEncodeRateControlModeFlagBitsKHR rateControlMode, uint layerCount, VkVideoEncodeRateControlLayerInfoKHR* pLayers, uint virtualBufferSizeInMs, uint initialVirtualBufferSizeInMs)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.rateControlMode = rateControlMode;
            this.layerCount = layerCount;
            this.pLayers = pLayers;
            this.virtualBufferSizeInMs = virtualBufferSizeInMs;
            this.initialVirtualBufferSizeInMs = initialVirtualBufferSizeInMs;
        }
    }
    public unsafe struct VkVideoEncodeRateControlLayerInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeRateControlLayerInfoKhr;
        public void* pNext;
        public ulong averageBitrate;
        public ulong maxBitrate;
        public uint frameRateNumerator;
        public uint frameRateDenominator;
        public VkVideoEncodeRateControlLayerInfoKHR(VkStructureType sType, void* pNext, ulong averageBitrate, ulong maxBitrate, uint frameRateNumerator, uint frameRateDenominator)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.averageBitrate = averageBitrate;
            this.maxBitrate = maxBitrate;
            this.frameRateNumerator = frameRateNumerator;
            this.frameRateDenominator = frameRateDenominator;
        }
    }
    public unsafe struct VkVideoEncodeCapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeCapabilitiesKhr;
        public void* pNext;
        public VkVideoEncodeCapabilityFlagBitsKHR flags;
        public VkVideoEncodeRateControlModeFlagBitsKHR rateControlModes;
        public uint maxRateControlLayers;
        public ulong maxBitrate;
        public uint maxQualityLevels;
        public VkExtent2D encodeInputPictureGranularity;
        public VkVideoEncodeFeedbackFlagBitsKHR supportedEncodeFeedbackFlags;
        public VkVideoEncodeCapabilitiesKHR(VkStructureType sType, void* pNext, VkVideoEncodeCapabilityFlagBitsKHR flags, VkVideoEncodeRateControlModeFlagBitsKHR rateControlModes, uint maxRateControlLayers, ulong maxBitrate, uint maxQualityLevels, VkExtent2D encodeInputPictureGranularity, VkVideoEncodeFeedbackFlagBitsKHR supportedEncodeFeedbackFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.rateControlModes = rateControlModes;
            this.maxRateControlLayers = maxRateControlLayers;
            this.maxBitrate = maxBitrate;
            this.maxQualityLevels = maxQualityLevels;
            this.encodeInputPictureGranularity = encodeInputPictureGranularity;
            this.supportedEncodeFeedbackFlags = supportedEncodeFeedbackFlags;
        }
    }
    public unsafe struct VkVideoEncodeH264CapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264CapabilitiesKhr;
        public void* pNext;
        public VkVideoEncodeH264CapabilityFlagBitsKHR flags;
        public StdVideoH264LevelIdc maxLevelIdc;
        public uint maxSliceCount;
        public uint maxPPictureL0ReferenceCount;
        public uint maxBPictureL0ReferenceCount;
        public uint maxL1ReferenceCount;
        public uint maxTemporalLayerCount;
        public int expectDyadicTemporalLayerPattern;
        public int minQp;
        public int maxQp;
        public int prefersGopRemainingFrames;
        public int requiresGopRemainingFrames;
        public VkVideoEncodeH264StdFlagBitsKHR stdSyntaxFlags;
        public VkVideoEncodeH264CapabilitiesKHR(VkStructureType sType, void* pNext, VkVideoEncodeH264CapabilityFlagBitsKHR flags, StdVideoH264LevelIdc maxLevelIdc, uint maxSliceCount, uint maxPPictureL0ReferenceCount, uint maxBPictureL0ReferenceCount, uint maxL1ReferenceCount, uint maxTemporalLayerCount, int expectDyadicTemporalLayerPattern, int minQp, int maxQp, int prefersGopRemainingFrames, int requiresGopRemainingFrames, VkVideoEncodeH264StdFlagBitsKHR stdSyntaxFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.maxLevelIdc = maxLevelIdc;
            this.maxSliceCount = maxSliceCount;
            this.maxPPictureL0ReferenceCount = maxPPictureL0ReferenceCount;
            this.maxBPictureL0ReferenceCount = maxBPictureL0ReferenceCount;
            this.maxL1ReferenceCount = maxL1ReferenceCount;
            this.maxTemporalLayerCount = maxTemporalLayerCount;
            this.expectDyadicTemporalLayerPattern = expectDyadicTemporalLayerPattern;
            this.minQp = minQp;
            this.maxQp = maxQp;
            this.prefersGopRemainingFrames = prefersGopRemainingFrames;
            this.requiresGopRemainingFrames = requiresGopRemainingFrames;
            this.stdSyntaxFlags = stdSyntaxFlags;
        }
    }
    public unsafe struct VkVideoEncodeH264QualityLevelPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264QualityLevelPropertiesKhr;
        public void* pNext;
        public VkVideoEncodeH264RateControlFlagBitsKHR preferredRateControlFlags;
        public uint preferredGopFrameCount;
        public uint preferredIdrPeriod;
        public uint preferredConsecutiveBFrameCount;
        public uint preferredTemporalLayerCount;
        public VkVideoEncodeH264QpKHR preferredConstantQp;
        public uint preferredMaxL0ReferenceCount;
        public uint preferredMaxL1ReferenceCount;
        public int preferredStdEntropyCodingModeFlag;
        public VkVideoEncodeH264QualityLevelPropertiesKHR(VkStructureType sType, void* pNext, VkVideoEncodeH264RateControlFlagBitsKHR preferredRateControlFlags, uint preferredGopFrameCount, uint preferredIdrPeriod, uint preferredConsecutiveBFrameCount, uint preferredTemporalLayerCount, VkVideoEncodeH264QpKHR preferredConstantQp, uint preferredMaxL0ReferenceCount, uint preferredMaxL1ReferenceCount, int preferredStdEntropyCodingModeFlag)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.preferredRateControlFlags = preferredRateControlFlags;
            this.preferredGopFrameCount = preferredGopFrameCount;
            this.preferredIdrPeriod = preferredIdrPeriod;
            this.preferredConsecutiveBFrameCount = preferredConsecutiveBFrameCount;
            this.preferredTemporalLayerCount = preferredTemporalLayerCount;
            this.preferredConstantQp = preferredConstantQp;
            this.preferredMaxL0ReferenceCount = preferredMaxL0ReferenceCount;
            this.preferredMaxL1ReferenceCount = preferredMaxL1ReferenceCount;
            this.preferredStdEntropyCodingModeFlag = preferredStdEntropyCodingModeFlag;
        }
    }
    public unsafe struct VkVideoEncodeH264SessionCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264SessionCreateInfoKhr;
        public void* pNext;
        public int useMaxLevelIdc;
        public StdVideoH264LevelIdc maxLevelIdc;
        public VkVideoEncodeH264SessionCreateInfoKHR(VkStructureType sType, void* pNext, int useMaxLevelIdc, StdVideoH264LevelIdc maxLevelIdc)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.useMaxLevelIdc = useMaxLevelIdc;
            this.maxLevelIdc = maxLevelIdc;
        }
    }
    public unsafe struct VkVideoEncodeH264SessionParametersAddInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264SessionParametersAddInfoKhr;
        public void* pNext;
        public uint stdSPSCount;
        public StdVideoH264SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH264PictureParameterSet* pStdPPSs;
        public VkVideoEncodeH264SessionParametersAddInfoKHR(VkStructureType sType, void* pNext, uint stdSPSCount, StdVideoH264SequenceParameterSet* pStdSPSs, uint stdPPSCount, StdVideoH264PictureParameterSet* pStdPPSs)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stdSPSCount = stdSPSCount;
            this.pStdSPSs = pStdSPSs;
            this.stdPPSCount = stdPPSCount;
            this.pStdPPSs = pStdPPSs;
        }
    }
    public unsafe struct VkVideoEncodeH264SessionParametersCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264SessionParametersCreateInfoKhr;
        public void* pNext;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoEncodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
        public VkVideoEncodeH264SessionParametersCreateInfoKHR(VkStructureType sType, void* pNext, uint maxStdSPSCount, uint maxStdPPSCount, VkVideoEncodeH264SessionParametersAddInfoKHR* pParametersAddInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxStdSPSCount = maxStdSPSCount;
            this.maxStdPPSCount = maxStdPPSCount;
            this.pParametersAddInfo = pParametersAddInfo;
        }
    }
    public unsafe struct VkVideoEncodeH264SessionParametersGetInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264SessionParametersGetInfoKhr;
        public void* pNext;
        public int writeStdSPS;
        public int writeStdPPS;
        public uint stdSPSId;
        public uint stdPPSId;
        public VkVideoEncodeH264SessionParametersGetInfoKHR(VkStructureType sType, void* pNext, int writeStdSPS, int writeStdPPS, uint stdSPSId, uint stdPPSId)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.writeStdSPS = writeStdSPS;
            this.writeStdPPS = writeStdPPS;
            this.stdSPSId = stdSPSId;
            this.stdPPSId = stdPPSId;
        }
    }
    public unsafe struct VkVideoEncodeH264SessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264SessionParametersFeedbackInfoKhr;
        public void* pNext;
        public int hasStdSPSOverrides;
        public int hasStdPPSOverrides;
        public VkVideoEncodeH264SessionParametersFeedbackInfoKHR(VkStructureType sType, void* pNext, int hasStdSPSOverrides, int hasStdPPSOverrides)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.hasStdSPSOverrides = hasStdSPSOverrides;
            this.hasStdPPSOverrides = hasStdPPSOverrides;
        }
    }
    public unsafe struct VkVideoEncodeH264DpbSlotInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264DpbSlotInfoKhr;
        public void* pNext;
        public StdVideoEncodeH264ReferenceInfo* pStdReferenceInfo;
        public VkVideoEncodeH264DpbSlotInfoKHR(VkStructureType sType, void* pNext, StdVideoEncodeH264ReferenceInfo* pStdReferenceInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pStdReferenceInfo = pStdReferenceInfo;
        }
    }
    public unsafe struct VkVideoEncodeH264PictureInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264PictureInfoKhr;
        public void* pNext;
        public uint naluSliceEntryCount;
        public VkVideoEncodeH264NaluSliceInfoKHR* pNaluSliceEntries;
        public StdVideoEncodeH264PictureInfo* pStdPictureInfo;
        public int generatePrefixNalu;
        public VkVideoEncodeH264PictureInfoKHR(VkStructureType sType, void* pNext, uint naluSliceEntryCount, VkVideoEncodeH264NaluSliceInfoKHR* pNaluSliceEntries, StdVideoEncodeH264PictureInfo* pStdPictureInfo, int generatePrefixNalu)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.naluSliceEntryCount = naluSliceEntryCount;
            this.pNaluSliceEntries = pNaluSliceEntries;
            this.pStdPictureInfo = pStdPictureInfo;
            this.generatePrefixNalu = generatePrefixNalu;
        }
    }
    public unsafe struct VkVideoEncodeH264ProfileInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264ProfileInfoKhr;
        public void* pNext;
        public StdVideoH264ProfileIdc stdProfileIdc;
        public VkVideoEncodeH264ProfileInfoKHR(VkStructureType sType, void* pNext, StdVideoH264ProfileIdc stdProfileIdc)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stdProfileIdc = stdProfileIdc;
        }
    }
    public unsafe struct VkVideoEncodeH264NaluSliceInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264NaluSliceInfoKhr;
        public void* pNext;
        public int constantQp;
        public StdVideoEncodeH264SliceHeader* pStdSliceHeader;
        public VkVideoEncodeH264NaluSliceInfoKHR(VkStructureType sType, void* pNext, int constantQp, StdVideoEncodeH264SliceHeader* pStdSliceHeader)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.constantQp = constantQp;
            this.pStdSliceHeader = pStdSliceHeader;
        }
    }
    public unsafe struct VkVideoEncodeH264RateControlInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264RateControlInfoKhr;
        public void* pNext;
        public VkVideoEncodeH264RateControlFlagBitsKHR flags;
        public uint gopFrameCount;
        public uint idrPeriod;
        public uint consecutiveBFrameCount;
        public uint temporalLayerCount;
        public VkVideoEncodeH264RateControlInfoKHR(VkStructureType sType, void* pNext, VkVideoEncodeH264RateControlFlagBitsKHR flags, uint gopFrameCount, uint idrPeriod, uint consecutiveBFrameCount, uint temporalLayerCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.gopFrameCount = gopFrameCount;
            this.idrPeriod = idrPeriod;
            this.consecutiveBFrameCount = consecutiveBFrameCount;
            this.temporalLayerCount = temporalLayerCount;
        }
    }
    public unsafe struct VkVideoEncodeH264QpKHR
    {
        public int qpI;
        public int qpP;
        public int qpB;
        public VkVideoEncodeH264QpKHR(int qpI, int qpP, int qpB)
        {
            this.qpI = qpI;
            this.qpP = qpP;
            this.qpB = qpB;
        }
    }
    public unsafe struct VkVideoEncodeH264FrameSizeKHR
    {
        public uint frameISize;
        public uint framePSize;
        public uint frameBSize;
        public VkVideoEncodeH264FrameSizeKHR(uint frameISize, uint framePSize, uint frameBSize)
        {
            this.frameISize = frameISize;
            this.framePSize = framePSize;
            this.frameBSize = frameBSize;
        }
    }
    public unsafe struct VkVideoEncodeH264GopRemainingFrameInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264GopRemainingFrameInfoKhr;
        public void* pNext;
        public int useGopRemainingFrames;
        public uint gopRemainingI;
        public uint gopRemainingP;
        public uint gopRemainingB;
        public VkVideoEncodeH264GopRemainingFrameInfoKHR(VkStructureType sType, void* pNext, int useGopRemainingFrames, uint gopRemainingI, uint gopRemainingP, uint gopRemainingB)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.useGopRemainingFrames = useGopRemainingFrames;
            this.gopRemainingI = gopRemainingI;
            this.gopRemainingP = gopRemainingP;
            this.gopRemainingB = gopRemainingB;
        }
    }
    public unsafe struct VkVideoEncodeH264RateControlLayerInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH264RateControlLayerInfoKhr;
        public void* pNext;
        public int useMinQp;
        public VkVideoEncodeH264QpKHR minQp;
        public int useMaxQp;
        public VkVideoEncodeH264QpKHR maxQp;
        public int useMaxFrameSize;
        public VkVideoEncodeH264FrameSizeKHR maxFrameSize;
        public VkVideoEncodeH264RateControlLayerInfoKHR(VkStructureType sType, void* pNext, int useMinQp, VkVideoEncodeH264QpKHR minQp, int useMaxQp, VkVideoEncodeH264QpKHR maxQp, int useMaxFrameSize, VkVideoEncodeH264FrameSizeKHR maxFrameSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.useMinQp = useMinQp;
            this.minQp = minQp;
            this.useMaxQp = useMaxQp;
            this.maxQp = maxQp;
            this.useMaxFrameSize = useMaxFrameSize;
            this.maxFrameSize = maxFrameSize;
        }
    }
    public unsafe struct VkVideoEncodeH265CapabilitiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265CapabilitiesKhr;
        public void* pNext;
        public VkVideoEncodeH265CapabilityFlagBitsKHR flags;
        public StdVideoH265LevelIdc maxLevelIdc;
        public uint maxSliceSegmentCount;
        public VkExtent2D maxTiles;
        public VkVideoEncodeH265CtbSizeFlagBitsKHR ctbSizes;
        public VkVideoEncodeH265TransformBlockSizeFlagBitsKHR transformBlockSizes;
        public uint maxPPictureL0ReferenceCount;
        public uint maxBPictureL0ReferenceCount;
        public uint maxL1ReferenceCount;
        public uint maxSubLayerCount;
        public int expectDyadicTemporalSubLayerPattern;
        public int minQp;
        public int maxQp;
        public int prefersGopRemainingFrames;
        public int requiresGopRemainingFrames;
        public VkVideoEncodeH265StdFlagBitsKHR stdSyntaxFlags;
        public VkVideoEncodeH265CapabilitiesKHR(VkStructureType sType, void* pNext, VkVideoEncodeH265CapabilityFlagBitsKHR flags, StdVideoH265LevelIdc maxLevelIdc, uint maxSliceSegmentCount, VkExtent2D maxTiles, VkVideoEncodeH265CtbSizeFlagBitsKHR ctbSizes, VkVideoEncodeH265TransformBlockSizeFlagBitsKHR transformBlockSizes, uint maxPPictureL0ReferenceCount, uint maxBPictureL0ReferenceCount, uint maxL1ReferenceCount, uint maxSubLayerCount, int expectDyadicTemporalSubLayerPattern, int minQp, int maxQp, int prefersGopRemainingFrames, int requiresGopRemainingFrames, VkVideoEncodeH265StdFlagBitsKHR stdSyntaxFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.maxLevelIdc = maxLevelIdc;
            this.maxSliceSegmentCount = maxSliceSegmentCount;
            this.maxTiles = maxTiles;
            this.ctbSizes = ctbSizes;
            this.transformBlockSizes = transformBlockSizes;
            this.maxPPictureL0ReferenceCount = maxPPictureL0ReferenceCount;
            this.maxBPictureL0ReferenceCount = maxBPictureL0ReferenceCount;
            this.maxL1ReferenceCount = maxL1ReferenceCount;
            this.maxSubLayerCount = maxSubLayerCount;
            this.expectDyadicTemporalSubLayerPattern = expectDyadicTemporalSubLayerPattern;
            this.minQp = minQp;
            this.maxQp = maxQp;
            this.prefersGopRemainingFrames = prefersGopRemainingFrames;
            this.requiresGopRemainingFrames = requiresGopRemainingFrames;
            this.stdSyntaxFlags = stdSyntaxFlags;
        }
    }
    public unsafe struct VkVideoEncodeH265QualityLevelPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265QualityLevelPropertiesKhr;
        public void* pNext;
        public VkVideoEncodeH265RateControlFlagBitsKHR preferredRateControlFlags;
        public uint preferredGopFrameCount;
        public uint preferredIdrPeriod;
        public uint preferredConsecutiveBFrameCount;
        public uint preferredSubLayerCount;
        public VkVideoEncodeH265QpKHR preferredConstantQp;
        public uint preferredMaxL0ReferenceCount;
        public uint preferredMaxL1ReferenceCount;
        public VkVideoEncodeH265QualityLevelPropertiesKHR(VkStructureType sType, void* pNext, VkVideoEncodeH265RateControlFlagBitsKHR preferredRateControlFlags, uint preferredGopFrameCount, uint preferredIdrPeriod, uint preferredConsecutiveBFrameCount, uint preferredSubLayerCount, VkVideoEncodeH265QpKHR preferredConstantQp, uint preferredMaxL0ReferenceCount, uint preferredMaxL1ReferenceCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.preferredRateControlFlags = preferredRateControlFlags;
            this.preferredGopFrameCount = preferredGopFrameCount;
            this.preferredIdrPeriod = preferredIdrPeriod;
            this.preferredConsecutiveBFrameCount = preferredConsecutiveBFrameCount;
            this.preferredSubLayerCount = preferredSubLayerCount;
            this.preferredConstantQp = preferredConstantQp;
            this.preferredMaxL0ReferenceCount = preferredMaxL0ReferenceCount;
            this.preferredMaxL1ReferenceCount = preferredMaxL1ReferenceCount;
        }
    }
    public unsafe struct VkVideoEncodeH265SessionCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265SessionCreateInfoKhr;
        public void* pNext;
        public int useMaxLevelIdc;
        public StdVideoH265LevelIdc maxLevelIdc;
        public VkVideoEncodeH265SessionCreateInfoKHR(VkStructureType sType, void* pNext, int useMaxLevelIdc, StdVideoH265LevelIdc maxLevelIdc)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.useMaxLevelIdc = useMaxLevelIdc;
            this.maxLevelIdc = maxLevelIdc;
        }
    }
    public unsafe struct VkVideoEncodeH265SessionParametersAddInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265SessionParametersAddInfoKhr;
        public void* pNext;
        public uint stdVPSCount;
        public StdVideoH265VideoParameterSet* pStdVPSs;
        public uint stdSPSCount;
        public StdVideoH265SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH265PictureParameterSet* pStdPPSs;
        public VkVideoEncodeH265SessionParametersAddInfoKHR(VkStructureType sType, void* pNext, uint stdVPSCount, StdVideoH265VideoParameterSet* pStdVPSs, uint stdSPSCount, StdVideoH265SequenceParameterSet* pStdSPSs, uint stdPPSCount, StdVideoH265PictureParameterSet* pStdPPSs)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stdVPSCount = stdVPSCount;
            this.pStdVPSs = pStdVPSs;
            this.stdSPSCount = stdSPSCount;
            this.pStdSPSs = pStdSPSs;
            this.stdPPSCount = stdPPSCount;
            this.pStdPPSs = pStdPPSs;
        }
    }
    public unsafe struct VkVideoEncodeH265SessionParametersCreateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265SessionParametersCreateInfoKhr;
        public void* pNext;
        public uint maxStdVPSCount;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoEncodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
        public VkVideoEncodeH265SessionParametersCreateInfoKHR(VkStructureType sType, void* pNext, uint maxStdVPSCount, uint maxStdSPSCount, uint maxStdPPSCount, VkVideoEncodeH265SessionParametersAddInfoKHR* pParametersAddInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxStdVPSCount = maxStdVPSCount;
            this.maxStdSPSCount = maxStdSPSCount;
            this.maxStdPPSCount = maxStdPPSCount;
            this.pParametersAddInfo = pParametersAddInfo;
        }
    }
    public unsafe struct VkVideoEncodeH265SessionParametersGetInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265SessionParametersGetInfoKhr;
        public void* pNext;
        public int writeStdVPS;
        public int writeStdSPS;
        public int writeStdPPS;
        public uint stdVPSId;
        public uint stdSPSId;
        public uint stdPPSId;
        public VkVideoEncodeH265SessionParametersGetInfoKHR(VkStructureType sType, void* pNext, int writeStdVPS, int writeStdSPS, int writeStdPPS, uint stdVPSId, uint stdSPSId, uint stdPPSId)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.writeStdVPS = writeStdVPS;
            this.writeStdSPS = writeStdSPS;
            this.writeStdPPS = writeStdPPS;
            this.stdVPSId = stdVPSId;
            this.stdSPSId = stdSPSId;
            this.stdPPSId = stdPPSId;
        }
    }
    public unsafe struct VkVideoEncodeH265SessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265SessionParametersFeedbackInfoKhr;
        public void* pNext;
        public int hasStdVPSOverrides;
        public int hasStdSPSOverrides;
        public int hasStdPPSOverrides;
        public VkVideoEncodeH265SessionParametersFeedbackInfoKHR(VkStructureType sType, void* pNext, int hasStdVPSOverrides, int hasStdSPSOverrides, int hasStdPPSOverrides)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.hasStdVPSOverrides = hasStdVPSOverrides;
            this.hasStdSPSOverrides = hasStdSPSOverrides;
            this.hasStdPPSOverrides = hasStdPPSOverrides;
        }
    }
    public unsafe struct VkVideoEncodeH265PictureInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265PictureInfoKhr;
        public void* pNext;
        public uint naluSliceSegmentEntryCount;
        public VkVideoEncodeH265NaluSliceSegmentInfoKHR* pNaluSliceSegmentEntries;
        public StdVideoEncodeH265PictureInfo* pStdPictureInfo;
        public VkVideoEncodeH265PictureInfoKHR(VkStructureType sType, void* pNext, uint naluSliceSegmentEntryCount, VkVideoEncodeH265NaluSliceSegmentInfoKHR* pNaluSliceSegmentEntries, StdVideoEncodeH265PictureInfo* pStdPictureInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.naluSliceSegmentEntryCount = naluSliceSegmentEntryCount;
            this.pNaluSliceSegmentEntries = pNaluSliceSegmentEntries;
            this.pStdPictureInfo = pStdPictureInfo;
        }
    }
    public unsafe struct VkVideoEncodeH265NaluSliceSegmentInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265NaluSliceSegmentInfoKhr;
        public void* pNext;
        public int constantQp;
        public StdVideoEncodeH265SliceSegmentHeader* pStdSliceSegmentHeader;
        public VkVideoEncodeH265NaluSliceSegmentInfoKHR(VkStructureType sType, void* pNext, int constantQp, StdVideoEncodeH265SliceSegmentHeader* pStdSliceSegmentHeader)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.constantQp = constantQp;
            this.pStdSliceSegmentHeader = pStdSliceSegmentHeader;
        }
    }
    public unsafe struct VkVideoEncodeH265RateControlInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265RateControlInfoKhr;
        public void* pNext;
        public VkVideoEncodeH265RateControlFlagBitsKHR flags;
        public uint gopFrameCount;
        public uint idrPeriod;
        public uint consecutiveBFrameCount;
        public uint subLayerCount;
        public VkVideoEncodeH265RateControlInfoKHR(VkStructureType sType, void* pNext, VkVideoEncodeH265RateControlFlagBitsKHR flags, uint gopFrameCount, uint idrPeriod, uint consecutiveBFrameCount, uint subLayerCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.gopFrameCount = gopFrameCount;
            this.idrPeriod = idrPeriod;
            this.consecutiveBFrameCount = consecutiveBFrameCount;
            this.subLayerCount = subLayerCount;
        }
    }
    public unsafe struct VkVideoEncodeH265QpKHR
    {
        public int qpI;
        public int qpP;
        public int qpB;
        public VkVideoEncodeH265QpKHR(int qpI, int qpP, int qpB)
        {
            this.qpI = qpI;
            this.qpP = qpP;
            this.qpB = qpB;
        }
    }
    public unsafe struct VkVideoEncodeH265FrameSizeKHR
    {
        public uint frameISize;
        public uint framePSize;
        public uint frameBSize;
        public VkVideoEncodeH265FrameSizeKHR(uint frameISize, uint framePSize, uint frameBSize)
        {
            this.frameISize = frameISize;
            this.framePSize = framePSize;
            this.frameBSize = frameBSize;
        }
    }
    public unsafe struct VkVideoEncodeH265GopRemainingFrameInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265GopRemainingFrameInfoKhr;
        public void* pNext;
        public int useGopRemainingFrames;
        public uint gopRemainingI;
        public uint gopRemainingP;
        public uint gopRemainingB;
        public VkVideoEncodeH265GopRemainingFrameInfoKHR(VkStructureType sType, void* pNext, int useGopRemainingFrames, uint gopRemainingI, uint gopRemainingP, uint gopRemainingB)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.useGopRemainingFrames = useGopRemainingFrames;
            this.gopRemainingI = gopRemainingI;
            this.gopRemainingP = gopRemainingP;
            this.gopRemainingB = gopRemainingB;
        }
    }
    public unsafe struct VkVideoEncodeH265RateControlLayerInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265RateControlLayerInfoKhr;
        public void* pNext;
        public int useMinQp;
        public VkVideoEncodeH265QpKHR minQp;
        public int useMaxQp;
        public VkVideoEncodeH265QpKHR maxQp;
        public int useMaxFrameSize;
        public VkVideoEncodeH265FrameSizeKHR maxFrameSize;
        public VkVideoEncodeH265RateControlLayerInfoKHR(VkStructureType sType, void* pNext, int useMinQp, VkVideoEncodeH265QpKHR minQp, int useMaxQp, VkVideoEncodeH265QpKHR maxQp, int useMaxFrameSize, VkVideoEncodeH265FrameSizeKHR maxFrameSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.useMinQp = useMinQp;
            this.minQp = minQp;
            this.useMaxQp = useMaxQp;
            this.maxQp = maxQp;
            this.useMaxFrameSize = useMaxFrameSize;
            this.maxFrameSize = maxFrameSize;
        }
    }
    public unsafe struct VkVideoEncodeH265ProfileInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265ProfileInfoKhr;
        public void* pNext;
        public StdVideoH265ProfileIdc stdProfileIdc;
        public VkVideoEncodeH265ProfileInfoKHR(VkStructureType sType, void* pNext, StdVideoH265ProfileIdc stdProfileIdc)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stdProfileIdc = stdProfileIdc;
        }
    }
    public unsafe struct VkVideoEncodeH265DpbSlotInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeVideoEncodeH265DpbSlotInfoKhr;
        public void* pNext;
        public StdVideoEncodeH265ReferenceInfo* pStdReferenceInfo;
        public VkVideoEncodeH265DpbSlotInfoKHR(VkStructureType sType, void* pNext, StdVideoEncodeH265ReferenceInfo* pStdReferenceInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pStdReferenceInfo = pStdReferenceInfo;
        }
    }
    public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceInheritedViewportScissorFeaturesNv;
        public void* pNext;
        public int inheritedViewportScissor2D;
        public VkPhysicalDeviceInheritedViewportScissorFeaturesNV(VkStructureType sType, void* pNext, int inheritedViewportScissor2D)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.inheritedViewportScissor2D = inheritedViewportScissor2D;
        }
    }
    public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeCommandBufferInheritanceViewportScissorInfoNv;
        public void* pNext;
        public int viewportScissor2D;
        public uint viewportDepthCount;
        public VkViewport* pViewportDepths;
        public VkCommandBufferInheritanceViewportScissorInfoNV(VkStructureType sType, void* pNext, int viewportScissor2D, uint viewportDepthCount, VkViewport* pViewportDepths)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.viewportScissor2D = viewportScissor2D;
            this.viewportDepthCount = viewportDepthCount;
            this.pViewportDepths = pViewportDepths;
        }
    }
    public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceYcbcr2Plane444FormatsFeaturesExt;
        public void* pNext;
        public int ycbcr2plane444Formats;
        public VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT(VkStructureType sType, void* pNext, int ycbcr2plane444Formats)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.ycbcr2plane444Formats = ycbcr2plane444Formats;
        }
    }
    public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceProvokingVertexFeaturesExt;
        public void* pNext;
        public int provokingVertexLast;
        public int transformFeedbackPreservesProvokingVertex;
        public VkPhysicalDeviceProvokingVertexFeaturesEXT(VkStructureType sType, void* pNext, int provokingVertexLast, int transformFeedbackPreservesProvokingVertex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.provokingVertexLast = provokingVertexLast;
            this.transformFeedbackPreservesProvokingVertex = transformFeedbackPreservesProvokingVertex;
        }
    }
    public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceProvokingVertexPropertiesExt;
        public void* pNext;
        public int provokingVertexModePerPipeline;
        public int transformFeedbackPreservesTriangleFanProvokingVertex;
        public VkPhysicalDeviceProvokingVertexPropertiesEXT(VkStructureType sType, void* pNext, int provokingVertexModePerPipeline, int transformFeedbackPreservesTriangleFanProvokingVertex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.provokingVertexModePerPipeline = provokingVertexModePerPipeline;
            this.transformFeedbackPreservesTriangleFanProvokingVertex = transformFeedbackPreservesTriangleFanProvokingVertex;
        }
    }
    public unsafe struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRasterizationProvokingVertexStateCreateInfoExt;
        public void* pNext;
        public VkProvokingVertexModeEXT provokingVertexMode;
        public VkPipelineRasterizationProvokingVertexStateCreateInfoEXT(VkStructureType sType, void* pNext, VkProvokingVertexModeEXT provokingVertexMode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.provokingVertexMode = provokingVertexMode;
        }
    }
    public unsafe struct VkCuModuleCreateInfoNVX
    {
        public VkStructureType sType = VkStructureType.StructureTypeCuModuleCreateInfoNvx;
        public void* pNext;
        public nuint dataSize;
        public void* pData;
        public VkCuModuleCreateInfoNVX(VkStructureType sType, void* pNext, nuint dataSize, void* pData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dataSize = dataSize;
            this.pData = pData;
        }
    }
    public unsafe struct VkCuFunctionCreateInfoNVX
    {
        public VkStructureType sType = VkStructureType.StructureTypeCuFunctionCreateInfoNvx;
        public void* pNext;
        public VkCuModuleNVX module;
        public byte* pName;
        public VkCuFunctionCreateInfoNVX(VkStructureType sType, void* pNext, VkCuModuleNVX module, byte* pName)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.module = module;
            this.pName = pName;
        }
    }
    public unsafe struct VkCuLaunchInfoNVX
    {
        public VkStructureType sType = VkStructureType.StructureTypeCuLaunchInfoNvx;
        public void* pNext;
        public VkCuFunctionNVX function;
        public uint gridDimX;
        public uint gridDimY;
        public uint gridDimZ;
        public uint blockDimX;
        public uint blockDimY;
        public uint blockDimZ;
        public uint sharedMemBytes;
        public nuint paramCount;
        public void** pParams;
        public nuint extraCount;
        public void** pExtras;
        public VkCuLaunchInfoNVX(VkStructureType sType, void* pNext, VkCuFunctionNVX function, uint gridDimX, uint gridDimY, uint gridDimZ, uint blockDimX, uint blockDimY, uint blockDimZ, uint sharedMemBytes, nuint paramCount, void** pParams, nuint extraCount, void** pExtras)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.function = function;
            this.gridDimX = gridDimX;
            this.gridDimY = gridDimY;
            this.gridDimZ = gridDimZ;
            this.blockDimX = blockDimX;
            this.blockDimY = blockDimY;
            this.blockDimZ = blockDimZ;
            this.sharedMemBytes = sharedMemBytes;
            this.paramCount = paramCount;
            this.pParams = pParams;
            this.extraCount = extraCount;
            this.pExtras = pExtras;
        }
    }
    public unsafe struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDescriptorBufferFeaturesExt;
        public void* pNext;
        public int descriptorBuffer;
        public int descriptorBufferCaptureReplay;
        public int descriptorBufferImageLayoutIgnored;
        public int descriptorBufferPushDescriptors;
        public VkPhysicalDeviceDescriptorBufferFeaturesEXT(VkStructureType sType, void* pNext, int descriptorBuffer, int descriptorBufferCaptureReplay, int descriptorBufferImageLayoutIgnored, int descriptorBufferPushDescriptors)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.descriptorBuffer = descriptorBuffer;
            this.descriptorBufferCaptureReplay = descriptorBufferCaptureReplay;
            this.descriptorBufferImageLayoutIgnored = descriptorBufferImageLayoutIgnored;
            this.descriptorBufferPushDescriptors = descriptorBufferPushDescriptors;
        }
    }
    public unsafe struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDescriptorBufferPropertiesExt;
        public void* pNext;
        public int combinedImageSamplerDescriptorSingleArray;
        public int bufferlessPushDescriptors;
        public int allowSamplerImageViewPostSubmitCreation;
        public ulong descriptorBufferOffsetAlignment;
        public uint maxDescriptorBufferBindings;
        public uint maxResourceDescriptorBufferBindings;
        public uint maxSamplerDescriptorBufferBindings;
        public uint maxEmbeddedImmutableSamplerBindings;
        public uint maxEmbeddedImmutableSamplers;
        public nuint bufferCaptureReplayDescriptorDataSize;
        public nuint imageCaptureReplayDescriptorDataSize;
        public nuint imageViewCaptureReplayDescriptorDataSize;
        public nuint samplerCaptureReplayDescriptorDataSize;
        public nuint accelerationStructureCaptureReplayDescriptorDataSize;
        public nuint samplerDescriptorSize;
        public nuint combinedImageSamplerDescriptorSize;
        public nuint sampledImageDescriptorSize;
        public nuint storageImageDescriptorSize;
        public nuint uniformTexelBufferDescriptorSize;
        public nuint robustUniformTexelBufferDescriptorSize;
        public nuint storageTexelBufferDescriptorSize;
        public nuint robustStorageTexelBufferDescriptorSize;
        public nuint uniformBufferDescriptorSize;
        public nuint robustUniformBufferDescriptorSize;
        public nuint storageBufferDescriptorSize;
        public nuint robustStorageBufferDescriptorSize;
        public nuint inputAttachmentDescriptorSize;
        public nuint accelerationStructureDescriptorSize;
        public ulong maxSamplerDescriptorBufferRange;
        public ulong maxResourceDescriptorBufferRange;
        public ulong samplerDescriptorBufferAddressSpaceSize;
        public ulong resourceDescriptorBufferAddressSpaceSize;
        public ulong descriptorBufferAddressSpaceSize;
        public VkPhysicalDeviceDescriptorBufferPropertiesEXT(VkStructureType sType, void* pNext, int combinedImageSamplerDescriptorSingleArray, int bufferlessPushDescriptors, int allowSamplerImageViewPostSubmitCreation, ulong descriptorBufferOffsetAlignment, uint maxDescriptorBufferBindings, uint maxResourceDescriptorBufferBindings, uint maxSamplerDescriptorBufferBindings, uint maxEmbeddedImmutableSamplerBindings, uint maxEmbeddedImmutableSamplers, nuint bufferCaptureReplayDescriptorDataSize, nuint imageCaptureReplayDescriptorDataSize, nuint imageViewCaptureReplayDescriptorDataSize, nuint samplerCaptureReplayDescriptorDataSize, nuint accelerationStructureCaptureReplayDescriptorDataSize, nuint samplerDescriptorSize, nuint combinedImageSamplerDescriptorSize, nuint sampledImageDescriptorSize, nuint storageImageDescriptorSize, nuint uniformTexelBufferDescriptorSize, nuint robustUniformTexelBufferDescriptorSize, nuint storageTexelBufferDescriptorSize, nuint robustStorageTexelBufferDescriptorSize, nuint uniformBufferDescriptorSize, nuint robustUniformBufferDescriptorSize, nuint storageBufferDescriptorSize, nuint robustStorageBufferDescriptorSize, nuint inputAttachmentDescriptorSize, nuint accelerationStructureDescriptorSize, ulong maxSamplerDescriptorBufferRange, ulong maxResourceDescriptorBufferRange, ulong samplerDescriptorBufferAddressSpaceSize, ulong resourceDescriptorBufferAddressSpaceSize, ulong descriptorBufferAddressSpaceSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.combinedImageSamplerDescriptorSingleArray = combinedImageSamplerDescriptorSingleArray;
            this.bufferlessPushDescriptors = bufferlessPushDescriptors;
            this.allowSamplerImageViewPostSubmitCreation = allowSamplerImageViewPostSubmitCreation;
            this.descriptorBufferOffsetAlignment = descriptorBufferOffsetAlignment;
            this.maxDescriptorBufferBindings = maxDescriptorBufferBindings;
            this.maxResourceDescriptorBufferBindings = maxResourceDescriptorBufferBindings;
            this.maxSamplerDescriptorBufferBindings = maxSamplerDescriptorBufferBindings;
            this.maxEmbeddedImmutableSamplerBindings = maxEmbeddedImmutableSamplerBindings;
            this.maxEmbeddedImmutableSamplers = maxEmbeddedImmutableSamplers;
            this.bufferCaptureReplayDescriptorDataSize = bufferCaptureReplayDescriptorDataSize;
            this.imageCaptureReplayDescriptorDataSize = imageCaptureReplayDescriptorDataSize;
            this.imageViewCaptureReplayDescriptorDataSize = imageViewCaptureReplayDescriptorDataSize;
            this.samplerCaptureReplayDescriptorDataSize = samplerCaptureReplayDescriptorDataSize;
            this.accelerationStructureCaptureReplayDescriptorDataSize = accelerationStructureCaptureReplayDescriptorDataSize;
            this.samplerDescriptorSize = samplerDescriptorSize;
            this.combinedImageSamplerDescriptorSize = combinedImageSamplerDescriptorSize;
            this.sampledImageDescriptorSize = sampledImageDescriptorSize;
            this.storageImageDescriptorSize = storageImageDescriptorSize;
            this.uniformTexelBufferDescriptorSize = uniformTexelBufferDescriptorSize;
            this.robustUniformTexelBufferDescriptorSize = robustUniformTexelBufferDescriptorSize;
            this.storageTexelBufferDescriptorSize = storageTexelBufferDescriptorSize;
            this.robustStorageTexelBufferDescriptorSize = robustStorageTexelBufferDescriptorSize;
            this.uniformBufferDescriptorSize = uniformBufferDescriptorSize;
            this.robustUniformBufferDescriptorSize = robustUniformBufferDescriptorSize;
            this.storageBufferDescriptorSize = storageBufferDescriptorSize;
            this.robustStorageBufferDescriptorSize = robustStorageBufferDescriptorSize;
            this.inputAttachmentDescriptorSize = inputAttachmentDescriptorSize;
            this.accelerationStructureDescriptorSize = accelerationStructureDescriptorSize;
            this.maxSamplerDescriptorBufferRange = maxSamplerDescriptorBufferRange;
            this.maxResourceDescriptorBufferRange = maxResourceDescriptorBufferRange;
            this.samplerDescriptorBufferAddressSpaceSize = samplerDescriptorBufferAddressSpaceSize;
            this.resourceDescriptorBufferAddressSpaceSize = resourceDescriptorBufferAddressSpaceSize;
            this.descriptorBufferAddressSpaceSize = descriptorBufferAddressSpaceSize;
        }
    }
    public unsafe struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDescriptorBufferDensityMapPropertiesExt;
        public void* pNext;
        public nuint combinedImageSamplerDensityMapDescriptorSize;
        public VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT(VkStructureType sType, void* pNext, nuint combinedImageSamplerDensityMapDescriptorSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.combinedImageSamplerDensityMapDescriptorSize = combinedImageSamplerDensityMapDescriptorSize;
        }
    }
    public unsafe struct VkDescriptorAddressInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorAddressInfoExt;
        public void* pNext;
        public ulong address;
        public ulong range;
        public VkFormat format;
        public VkDescriptorAddressInfoEXT(VkStructureType sType, void* pNext, ulong address, ulong range, VkFormat format)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.address = address;
            this.range = range;
            this.format = format;
        }
    }
    public unsafe struct VkDescriptorBufferBindingInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorBufferBindingInfoExt;
        public void* pNext;
        public ulong address;
        public VkBufferUsageFlagBits usage;
        public VkDescriptorBufferBindingInfoEXT(VkStructureType sType, void* pNext, ulong address, VkBufferUsageFlagBits usage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.address = address;
            this.usage = usage;
        }
    }
    public unsafe struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorBufferBindingPushDescriptorBufferHandleExt;
        public void* pNext;
        public VkBuffer buffer;
        public VkDescriptorBufferBindingPushDescriptorBufferHandleEXT(VkStructureType sType, void* pNext, VkBuffer buffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.buffer = buffer;
        }
    }
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkDescriptorDataEXT
    {
        [FieldOffset(0)]
        public VkSampler* pSampler;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pCombinedImageSampler;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pInputAttachmentImage;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pSampledImage;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pStorageImage;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pUniformTexelBuffer;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pStorageTexelBuffer;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pUniformBuffer;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pStorageBuffer;
        [FieldOffset(0)]
        public ulong accelerationStructure;
    }
    public unsafe struct VkDescriptorGetInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorGetInfoExt;
        public void* pNext;
        public VkDescriptorType type;
        public VkDescriptorDataEXT data;
        public VkDescriptorGetInfoEXT(VkStructureType sType, void* pNext, VkDescriptorType type, VkDescriptorDataEXT data)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.type = type;
            this.data = data;
        }
    }
    public unsafe struct VkBufferCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferCaptureDescriptorDataInfoExt;
        public void* pNext;
        public VkBuffer buffer;
        public VkBufferCaptureDescriptorDataInfoEXT(VkStructureType sType, void* pNext, VkBuffer buffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.buffer = buffer;
        }
    }
    public unsafe struct VkImageCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageCaptureDescriptorDataInfoExt;
        public void* pNext;
        public VkImage image;
        public VkImageCaptureDescriptorDataInfoEXT(VkStructureType sType, void* pNext, VkImage image)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image = image;
        }
    }
    public unsafe struct VkImageViewCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageViewCaptureDescriptorDataInfoExt;
        public void* pNext;
        public VkImageView imageView;
        public VkImageViewCaptureDescriptorDataInfoEXT(VkStructureType sType, void* pNext, VkImageView imageView)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageView = imageView;
        }
    }
    public unsafe struct VkSamplerCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerCaptureDescriptorDataInfoExt;
        public void* pNext;
        public VkSampler sampler;
        public VkSamplerCaptureDescriptorDataInfoEXT(VkStructureType sType, void* pNext, VkSampler sampler)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.sampler = sampler;
        }
    }
    public unsafe struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureCaptureDescriptorDataInfoExt;
        public void* pNext;
        public VkAccelerationStructureKHR accelerationStructure;
        public VkAccelerationStructureNV accelerationStructureNV;
        public VkAccelerationStructureCaptureDescriptorDataInfoEXT(VkStructureType sType, void* pNext, VkAccelerationStructureKHR accelerationStructure, VkAccelerationStructureNV accelerationStructureNV)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.accelerationStructure = accelerationStructure;
            this.accelerationStructureNV = accelerationStructureNV;
        }
    }
    public unsafe struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeOpaqueCaptureDescriptorDataCreateInfoExt;
        public void* pNext;
        public void* opaqueCaptureDescriptorData;
        public VkOpaqueCaptureDescriptorDataCreateInfoEXT(VkStructureType sType, void* pNext, void* opaqueCaptureDescriptorData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.opaqueCaptureDescriptorData = opaqueCaptureDescriptorData;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderIntegerDotProductFeatures;
        public void* pNext;
        public int shaderIntegerDotProduct;
        public VkPhysicalDeviceShaderIntegerDotProductFeatures(VkStructureType sType, void* pNext, int shaderIntegerDotProduct)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderIntegerDotProduct = shaderIntegerDotProduct;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeaturesKHR
    {
        public VkPhysicalDeviceShaderIntegerDotProductFeaturesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerDotProductProperties
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderIntegerDotProductProperties;
        public void* pNext;
        public int integerDotProduct8BitUnsignedAccelerated;
        public int integerDotProduct8BitSignedAccelerated;
        public int integerDotProduct8BitMixedSignednessAccelerated;
        public int integerDotProduct4x8BitPackedUnsignedAccelerated;
        public int integerDotProduct4x8BitPackedSignedAccelerated;
        public int integerDotProduct4x8BitPackedMixedSignednessAccelerated;
        public int integerDotProduct16BitUnsignedAccelerated;
        public int integerDotProduct16BitSignedAccelerated;
        public int integerDotProduct16BitMixedSignednessAccelerated;
        public int integerDotProduct32BitUnsignedAccelerated;
        public int integerDotProduct32BitSignedAccelerated;
        public int integerDotProduct32BitMixedSignednessAccelerated;
        public int integerDotProduct64BitUnsignedAccelerated;
        public int integerDotProduct64BitSignedAccelerated;
        public int integerDotProduct64BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating8BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating16BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating32BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating64BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
        public VkPhysicalDeviceShaderIntegerDotProductProperties(VkStructureType sType, void* pNext, int integerDotProduct8BitUnsignedAccelerated, int integerDotProduct8BitSignedAccelerated, int integerDotProduct8BitMixedSignednessAccelerated, int integerDotProduct4x8BitPackedUnsignedAccelerated, int integerDotProduct4x8BitPackedSignedAccelerated, int integerDotProduct4x8BitPackedMixedSignednessAccelerated, int integerDotProduct16BitUnsignedAccelerated, int integerDotProduct16BitSignedAccelerated, int integerDotProduct16BitMixedSignednessAccelerated, int integerDotProduct32BitUnsignedAccelerated, int integerDotProduct32BitSignedAccelerated, int integerDotProduct32BitMixedSignednessAccelerated, int integerDotProduct64BitUnsignedAccelerated, int integerDotProduct64BitSignedAccelerated, int integerDotProduct64BitMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating8BitUnsignedAccelerated, int integerDotProductAccumulatingSaturating8BitSignedAccelerated, int integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated, int integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated, int integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating16BitUnsignedAccelerated, int integerDotProductAccumulatingSaturating16BitSignedAccelerated, int integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating32BitUnsignedAccelerated, int integerDotProductAccumulatingSaturating32BitSignedAccelerated, int integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated, int integerDotProductAccumulatingSaturating64BitUnsignedAccelerated, int integerDotProductAccumulatingSaturating64BitSignedAccelerated, int integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.integerDotProduct8BitUnsignedAccelerated = integerDotProduct8BitUnsignedAccelerated;
            this.integerDotProduct8BitSignedAccelerated = integerDotProduct8BitSignedAccelerated;
            this.integerDotProduct8BitMixedSignednessAccelerated = integerDotProduct8BitMixedSignednessAccelerated;
            this.integerDotProduct4x8BitPackedUnsignedAccelerated = integerDotProduct4x8BitPackedUnsignedAccelerated;
            this.integerDotProduct4x8BitPackedSignedAccelerated = integerDotProduct4x8BitPackedSignedAccelerated;
            this.integerDotProduct4x8BitPackedMixedSignednessAccelerated = integerDotProduct4x8BitPackedMixedSignednessAccelerated;
            this.integerDotProduct16BitUnsignedAccelerated = integerDotProduct16BitUnsignedAccelerated;
            this.integerDotProduct16BitSignedAccelerated = integerDotProduct16BitSignedAccelerated;
            this.integerDotProduct16BitMixedSignednessAccelerated = integerDotProduct16BitMixedSignednessAccelerated;
            this.integerDotProduct32BitUnsignedAccelerated = integerDotProduct32BitUnsignedAccelerated;
            this.integerDotProduct32BitSignedAccelerated = integerDotProduct32BitSignedAccelerated;
            this.integerDotProduct32BitMixedSignednessAccelerated = integerDotProduct32BitMixedSignednessAccelerated;
            this.integerDotProduct64BitUnsignedAccelerated = integerDotProduct64BitUnsignedAccelerated;
            this.integerDotProduct64BitSignedAccelerated = integerDotProduct64BitSignedAccelerated;
            this.integerDotProduct64BitMixedSignednessAccelerated = integerDotProduct64BitMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating8BitUnsignedAccelerated = integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating8BitSignedAccelerated = integerDotProductAccumulatingSaturating8BitSignedAccelerated;
            this.integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated = integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated = integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
            this.integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated = integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating16BitUnsignedAccelerated = integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating16BitSignedAccelerated = integerDotProductAccumulatingSaturating16BitSignedAccelerated;
            this.integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating32BitUnsignedAccelerated = integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating32BitSignedAccelerated = integerDotProductAccumulatingSaturating32BitSignedAccelerated;
            this.integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
            this.integerDotProductAccumulatingSaturating64BitUnsignedAccelerated = integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
            this.integerDotProductAccumulatingSaturating64BitSignedAccelerated = integerDotProductAccumulatingSaturating64BitSignedAccelerated;
            this.integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR
    {
        public VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDrmPropertiesExt;
        public void* pNext;
        public int hasPrimary;
        public int hasRender;
        public long primaryMajor;
        public long primaryMinor;
        public long renderMajor;
        public long renderMinor;
        public VkPhysicalDeviceDrmPropertiesEXT(VkStructureType sType, void* pNext, int hasPrimary, int hasRender, long primaryMajor, long primaryMinor, long renderMajor, long renderMinor)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.hasPrimary = hasPrimary;
            this.hasRender = hasRender;
            this.primaryMajor = primaryMajor;
            this.primaryMinor = primaryMinor;
            this.renderMajor = renderMajor;
            this.renderMinor = renderMinor;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentShaderBarycentricFeaturesKhr;
        public void* pNext;
        public int fragmentShaderBarycentric;
        public VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR(VkStructureType sType, void* pNext, int fragmentShaderBarycentric)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.fragmentShaderBarycentric = fragmentShaderBarycentric;
        }
    }
    public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFragmentShaderBarycentricPropertiesKhr;
        public void* pNext;
        public int triStripVertexOrderIndependentOfProvokingVertex;
        public VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR(VkStructureType sType, void* pNext, int triStripVertexOrderIndependentOfProvokingVertex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.triStripVertexOrderIndependentOfProvokingVertex = triStripVertexOrderIndependentOfProvokingVertex;
        }
    }
    public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayTracingMotionBlurFeaturesNv;
        public void* pNext;
        public int rayTracingMotionBlur;
        public int rayTracingMotionBlurPipelineTraceRaysIndirect;
        public VkPhysicalDeviceRayTracingMotionBlurFeaturesNV(VkStructureType sType, void* pNext, int rayTracingMotionBlur, int rayTracingMotionBlurPipelineTraceRaysIndirect)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rayTracingMotionBlur = rayTracingMotionBlur;
            this.rayTracingMotionBlurPipelineTraceRaysIndirect = rayTracingMotionBlurPipelineTraceRaysIndirect;
        }
    }
    public unsafe struct VkPhysicalDeviceRayTracingValidationFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayTracingValidationFeaturesNv;
        public void* pNext;
        public int rayTracingValidation;
        public VkPhysicalDeviceRayTracingValidationFeaturesNV(VkStructureType sType, void* pNext, int rayTracingValidation)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rayTracingValidation = rayTracingValidation;
        }
    }
    public unsafe struct VkAccelerationStructureGeometryMotionTrianglesDataNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureGeometryMotionTrianglesDataNv;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public VkAccelerationStructureGeometryMotionTrianglesDataNV(VkStructureType sType, void* pNext, VkDeviceOrHostAddressConstKHR vertexData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.vertexData = vertexData;
        }
    }
    public unsafe struct VkAccelerationStructureMotionInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureMotionInfoNv;
        public void* pNext;
        public uint maxInstances;
        public VkAccelerationStructureMotionInfoFlagsNV flags;
        public VkAccelerationStructureMotionInfoNV(VkStructureType sType, void* pNext, uint maxInstances, VkAccelerationStructureMotionInfoFlagsNV flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxInstances = maxInstances;
            this.flags = flags;
        }
    }
    public unsafe struct VkSRTDataNV
    {
        public float sx;
        public float a;
        public float b;
        public float pvx;
        public float sy;
        public float c;
        public float pvy;
        public float sz;
        public float pvz;
        public float qx;
        public float qy;
        public float qz;
        public float qw;
        public float tx;
        public float ty;
        public float tz;
        public VkSRTDataNV(float sx, float a, float b, float pvx, float sy, float c, float pvy, float sz, float pvz, float qx, float qy, float qz, float qw, float tx, float ty, float tz)
        {
            this.sx = sx;
            this.a = a;
            this.b = b;
            this.pvx = pvx;
            this.sy = sy;
            this.c = c;
            this.pvy = pvy;
            this.sz = sz;
            this.pvz = pvz;
            this.qx = qx;
            this.qy = qy;
            this.qz = qz;
            this.qw = qw;
            this.tx = tx;
            this.ty = ty;
            this.tz = tz;
        }
    }
    public unsafe struct VkAccelerationStructureSRTMotionInstanceNV
    {
        public VkSRTDataNV transformT0;
        public VkSRTDataNV transformT1;
        private uint _bitfield0;
         // TODO: Accessor property for instanceCustomIndex, size: 24, offset: 0
        public uint instanceCustomIndex
        {
            get => (uint)((_bitfield0 >> 0) & 0xFFFFFFu);
            set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFu << 0)) | ((((uint)value) & 0xFFFFFFu) << 0);
        }
         // TODO: Accessor property for mask, size: 8, offset: 24
        public uint mask
        {
            get => (uint)((_bitfield0 >> 24) & 0xFFu);
            set => _bitfield0 = (_bitfield0 & ~(0xFFu << 24)) | ((((uint)value) & 0xFFu) << 24);
        }
        private uint _bitfield1;
         // TODO: Accessor property for instanceShaderBindingTableRecordOffset, size: 24, offset: 0
        public uint instanceShaderBindingTableRecordOffset
        {
            get => (uint)((_bitfield1 >> 0) & 0xFFFFFFu);
            set => _bitfield1 = (_bitfield1 & ~(0xFFFFFFu << 0)) | ((((uint)value) & 0xFFFFFFu) << 0);
        }
         // TODO: Accessor property for flags, size: 8, offset: 24
        public VkGeometryInstanceFlagBitsKHR flags
        {
            get => (VkGeometryInstanceFlagBitsKHR)((_bitfield1 >> 24) & 0xFFu);
            set => _bitfield1 = (_bitfield1 & ~(0xFFu << 24)) | ((((uint)value) & 0xFFu) << 24);
        }
        public ulong accelerationStructureReference;
    }
    public unsafe struct VkAccelerationStructureMatrixMotionInstanceNV
    {
        public VkTransformMatrixKHR transformT0;
        public VkTransformMatrixKHR transformT1;
        private uint _bitfield0;
         // TODO: Accessor property for instanceCustomIndex, size: 24, offset: 0
        public uint instanceCustomIndex
        {
            get => (uint)((_bitfield0 >> 0) & 0xFFFFFFu);
            set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFu << 0)) | ((((uint)value) & 0xFFFFFFu) << 0);
        }
         // TODO: Accessor property for mask, size: 8, offset: 24
        public uint mask
        {
            get => (uint)((_bitfield0 >> 24) & 0xFFu);
            set => _bitfield0 = (_bitfield0 & ~(0xFFu << 24)) | ((((uint)value) & 0xFFu) << 24);
        }
        private uint _bitfield1;
         // TODO: Accessor property for instanceShaderBindingTableRecordOffset, size: 24, offset: 0
        public uint instanceShaderBindingTableRecordOffset
        {
            get => (uint)((_bitfield1 >> 0) & 0xFFFFFFu);
            set => _bitfield1 = (_bitfield1 & ~(0xFFFFFFu << 0)) | ((((uint)value) & 0xFFFFFFu) << 0);
        }
         // TODO: Accessor property for flags, size: 8, offset: 24
        public VkGeometryInstanceFlagBitsKHR flags
        {
            get => (VkGeometryInstanceFlagBitsKHR)((_bitfield1 >> 24) & 0xFFu);
            set => _bitfield1 = (_bitfield1 & ~(0xFFu << 24)) | ((((uint)value) & 0xFFu) << 24);
        }
        public ulong accelerationStructureReference;
    }
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkAccelerationStructureMotionInstanceDataNV
    {
        [FieldOffset(0)]
        public VkAccelerationStructureInstanceKHR staticInstance;
        [FieldOffset(0)]
        public VkAccelerationStructureMatrixMotionInstanceNV matrixMotionInstance;
        [FieldOffset(0)]
        public VkAccelerationStructureSRTMotionInstanceNV srtMotionInstance;
    }
    public unsafe struct VkAccelerationStructureMotionInstanceNV
    {
        public VkAccelerationStructureMotionInstanceTypeNV type;
        public VkAccelerationStructureMotionInstanceFlagsNV flags;
        public VkAccelerationStructureMotionInstanceDataNV data;
        public VkAccelerationStructureMotionInstanceNV(VkAccelerationStructureMotionInstanceTypeNV type, VkAccelerationStructureMotionInstanceFlagsNV flags, VkAccelerationStructureMotionInstanceDataNV data)
        {
            this.type = type;
            this.flags = flags;
            this.data = data;
        }
    }
    public unsafe struct VkMemoryGetRemoteAddressInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryGetRemoteAddressInfoNv;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public VkMemoryGetRemoteAddressInfoNV(VkStructureType sType, void* pNext, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagBits handleType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memory = memory;
            this.handleType = handleType;
        }
    }
    public unsafe struct VkImportMemoryBufferCollectionFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMemoryBufferCollectionFuchsia;
        public void* pNext;
        public VkBufferCollectionFUCHSIA collection;
        public uint index;
        public VkImportMemoryBufferCollectionFUCHSIA(VkStructureType sType, void* pNext, VkBufferCollectionFUCHSIA collection, uint index)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.collection = collection;
            this.index = index;
        }
    }
    public unsafe struct VkBufferCollectionImageCreateInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferCollectionImageCreateInfoFuchsia;
        public void* pNext;
        public VkBufferCollectionFUCHSIA collection;
        public uint index;
        public VkBufferCollectionImageCreateInfoFUCHSIA(VkStructureType sType, void* pNext, VkBufferCollectionFUCHSIA collection, uint index)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.collection = collection;
            this.index = index;
        }
    }
    public unsafe struct VkBufferCollectionBufferCreateInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferCollectionBufferCreateInfoFuchsia;
        public void* pNext;
        public VkBufferCollectionFUCHSIA collection;
        public uint index;
        public VkBufferCollectionBufferCreateInfoFUCHSIA(VkStructureType sType, void* pNext, VkBufferCollectionFUCHSIA collection, uint index)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.collection = collection;
            this.index = index;
        }
    }
    public unsafe struct VkBufferCollectionCreateInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferCollectionCreateInfoFuchsia;
        public void* pNext;
        public int collectionToken;
        public VkBufferCollectionCreateInfoFUCHSIA(VkStructureType sType, void* pNext, int collectionToken)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.collectionToken = collectionToken;
        }
    }
    public unsafe struct VkBufferCollectionPropertiesFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferCollectionPropertiesFuchsia;
        public void* pNext;
        public uint memoryTypeBits;
        public uint bufferCount;
        public uint createInfoIndex;
        public ulong sysmemPixelFormat;
        public VkFormatFeatureFlagBits formatFeatures;
        public VkSysmemColorSpaceFUCHSIA sysmemColorSpaceIndex;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
        public VkBufferCollectionPropertiesFUCHSIA(VkStructureType sType, void* pNext, uint memoryTypeBits, uint bufferCount, uint createInfoIndex, ulong sysmemPixelFormat, VkFormatFeatureFlagBits formatFeatures, VkSysmemColorSpaceFUCHSIA sysmemColorSpaceIndex, VkComponentMapping samplerYcbcrConversionComponents, VkSamplerYcbcrModelConversion suggestedYcbcrModel, VkSamplerYcbcrRange suggestedYcbcrRange, VkChromaLocation suggestedXChromaOffset, VkChromaLocation suggestedYChromaOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryTypeBits = memoryTypeBits;
            this.bufferCount = bufferCount;
            this.createInfoIndex = createInfoIndex;
            this.sysmemPixelFormat = sysmemPixelFormat;
            this.formatFeatures = formatFeatures;
            this.sysmemColorSpaceIndex = sysmemColorSpaceIndex;
            this.samplerYcbcrConversionComponents = samplerYcbcrConversionComponents;
            this.suggestedYcbcrModel = suggestedYcbcrModel;
            this.suggestedYcbcrRange = suggestedYcbcrRange;
            this.suggestedXChromaOffset = suggestedXChromaOffset;
            this.suggestedYChromaOffset = suggestedYChromaOffset;
        }
    }
    public unsafe struct VkBufferConstraintsInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferConstraintsInfoFuchsia;
        public void* pNext;
        public VkBufferCreateInfo createInfo;
        public VkFormatFeatureFlagBits requiredFormatFeatures;
        public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
        public VkBufferConstraintsInfoFUCHSIA(VkStructureType sType, void* pNext, VkBufferCreateInfo createInfo, VkFormatFeatureFlagBits requiredFormatFeatures, VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.createInfo = createInfo;
            this.requiredFormatFeatures = requiredFormatFeatures;
            this.bufferCollectionConstraints = bufferCollectionConstraints;
        }
    }
    public unsafe struct VkSysmemColorSpaceFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeSysmemColorSpaceFuchsia;
        public void* pNext;
        public uint colorSpace;
        public VkSysmemColorSpaceFUCHSIA(VkStructureType sType, void* pNext, uint colorSpace)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.colorSpace = colorSpace;
        }
    }
    public unsafe struct VkImageFormatConstraintsInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageFormatConstraintsInfoFuchsia;
        public void* pNext;
        public VkImageCreateInfo imageCreateInfo;
        public VkFormatFeatureFlagBits requiredFormatFeatures;
        public VkImageFormatConstraintsFlagsFUCHSIA flags;
        public ulong sysmemPixelFormat;
        public uint colorSpaceCount;
        public VkSysmemColorSpaceFUCHSIA* pColorSpaces;
        public VkImageFormatConstraintsInfoFUCHSIA(VkStructureType sType, void* pNext, VkImageCreateInfo imageCreateInfo, VkFormatFeatureFlagBits requiredFormatFeatures, VkImageFormatConstraintsFlagsFUCHSIA flags, ulong sysmemPixelFormat, uint colorSpaceCount, VkSysmemColorSpaceFUCHSIA* pColorSpaces)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageCreateInfo = imageCreateInfo;
            this.requiredFormatFeatures = requiredFormatFeatures;
            this.flags = flags;
            this.sysmemPixelFormat = sysmemPixelFormat;
            this.colorSpaceCount = colorSpaceCount;
            this.pColorSpaces = pColorSpaces;
        }
    }
    public unsafe struct VkImageConstraintsInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageConstraintsInfoFuchsia;
        public void* pNext;
        public uint formatConstraintsCount;
        public VkImageFormatConstraintsInfoFUCHSIA* pFormatConstraints;
        public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
        public VkImageConstraintsInfoFlagBitsFUCHSIA flags;
        public VkImageConstraintsInfoFUCHSIA(VkStructureType sType, void* pNext, uint formatConstraintsCount, VkImageFormatConstraintsInfoFUCHSIA* pFormatConstraints, VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints, VkImageConstraintsInfoFlagBitsFUCHSIA flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.formatConstraintsCount = formatConstraintsCount;
            this.pFormatConstraints = pFormatConstraints;
            this.bufferCollectionConstraints = bufferCollectionConstraints;
            this.flags = flags;
        }
    }
    public unsafe struct VkBufferCollectionConstraintsInfoFUCHSIA
    {
        public VkStructureType sType = VkStructureType.StructureTypeBufferCollectionConstraintsInfoFuchsia;
        public void* pNext;
        public uint minBufferCount;
        public uint maxBufferCount;
        public uint minBufferCountForCamping;
        public uint minBufferCountForDedicatedSlack;
        public uint minBufferCountForSharedSlack;
        public VkBufferCollectionConstraintsInfoFUCHSIA(VkStructureType sType, void* pNext, uint minBufferCount, uint maxBufferCount, uint minBufferCountForCamping, uint minBufferCountForDedicatedSlack, uint minBufferCountForSharedSlack)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minBufferCount = minBufferCount;
            this.maxBufferCount = maxBufferCount;
            this.minBufferCountForCamping = minBufferCountForCamping;
            this.minBufferCountForDedicatedSlack = minBufferCountForDedicatedSlack;
            this.minBufferCountForSharedSlack = minBufferCountForSharedSlack;
        }
    }
    public unsafe struct VkCudaModuleCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeCudaModuleCreateInfoNv;
        public void* pNext;
        public nuint dataSize;
        public void* pData;
        public VkCudaModuleCreateInfoNV(VkStructureType sType, void* pNext, nuint dataSize, void* pData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dataSize = dataSize;
            this.pData = pData;
        }
    }
    public unsafe struct VkCudaFunctionCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeCudaFunctionCreateInfoNv;
        public void* pNext;
        public VkCudaModuleNV module;
        public byte* pName;
        public VkCudaFunctionCreateInfoNV(VkStructureType sType, void* pNext, VkCudaModuleNV module, byte* pName)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.module = module;
            this.pName = pName;
        }
    }
    public unsafe struct VkCudaLaunchInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeCudaLaunchInfoNv;
        public void* pNext;
        public VkCudaFunctionNV function;
        public uint gridDimX;
        public uint gridDimY;
        public uint gridDimZ;
        public uint blockDimX;
        public uint blockDimY;
        public uint blockDimZ;
        public uint sharedMemBytes;
        public nuint paramCount;
        public void** pParams;
        public nuint extraCount;
        public void** pExtras;
        public VkCudaLaunchInfoNV(VkStructureType sType, void* pNext, VkCudaFunctionNV function, uint gridDimX, uint gridDimY, uint gridDimZ, uint blockDimX, uint blockDimY, uint blockDimZ, uint sharedMemBytes, nuint paramCount, void** pParams, nuint extraCount, void** pExtras)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.function = function;
            this.gridDimX = gridDimX;
            this.gridDimY = gridDimY;
            this.gridDimZ = gridDimZ;
            this.blockDimX = blockDimX;
            this.blockDimY = blockDimY;
            this.blockDimZ = blockDimZ;
            this.sharedMemBytes = sharedMemBytes;
            this.paramCount = paramCount;
            this.pParams = pParams;
            this.extraCount = extraCount;
            this.pExtras = pExtras;
        }
    }
    public unsafe struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRgba10x6FormatsFeaturesExt;
        public void* pNext;
        public int formatRgba10x6WithoutYCbCrSampler;
        public VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT(VkStructureType sType, void* pNext, int formatRgba10x6WithoutYCbCrSampler)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.formatRgba10x6WithoutYCbCrSampler = formatRgba10x6WithoutYCbCrSampler;
        }
    }
    public unsafe struct VkFormatProperties3
    {
        public VkStructureType sType = VkStructureType.StructureTypeFormatProperties3;
        public void* pNext;
        public VkFormatFeatureFlagBits2 linearTilingFeatures;
        public VkFormatFeatureFlagBits2 optimalTilingFeatures;
        public VkFormatFeatureFlagBits2 bufferFeatures;
        public VkFormatProperties3(VkStructureType sType, void* pNext, VkFormatFeatureFlagBits2 linearTilingFeatures, VkFormatFeatureFlagBits2 optimalTilingFeatures, VkFormatFeatureFlagBits2 bufferFeatures)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.linearTilingFeatures = linearTilingFeatures;
            this.optimalTilingFeatures = optimalTilingFeatures;
            this.bufferFeatures = bufferFeatures;
        }
    }
    public unsafe struct VkFormatProperties3KHR
    {
        public VkFormatProperties3KHR()
        {
        }
    }
    public unsafe struct VkDrmFormatModifierPropertiesList2EXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDrmFormatModifierPropertiesList2Ext;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
        public VkDrmFormatModifierPropertiesList2EXT(VkStructureType sType, void* pNext, uint drmFormatModifierCount, VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.drmFormatModifierCount = drmFormatModifierCount;
            this.pDrmFormatModifierProperties = pDrmFormatModifierProperties;
        }
    }
    public unsafe struct VkDrmFormatModifierProperties2EXT
    {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkFormatFeatureFlagBits2 drmFormatModifierTilingFeatures;
        public VkDrmFormatModifierProperties2EXT(ulong drmFormatModifier, uint drmFormatModifierPlaneCount, VkFormatFeatureFlagBits2 drmFormatModifierTilingFeatures)
        {
            this.drmFormatModifier = drmFormatModifier;
            this.drmFormatModifierPlaneCount = drmFormatModifierPlaneCount;
            this.drmFormatModifierTilingFeatures = drmFormatModifierTilingFeatures;
        }
    }
    public unsafe struct VkAndroidHardwareBufferFormatProperties2ANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypeAndroidHardwareBufferFormatProperties2Android;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public VkFormatFeatureFlagBits2 formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
        public VkAndroidHardwareBufferFormatProperties2ANDROID(VkStructureType sType, void* pNext, VkFormat format, ulong externalFormat, VkFormatFeatureFlagBits2 formatFeatures, VkComponentMapping samplerYcbcrConversionComponents, VkSamplerYcbcrModelConversion suggestedYcbcrModel, VkSamplerYcbcrRange suggestedYcbcrRange, VkChromaLocation suggestedXChromaOffset, VkChromaLocation suggestedYChromaOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.format = format;
            this.externalFormat = externalFormat;
            this.formatFeatures = formatFeatures;
            this.samplerYcbcrConversionComponents = samplerYcbcrConversionComponents;
            this.suggestedYcbcrModel = suggestedYcbcrModel;
            this.suggestedYcbcrRange = suggestedYcbcrRange;
            this.suggestedXChromaOffset = suggestedXChromaOffset;
            this.suggestedYChromaOffset = suggestedYChromaOffset;
        }
    }
    public unsafe struct VkPipelineRenderingCreateInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRenderingCreateInfo;
        public void* pNext;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
        public VkPipelineRenderingCreateInfo(VkStructureType sType, void* pNext, uint viewMask, uint colorAttachmentCount, VkFormat* pColorAttachmentFormats, VkFormat depthAttachmentFormat, VkFormat stencilAttachmentFormat)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.viewMask = viewMask;
            this.colorAttachmentCount = colorAttachmentCount;
            this.pColorAttachmentFormats = pColorAttachmentFormats;
            this.depthAttachmentFormat = depthAttachmentFormat;
            this.stencilAttachmentFormat = stencilAttachmentFormat;
        }
    }
    public unsafe struct VkPipelineRenderingCreateInfoKHR
    {
        public VkPipelineRenderingCreateInfoKHR()
        {
        }
    }
    public unsafe struct VkRenderingInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderingInfo;
        public void* pNext;
        public VkRenderingFlagBits flags;
        public VkRect2D renderArea;
        public uint layerCount;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkRenderingAttachmentInfo* pColorAttachments;
        public VkRenderingAttachmentInfo* pDepthAttachment;
        public VkRenderingAttachmentInfo* pStencilAttachment;
        public VkRenderingInfo(VkStructureType sType, void* pNext, VkRenderingFlagBits flags, VkRect2D renderArea, uint layerCount, uint viewMask, uint colorAttachmentCount, VkRenderingAttachmentInfo* pColorAttachments, VkRenderingAttachmentInfo* pDepthAttachment, VkRenderingAttachmentInfo* pStencilAttachment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.renderArea = renderArea;
            this.layerCount = layerCount;
            this.viewMask = viewMask;
            this.colorAttachmentCount = colorAttachmentCount;
            this.pColorAttachments = pColorAttachments;
            this.pDepthAttachment = pDepthAttachment;
            this.pStencilAttachment = pStencilAttachment;
        }
    }
    public unsafe struct VkRenderingInfoKHR
    {
        public VkRenderingInfoKHR()
        {
        }
    }
    public unsafe struct VkRenderingAttachmentInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderingAttachmentInfo;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public VkResolveModeFlagBits resolveMode;
        public VkImageView resolveImageView;
        public VkImageLayout resolveImageLayout;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkClearValue clearValue;
        public VkRenderingAttachmentInfo(VkStructureType sType, void* pNext, VkImageView imageView, VkImageLayout imageLayout, VkResolveModeFlagBits resolveMode, VkImageView resolveImageView, VkImageLayout resolveImageLayout, VkAttachmentLoadOp loadOp, VkAttachmentStoreOp storeOp, VkClearValue clearValue)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageView = imageView;
            this.imageLayout = imageLayout;
            this.resolveMode = resolveMode;
            this.resolveImageView = resolveImageView;
            this.resolveImageLayout = resolveImageLayout;
            this.loadOp = loadOp;
            this.storeOp = storeOp;
            this.clearValue = clearValue;
        }
    }
    public unsafe struct VkRenderingAttachmentInfoKHR
    {
        public VkRenderingAttachmentInfoKHR()
        {
        }
    }
    public unsafe struct VkRenderingFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderingFragmentShadingRateAttachmentInfoKhr;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public VkExtent2D shadingRateAttachmentTexelSize;
        public VkRenderingFragmentShadingRateAttachmentInfoKHR(VkStructureType sType, void* pNext, VkImageView imageView, VkImageLayout imageLayout, VkExtent2D shadingRateAttachmentTexelSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageView = imageView;
            this.imageLayout = imageLayout;
            this.shadingRateAttachmentTexelSize = shadingRateAttachmentTexelSize;
        }
    }
    public unsafe struct VkRenderingFragmentDensityMapAttachmentInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderingFragmentDensityMapAttachmentInfoExt;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public VkRenderingFragmentDensityMapAttachmentInfoEXT(VkStructureType sType, void* pNext, VkImageView imageView, VkImageLayout imageLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageView = imageView;
            this.imageLayout = imageLayout;
        }
    }
    public unsafe struct VkPhysicalDeviceDynamicRenderingFeatures
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDynamicRenderingFeatures;
        public void* pNext;
        public int dynamicRendering;
        public VkPhysicalDeviceDynamicRenderingFeatures(VkStructureType sType, void* pNext, int dynamicRendering)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dynamicRendering = dynamicRendering;
        }
    }
    public unsafe struct VkPhysicalDeviceDynamicRenderingFeaturesKHR
    {
        public VkPhysicalDeviceDynamicRenderingFeaturesKHR()
        {
        }
    }
    public unsafe struct VkCommandBufferInheritanceRenderingInfo
    {
        public VkStructureType sType = VkStructureType.StructureTypeCommandBufferInheritanceRenderingInfo;
        public void* pNext;
        public VkRenderingFlagBits flags;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
        public VkSampleCountFlagBits rasterizationSamples;
        public VkCommandBufferInheritanceRenderingInfo(VkStructureType sType, void* pNext, VkRenderingFlagBits flags, uint viewMask, uint colorAttachmentCount, VkFormat* pColorAttachmentFormats, VkFormat depthAttachmentFormat, VkFormat stencilAttachmentFormat, VkSampleCountFlagBits rasterizationSamples)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.viewMask = viewMask;
            this.colorAttachmentCount = colorAttachmentCount;
            this.pColorAttachmentFormats = pColorAttachmentFormats;
            this.depthAttachmentFormat = depthAttachmentFormat;
            this.stencilAttachmentFormat = stencilAttachmentFormat;
            this.rasterizationSamples = rasterizationSamples;
        }
    }
    public unsafe struct VkCommandBufferInheritanceRenderingInfoKHR
    {
        public VkCommandBufferInheritanceRenderingInfoKHR()
        {
        }
    }
    public unsafe struct VkAttachmentSampleCountInfoAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypeAttachmentSampleCountInfoAmd;
        public void* pNext;
        public uint colorAttachmentCount;
        public VkSampleCountFlagBits* pColorAttachmentSamples;
        public VkSampleCountFlagBits depthStencilAttachmentSamples;
        public VkAttachmentSampleCountInfoAMD(VkStructureType sType, void* pNext, uint colorAttachmentCount, VkSampleCountFlagBits* pColorAttachmentSamples, VkSampleCountFlagBits depthStencilAttachmentSamples)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.colorAttachmentCount = colorAttachmentCount;
            this.pColorAttachmentSamples = pColorAttachmentSamples;
            this.depthStencilAttachmentSamples = depthStencilAttachmentSamples;
        }
    }
    public unsafe struct VkAttachmentSampleCountInfoNV
    {
        public VkAttachmentSampleCountInfoNV()
        {
        }
    }
    public unsafe struct VkMultiviewPerViewAttributesInfoNVX
    {
        public VkStructureType sType = VkStructureType.StructureTypeMultiviewPerViewAttributesInfoNvx;
        public void* pNext;
        public int perViewAttributes;
        public int perViewAttributesPositionXOnly;
        public VkMultiviewPerViewAttributesInfoNVX(VkStructureType sType, void* pNext, int perViewAttributes, int perViewAttributesPositionXOnly)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.perViewAttributes = perViewAttributes;
            this.perViewAttributesPositionXOnly = perViewAttributesPositionXOnly;
        }
    }
    public unsafe struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageViewMinLodFeaturesExt;
        public void* pNext;
        public int minLod;
        public VkPhysicalDeviceImageViewMinLodFeaturesEXT(VkStructureType sType, void* pNext, int minLod)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minLod = minLod;
        }
    }
    public unsafe struct VkImageViewMinLodCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageViewMinLodCreateInfoExt;
        public void* pNext;
        public float minLod;
        public VkImageViewMinLodCreateInfoEXT(VkStructureType sType, void* pNext, float minLod)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minLod = minLod;
        }
    }
    public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRasterizationOrderAttachmentAccessFeaturesExt;
        public void* pNext;
        public int rasterizationOrderColorAttachmentAccess;
        public int rasterizationOrderDepthAttachmentAccess;
        public int rasterizationOrderStencilAttachmentAccess;
        public VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT(VkStructureType sType, void* pNext, int rasterizationOrderColorAttachmentAccess, int rasterizationOrderDepthAttachmentAccess, int rasterizationOrderStencilAttachmentAccess)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rasterizationOrderColorAttachmentAccess = rasterizationOrderColorAttachmentAccess;
            this.rasterizationOrderDepthAttachmentAccess = rasterizationOrderDepthAttachmentAccess;
            this.rasterizationOrderStencilAttachmentAccess = rasterizationOrderStencilAttachmentAccess;
        }
    }
    public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
    {
        public VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM()
        {
        }
    }
    public unsafe struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLinearColorAttachmentFeaturesNv;
        public void* pNext;
        public int linearColorAttachment;
        public VkPhysicalDeviceLinearColorAttachmentFeaturesNV(VkStructureType sType, void* pNext, int linearColorAttachment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.linearColorAttachment = linearColorAttachment;
        }
    }
    public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceGraphicsPipelineLibraryFeaturesExt;
        public void* pNext;
        public int graphicsPipelineLibrary;
        public VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT(VkStructureType sType, void* pNext, int graphicsPipelineLibrary)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.graphicsPipelineLibrary = graphicsPipelineLibrary;
        }
    }
    public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceGraphicsPipelineLibraryPropertiesExt;
        public void* pNext;
        public int graphicsPipelineLibraryFastLinking;
        public int graphicsPipelineLibraryIndependentInterpolationDecoration;
        public VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT(VkStructureType sType, void* pNext, int graphicsPipelineLibraryFastLinking, int graphicsPipelineLibraryIndependentInterpolationDecoration)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.graphicsPipelineLibraryFastLinking = graphicsPipelineLibraryFastLinking;
            this.graphicsPipelineLibraryIndependentInterpolationDecoration = graphicsPipelineLibraryIndependentInterpolationDecoration;
        }
    }
    public unsafe struct VkGraphicsPipelineLibraryCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeGraphicsPipelineLibraryCreateInfoExt;
        public void* pNext;
        public VkGraphicsPipelineLibraryFlagBitsEXT flags;
        public VkGraphicsPipelineLibraryCreateInfoEXT(VkStructureType sType, void* pNext, VkGraphicsPipelineLibraryFlagBitsEXT flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
        }
    }
    public unsafe struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDescriptorSetHostMappingFeaturesValve;
        public void* pNext;
        public int descriptorSetHostMapping;
        public VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE(VkStructureType sType, void* pNext, int descriptorSetHostMapping)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.descriptorSetHostMapping = descriptorSetHostMapping;
        }
    }
    public unsafe struct VkDescriptorSetBindingReferenceVALVE
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorSetBindingReferenceValve;
        public void* pNext;
        public VkDescriptorSetLayout descriptorSetLayout;
        public uint binding;
        public VkDescriptorSetBindingReferenceVALVE(VkStructureType sType, void* pNext, VkDescriptorSetLayout descriptorSetLayout, uint binding)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.descriptorSetLayout = descriptorSetLayout;
            this.binding = binding;
        }
    }
    public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
    {
        public VkStructureType sType = VkStructureType.StructureTypeDescriptorSetLayoutHostMappingInfoValve;
        public void* pNext;
        public nuint descriptorOffset;
        public uint descriptorSize;
        public VkDescriptorSetLayoutHostMappingInfoVALVE(VkStructureType sType, void* pNext, nuint descriptorOffset, uint descriptorSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.descriptorOffset = descriptorOffset;
            this.descriptorSize = descriptorSize;
        }
    }
    public unsafe struct VkPhysicalDeviceNestedCommandBufferFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceNestedCommandBufferFeaturesExt;
        public void* pNext;
        public int nestedCommandBuffer;
        public int nestedCommandBufferRendering;
        public int nestedCommandBufferSimultaneousUse;
        public VkPhysicalDeviceNestedCommandBufferFeaturesEXT(VkStructureType sType, void* pNext, int nestedCommandBuffer, int nestedCommandBufferRendering, int nestedCommandBufferSimultaneousUse)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.nestedCommandBuffer = nestedCommandBuffer;
            this.nestedCommandBufferRendering = nestedCommandBufferRendering;
            this.nestedCommandBufferSimultaneousUse = nestedCommandBufferSimultaneousUse;
        }
    }
    public unsafe struct VkPhysicalDeviceNestedCommandBufferPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceNestedCommandBufferPropertiesExt;
        public void* pNext;
        public uint maxCommandBufferNestingLevel;
        public VkPhysicalDeviceNestedCommandBufferPropertiesEXT(VkStructureType sType, void* pNext, uint maxCommandBufferNestingLevel)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxCommandBufferNestingLevel = maxCommandBufferNestingLevel;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderModuleIdentifierFeaturesExt;
        public void* pNext;
        public int shaderModuleIdentifier;
        public VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT(VkStructureType sType, void* pNext, int shaderModuleIdentifier)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderModuleIdentifier = shaderModuleIdentifier;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderModuleIdentifierPropertiesExt;
        public void* pNext;
        public fixed byte shaderModuleIdentifierAlgorithmUUID[16];
        public VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT(){ }
    }
    public unsafe struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineShaderStageModuleIdentifierCreateInfoExt;
        public void* pNext;
        public uint identifierSize;
        public byte* pIdentifier;
        public VkPipelineShaderStageModuleIdentifierCreateInfoEXT(VkStructureType sType, void* pNext, uint identifierSize, byte* pIdentifier)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.identifierSize = identifierSize;
            this.pIdentifier = pIdentifier;
        }
    }
    public unsafe struct VkShaderModuleIdentifierEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeShaderModuleIdentifierExt;
        public void* pNext;
        public uint identifierSize;
        public fixed byte identifier[32];
        public VkShaderModuleIdentifierEXT(){ }
    }
    public unsafe struct VkImageCompressionControlEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageCompressionControlExt;
        public void* pNext;
        public VkImageCompressionFlagBitsEXT flags;
        public uint compressionControlPlaneCount;
        public VkImageCompressionFixedRateFlagBitsEXT* pFixedRateFlags;
        public VkImageCompressionControlEXT(VkStructureType sType, void* pNext, VkImageCompressionFlagBitsEXT flags, uint compressionControlPlaneCount, VkImageCompressionFixedRateFlagBitsEXT* pFixedRateFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.compressionControlPlaneCount = compressionControlPlaneCount;
            this.pFixedRateFlags = pFixedRateFlags;
        }
    }
    public unsafe struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageCompressionControlFeaturesExt;
        public void* pNext;
        public int imageCompressionControl;
        public VkPhysicalDeviceImageCompressionControlFeaturesEXT(VkStructureType sType, void* pNext, int imageCompressionControl)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageCompressionControl = imageCompressionControl;
        }
    }
    public unsafe struct VkImageCompressionPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageCompressionPropertiesExt;
        public void* pNext;
        public VkImageCompressionFlagBitsEXT imageCompressionFlags;
        public VkImageCompressionFixedRateFlagBitsEXT imageCompressionFixedRateFlags;
        public VkImageCompressionPropertiesEXT(VkStructureType sType, void* pNext, VkImageCompressionFlagBitsEXT imageCompressionFlags, VkImageCompressionFixedRateFlagBitsEXT imageCompressionFixedRateFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageCompressionFlags = imageCompressionFlags;
            this.imageCompressionFixedRateFlags = imageCompressionFixedRateFlags;
        }
    }
    public unsafe struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageCompressionControlSwapchainFeaturesExt;
        public void* pNext;
        public int imageCompressionControlSwapchain;
        public VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT(VkStructureType sType, void* pNext, int imageCompressionControlSwapchain)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageCompressionControlSwapchain = imageCompressionControlSwapchain;
        }
    }
    public unsafe struct VkImageSubresource2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageSubresource2Khr;
        public void* pNext;
        public VkImageSubresource imageSubresource;
        public VkImageSubresource2KHR(VkStructureType sType, void* pNext, VkImageSubresource imageSubresource)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageSubresource = imageSubresource;
        }
    }
    public unsafe struct VkImageSubresource2EXT
    {
        public VkImageSubresource2EXT()
        {
        }
    }
    public unsafe struct VkSubresourceLayout2KHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeSubresourceLayout2Khr;
        public void* pNext;
        public VkSubresourceLayout subresourceLayout;
        public VkSubresourceLayout2KHR(VkStructureType sType, void* pNext, VkSubresourceLayout subresourceLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.subresourceLayout = subresourceLayout;
        }
    }
    public unsafe struct VkSubresourceLayout2EXT
    {
        public VkSubresourceLayout2EXT()
        {
        }
    }
    public unsafe struct VkRenderPassCreationControlEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassCreationControlExt;
        public void* pNext;
        public int disallowMerging;
        public VkRenderPassCreationControlEXT(VkStructureType sType, void* pNext, int disallowMerging)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.disallowMerging = disallowMerging;
        }
    }
    public unsafe struct VkRenderPassCreationFeedbackInfoEXT
    {
        public uint postMergeSubpassCount;
        public VkRenderPassCreationFeedbackInfoEXT(uint postMergeSubpassCount)
        {
            this.postMergeSubpassCount = postMergeSubpassCount;
        }
    }
    public unsafe struct VkRenderPassCreationFeedbackCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassCreationFeedbackCreateInfoExt;
        public void* pNext;
        public VkRenderPassCreationFeedbackInfoEXT* pRenderPassFeedback;
        public VkRenderPassCreationFeedbackCreateInfoEXT(VkStructureType sType, void* pNext, VkRenderPassCreationFeedbackInfoEXT* pRenderPassFeedback)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pRenderPassFeedback = pRenderPassFeedback;
        }
    }
    public unsafe struct VkRenderPassSubpassFeedbackInfoEXT
    {
        public VkSubpassMergeStatusEXT subpassMergeStatus;
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
        public uint postMergeIndex;
    }
    public unsafe struct VkRenderPassSubpassFeedbackCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassSubpassFeedbackCreateInfoExt;
        public void* pNext;
        public VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback;
        public VkRenderPassSubpassFeedbackCreateInfoEXT(VkStructureType sType, void* pNext, VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pSubpassFeedback = pSubpassFeedback;
        }
    }
    public unsafe struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSubpassMergeFeedbackFeaturesExt;
        public void* pNext;
        public int subpassMergeFeedback;
        public VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT(VkStructureType sType, void* pNext, int subpassMergeFeedback)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.subpassMergeFeedback = subpassMergeFeedback;
        }
    }
    public unsafe struct VkMicromapBuildInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMicromapBuildInfoExt;
        public void* pNext;
        public VkMicromapTypeEXT type;
        public VkBuildMicromapFlagBitsEXT flags;
        public VkBuildMicromapModeEXT mode;
        public VkMicromapEXT dstMicromap;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkDeviceOrHostAddressConstKHR data;
        public VkDeviceOrHostAddressKHR scratchData;
        public VkDeviceOrHostAddressConstKHR triangleArray;
        public ulong triangleArrayStride;
        public VkMicromapBuildInfoEXT(VkStructureType sType, void* pNext, VkMicromapTypeEXT type, VkBuildMicromapFlagBitsEXT flags, VkBuildMicromapModeEXT mode, VkMicromapEXT dstMicromap, uint usageCountsCount, VkMicromapUsageEXT* pUsageCounts, VkMicromapUsageEXT** ppUsageCounts, VkDeviceOrHostAddressConstKHR data, VkDeviceOrHostAddressKHR scratchData, VkDeviceOrHostAddressConstKHR triangleArray, ulong triangleArrayStride)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.type = type;
            this.flags = flags;
            this.mode = mode;
            this.dstMicromap = dstMicromap;
            this.usageCountsCount = usageCountsCount;
            this.pUsageCounts = pUsageCounts;
            this.ppUsageCounts = ppUsageCounts;
            this.data = data;
            this.scratchData = scratchData;
            this.triangleArray = triangleArray;
            this.triangleArrayStride = triangleArrayStride;
        }
    }
    public unsafe struct VkMicromapCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMicromapCreateInfoExt;
        public void* pNext;
        public VkMicromapCreateFlagBitsEXT createFlags;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public VkMicromapTypeEXT type;
        public ulong deviceAddress;
        public VkMicromapCreateInfoEXT(VkStructureType sType, void* pNext, VkMicromapCreateFlagBitsEXT createFlags, VkBuffer buffer, ulong offset, ulong size, VkMicromapTypeEXT type, ulong deviceAddress)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.createFlags = createFlags;
            this.buffer = buffer;
            this.offset = offset;
            this.size = size;
            this.type = type;
            this.deviceAddress = deviceAddress;
        }
    }
    public unsafe struct VkMicromapVersionInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMicromapVersionInfoExt;
        public void* pNext;
        public byte* pVersionData;
        public VkMicromapVersionInfoEXT(VkStructureType sType, void* pNext, byte* pVersionData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pVersionData = pVersionData;
        }
    }
    public unsafe struct VkCopyMicromapInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyMicromapInfoExt;
        public void* pNext;
        public VkMicromapEXT src;
        public VkMicromapEXT dst;
        public VkCopyMicromapModeEXT mode;
        public VkCopyMicromapInfoEXT(VkStructureType sType, void* pNext, VkMicromapEXT src, VkMicromapEXT dst, VkCopyMicromapModeEXT mode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.src = src;
            this.dst = dst;
            this.mode = mode;
        }
    }
    public unsafe struct VkCopyMicromapToMemoryInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyMicromapToMemoryInfoExt;
        public void* pNext;
        public VkMicromapEXT src;
        public VkDeviceOrHostAddressKHR dst;
        public VkCopyMicromapModeEXT mode;
        public VkCopyMicromapToMemoryInfoEXT(VkStructureType sType, void* pNext, VkMicromapEXT src, VkDeviceOrHostAddressKHR dst, VkCopyMicromapModeEXT mode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.src = src;
            this.dst = dst;
            this.mode = mode;
        }
    }
    public unsafe struct VkCopyMemoryToMicromapInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeCopyMemoryToMicromapInfoExt;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR src;
        public VkMicromapEXT dst;
        public VkCopyMicromapModeEXT mode;
        public VkCopyMemoryToMicromapInfoEXT(VkStructureType sType, void* pNext, VkDeviceOrHostAddressConstKHR src, VkMicromapEXT dst, VkCopyMicromapModeEXT mode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.src = src;
            this.dst = dst;
            this.mode = mode;
        }
    }
    public unsafe struct VkMicromapBuildSizesInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMicromapBuildSizesInfoExt;
        public void* pNext;
        public ulong micromapSize;
        public ulong buildScratchSize;
        public int discardable;
        public VkMicromapBuildSizesInfoEXT(VkStructureType sType, void* pNext, ulong micromapSize, ulong buildScratchSize, int discardable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.micromapSize = micromapSize;
            this.buildScratchSize = buildScratchSize;
            this.discardable = discardable;
        }
    }
    public unsafe struct VkMicromapUsageEXT
    {
        public uint count;
        public uint subdivisionLevel;
        public uint format;
        public VkMicromapUsageEXT(uint count, uint subdivisionLevel, uint format)
        {
            this.count = count;
            this.subdivisionLevel = subdivisionLevel;
            this.format = format;
        }
    }
    public unsafe struct VkMicromapTriangleEXT
    {
        public uint dataOffset;
        public ushort subdivisionLevel;
        public ushort format;
        public VkMicromapTriangleEXT(uint dataOffset, ushort subdivisionLevel, ushort format)
        {
            this.dataOffset = dataOffset;
            this.subdivisionLevel = subdivisionLevel;
            this.format = format;
        }
    }
    public unsafe struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceOpacityMicromapFeaturesExt;
        public void* pNext;
        public int micromap;
        public int micromapCaptureReplay;
        public int micromapHostCommands;
        public VkPhysicalDeviceOpacityMicromapFeaturesEXT(VkStructureType sType, void* pNext, int micromap, int micromapCaptureReplay, int micromapHostCommands)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.micromap = micromap;
            this.micromapCaptureReplay = micromapCaptureReplay;
            this.micromapHostCommands = micromapHostCommands;
        }
    }
    public unsafe struct VkPhysicalDeviceOpacityMicromapPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceOpacityMicromapPropertiesExt;
        public void* pNext;
        public uint maxOpacity2StateSubdivisionLevel;
        public uint maxOpacity4StateSubdivisionLevel;
        public VkPhysicalDeviceOpacityMicromapPropertiesEXT(VkStructureType sType, void* pNext, uint maxOpacity2StateSubdivisionLevel, uint maxOpacity4StateSubdivisionLevel)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxOpacity2StateSubdivisionLevel = maxOpacity2StateSubdivisionLevel;
            this.maxOpacity4StateSubdivisionLevel = maxOpacity4StateSubdivisionLevel;
        }
    }
    public unsafe struct VkAccelerationStructureTrianglesOpacityMicromapEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureTrianglesOpacityMicromapExt;
        public void* pNext;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexBuffer;
        public ulong indexStride;
        public uint baseTriangle;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkMicromapEXT micromap;
        public VkAccelerationStructureTrianglesOpacityMicromapEXT(VkStructureType sType, void* pNext, VkIndexType indexType, VkDeviceOrHostAddressConstKHR indexBuffer, ulong indexStride, uint baseTriangle, uint usageCountsCount, VkMicromapUsageEXT* pUsageCounts, VkMicromapUsageEXT** ppUsageCounts, VkMicromapEXT micromap)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.indexType = indexType;
            this.indexBuffer = indexBuffer;
            this.indexStride = indexStride;
            this.baseTriangle = baseTriangle;
            this.usageCountsCount = usageCountsCount;
            this.pUsageCounts = pUsageCounts;
            this.ppUsageCounts = ppUsageCounts;
            this.micromap = micromap;
        }
    }
    public unsafe struct VkPhysicalDeviceDisplacementMicromapFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDisplacementMicromapFeaturesNv;
        public void* pNext;
        public int displacementMicromap;
        public VkPhysicalDeviceDisplacementMicromapFeaturesNV(VkStructureType sType, void* pNext, int displacementMicromap)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.displacementMicromap = displacementMicromap;
        }
    }
    public unsafe struct VkPhysicalDeviceDisplacementMicromapPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDisplacementMicromapPropertiesNv;
        public void* pNext;
        public uint maxDisplacementMicromapSubdivisionLevel;
        public VkPhysicalDeviceDisplacementMicromapPropertiesNV(VkStructureType sType, void* pNext, uint maxDisplacementMicromapSubdivisionLevel)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxDisplacementMicromapSubdivisionLevel = maxDisplacementMicromapSubdivisionLevel;
        }
    }
    public unsafe struct VkAccelerationStructureTrianglesDisplacementMicromapNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeAccelerationStructureTrianglesDisplacementMicromapNv;
        public void* pNext;
        public VkFormat displacementBiasAndScaleFormat;
        public VkFormat displacementVectorFormat;
        public VkDeviceOrHostAddressConstKHR displacementBiasAndScaleBuffer;
        public ulong displacementBiasAndScaleStride;
        public VkDeviceOrHostAddressConstKHR displacementVectorBuffer;
        public ulong displacementVectorStride;
        public VkDeviceOrHostAddressConstKHR displacedMicromapPrimitiveFlags;
        public ulong displacedMicromapPrimitiveFlagsStride;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexBuffer;
        public ulong indexStride;
        public uint baseTriangle;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkMicromapEXT micromap;
        public VkAccelerationStructureTrianglesDisplacementMicromapNV(VkStructureType sType, void* pNext, VkFormat displacementBiasAndScaleFormat, VkFormat displacementVectorFormat, VkDeviceOrHostAddressConstKHR displacementBiasAndScaleBuffer, ulong displacementBiasAndScaleStride, VkDeviceOrHostAddressConstKHR displacementVectorBuffer, ulong displacementVectorStride, VkDeviceOrHostAddressConstKHR displacedMicromapPrimitiveFlags, ulong displacedMicromapPrimitiveFlagsStride, VkIndexType indexType, VkDeviceOrHostAddressConstKHR indexBuffer, ulong indexStride, uint baseTriangle, uint usageCountsCount, VkMicromapUsageEXT* pUsageCounts, VkMicromapUsageEXT** ppUsageCounts, VkMicromapEXT micromap)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.displacementBiasAndScaleFormat = displacementBiasAndScaleFormat;
            this.displacementVectorFormat = displacementVectorFormat;
            this.displacementBiasAndScaleBuffer = displacementBiasAndScaleBuffer;
            this.displacementBiasAndScaleStride = displacementBiasAndScaleStride;
            this.displacementVectorBuffer = displacementVectorBuffer;
            this.displacementVectorStride = displacementVectorStride;
            this.displacedMicromapPrimitiveFlags = displacedMicromapPrimitiveFlags;
            this.displacedMicromapPrimitiveFlagsStride = displacedMicromapPrimitiveFlagsStride;
            this.indexType = indexType;
            this.indexBuffer = indexBuffer;
            this.indexStride = indexStride;
            this.baseTriangle = baseTriangle;
            this.usageCountsCount = usageCountsCount;
            this.pUsageCounts = pUsageCounts;
            this.ppUsageCounts = ppUsageCounts;
            this.micromap = micromap;
        }
    }
    public unsafe struct VkPipelinePropertiesIdentifierEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelinePropertiesIdentifierExt;
        public void* pNext;
        public fixed byte pipelineIdentifier[16];
        public VkPipelinePropertiesIdentifierEXT(){ }
    }
    public unsafe struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePipelinePropertiesFeaturesExt;
        public void* pNext;
        public int pipelinePropertiesIdentifier;
        public VkPhysicalDevicePipelinePropertiesFeaturesEXT(VkStructureType sType, void* pNext, int pipelinePropertiesIdentifier)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelinePropertiesIdentifier = pipelinePropertiesIdentifier;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAmd;
        public void* pNext;
        public int shaderEarlyAndLateFragmentTests;
        public VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD(VkStructureType sType, void* pNext, int shaderEarlyAndLateFragmentTests)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderEarlyAndLateFragmentTests = shaderEarlyAndLateFragmentTests;
        }
    }
    public unsafe struct VkExternalMemoryAcquireUnmodifiedEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalMemoryAcquireUnmodifiedExt;
        public void* pNext;
        public int acquireUnmodifiedMemory;
        public VkExternalMemoryAcquireUnmodifiedEXT(VkStructureType sType, void* pNext, int acquireUnmodifiedMemory)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.acquireUnmodifiedMemory = acquireUnmodifiedMemory;
        }
    }
    public unsafe struct VkExportMetalObjectCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMetalObjectCreateInfoExt;
        public void* pNext;
        public VkExportMetalObjectTypeFlagBitsEXT exportObjectType;
        public VkExportMetalObjectCreateInfoEXT(VkStructureType sType, void* pNext, VkExportMetalObjectTypeFlagBitsEXT exportObjectType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.exportObjectType = exportObjectType;
        }
    }
    public unsafe struct VkExportMetalObjectsInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMetalObjectsInfoExt;
        public void* pNext;
        public VkExportMetalObjectsInfoEXT(VkStructureType sType, void* pNext)
        {
            this.sType = sType;
            this.pNext = pNext;
        }
    }
    public unsafe struct VkExportMetalDeviceInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMetalDeviceInfoExt;
        public void* pNext;
        public IntPtr mtlDevice;
        public VkExportMetalDeviceInfoEXT(VkStructureType sType, void* pNext, IntPtr mtlDevice)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.mtlDevice = mtlDevice;
        }
    }
    public unsafe struct VkExportMetalCommandQueueInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMetalCommandQueueInfoExt;
        public void* pNext;
        public VkQueue queue;
        public IntPtr mtlCommandQueue;
        public VkExportMetalCommandQueueInfoEXT(VkStructureType sType, void* pNext, VkQueue queue, IntPtr mtlCommandQueue)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.queue = queue;
            this.mtlCommandQueue = mtlCommandQueue;
        }
    }
    public unsafe struct VkExportMetalBufferInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMetalBufferInfoExt;
        public void* pNext;
        public VkDeviceMemory memory;
        public IntPtr mtlBuffer;
        public VkExportMetalBufferInfoEXT(VkStructureType sType, void* pNext, VkDeviceMemory memory, IntPtr mtlBuffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memory = memory;
            this.mtlBuffer = mtlBuffer;
        }
    }
    public unsafe struct VkImportMetalBufferInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMetalBufferInfoExt;
        public void* pNext;
        public IntPtr mtlBuffer;
        public VkImportMetalBufferInfoEXT(VkStructureType sType, void* pNext, IntPtr mtlBuffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.mtlBuffer = mtlBuffer;
        }
    }
    public unsafe struct VkExportMetalTextureInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMetalTextureInfoExt;
        public void* pNext;
        public VkImage image;
        public VkImageView imageView;
        public VkBufferView bufferView;
        public VkImageAspectFlagBits plane;
        public IntPtr mtlTexture;
        public VkExportMetalTextureInfoEXT(VkStructureType sType, void* pNext, VkImage image, VkImageView imageView, VkBufferView bufferView, VkImageAspectFlagBits plane, IntPtr mtlTexture)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image = image;
            this.imageView = imageView;
            this.bufferView = bufferView;
            this.plane = plane;
            this.mtlTexture = mtlTexture;
        }
    }
    public unsafe struct VkImportMetalTextureInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMetalTextureInfoExt;
        public void* pNext;
        public VkImageAspectFlagBits plane;
        public IntPtr mtlTexture;
        public VkImportMetalTextureInfoEXT(VkStructureType sType, void* pNext, VkImageAspectFlagBits plane, IntPtr mtlTexture)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.plane = plane;
            this.mtlTexture = mtlTexture;
        }
    }
    public unsafe struct VkExportMetalIOSurfaceInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMetalIoSurfaceInfoExt;
        public void* pNext;
        public VkImage image;
        public IntPtr ioSurface;
        public VkExportMetalIOSurfaceInfoEXT(VkStructureType sType, void* pNext, VkImage image, IntPtr ioSurface)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.image = image;
            this.ioSurface = ioSurface;
        }
    }
    public unsafe struct VkImportMetalIOSurfaceInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMetalIoSurfaceInfoExt;
        public void* pNext;
        public IntPtr ioSurface;
        public VkImportMetalIOSurfaceInfoEXT(VkStructureType sType, void* pNext, IntPtr ioSurface)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.ioSurface = ioSurface;
        }
    }
    public unsafe struct VkExportMetalSharedEventInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeExportMetalSharedEventInfoExt;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkEvent @event;
        public IntPtr mtlSharedEvent;
        public VkExportMetalSharedEventInfoEXT(VkStructureType sType, void* pNext, VkSemaphore semaphore, VkEvent @event, IntPtr mtlSharedEvent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.semaphore = semaphore;
            this.@event = @event;
            this.mtlSharedEvent = mtlSharedEvent;
        }
    }
    public unsafe struct VkImportMetalSharedEventInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportMetalSharedEventInfoExt;
        public void* pNext;
        public IntPtr mtlSharedEvent;
        public VkImportMetalSharedEventInfoEXT(VkStructureType sType, void* pNext, IntPtr mtlSharedEvent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.mtlSharedEvent = mtlSharedEvent;
        }
    }
    public unsafe struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceNonSeamlessCubeMapFeaturesExt;
        public void* pNext;
        public int nonSeamlessCubeMap;
        public VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT(VkStructureType sType, void* pNext, int nonSeamlessCubeMap)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.nonSeamlessCubeMap = nonSeamlessCubeMap;
        }
    }
    public unsafe struct VkPhysicalDevicePipelineRobustnessFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePipelineRobustnessFeaturesExt;
        public void* pNext;
        public int pipelineRobustness;
        public VkPhysicalDevicePipelineRobustnessFeaturesEXT(VkStructureType sType, void* pNext, int pipelineRobustness)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineRobustness = pipelineRobustness;
        }
    }
    public unsafe struct VkPipelineRobustnessCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineRobustnessCreateInfoExt;
        public void* pNext;
        public VkPipelineRobustnessBufferBehaviorEXT storageBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT uniformBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT vertexInputs;
        public VkPipelineRobustnessImageBehaviorEXT images;
        public VkPipelineRobustnessCreateInfoEXT(VkStructureType sType, void* pNext, VkPipelineRobustnessBufferBehaviorEXT storageBuffers, VkPipelineRobustnessBufferBehaviorEXT uniformBuffers, VkPipelineRobustnessBufferBehaviorEXT vertexInputs, VkPipelineRobustnessImageBehaviorEXT images)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.storageBuffers = storageBuffers;
            this.uniformBuffers = uniformBuffers;
            this.vertexInputs = vertexInputs;
            this.images = images;
        }
    }
    public unsafe struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePipelineRobustnessPropertiesExt;
        public void* pNext;
        public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessStorageBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessUniformBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessVertexInputs;
        public VkPipelineRobustnessImageBehaviorEXT defaultRobustnessImages;
        public VkPhysicalDevicePipelineRobustnessPropertiesEXT(VkStructureType sType, void* pNext, VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessStorageBuffers, VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessUniformBuffers, VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessVertexInputs, VkPipelineRobustnessImageBehaviorEXT defaultRobustnessImages)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.defaultRobustnessStorageBuffers = defaultRobustnessStorageBuffers;
            this.defaultRobustnessUniformBuffers = defaultRobustnessUniformBuffers;
            this.defaultRobustnessVertexInputs = defaultRobustnessVertexInputs;
            this.defaultRobustnessImages = defaultRobustnessImages;
        }
    }
    public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageViewSampleWeightCreateInfoQcom;
        public void* pNext;
        public VkOffset2D filterCenter;
        public VkExtent2D filterSize;
        public uint numPhases;
        public VkImageViewSampleWeightCreateInfoQCOM(VkStructureType sType, void* pNext, VkOffset2D filterCenter, VkExtent2D filterSize, uint numPhases)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.filterCenter = filterCenter;
            this.filterSize = filterSize;
            this.numPhases = numPhases;
        }
    }
    public unsafe struct VkPhysicalDeviceImageProcessingFeaturesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageProcessingFeaturesQcom;
        public void* pNext;
        public int textureSampleWeighted;
        public int textureBoxFilter;
        public int textureBlockMatch;
        public VkPhysicalDeviceImageProcessingFeaturesQCOM(VkStructureType sType, void* pNext, int textureSampleWeighted, int textureBoxFilter, int textureBlockMatch)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.textureSampleWeighted = textureSampleWeighted;
            this.textureBoxFilter = textureBoxFilter;
            this.textureBlockMatch = textureBlockMatch;
        }
    }
    public unsafe struct VkPhysicalDeviceImageProcessingPropertiesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageProcessingPropertiesQcom;
        public void* pNext;
        public uint maxWeightFilterPhases;
        public VkExtent2D maxWeightFilterDimension;
        public VkExtent2D maxBlockMatchRegion;
        public VkExtent2D maxBoxFilterBlockSize;
        public VkPhysicalDeviceImageProcessingPropertiesQCOM(VkStructureType sType, void* pNext, uint maxWeightFilterPhases, VkExtent2D maxWeightFilterDimension, VkExtent2D maxBlockMatchRegion, VkExtent2D maxBoxFilterBlockSize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxWeightFilterPhases = maxWeightFilterPhases;
            this.maxWeightFilterDimension = maxWeightFilterDimension;
            this.maxBlockMatchRegion = maxBlockMatchRegion;
            this.maxBoxFilterBlockSize = maxBoxFilterBlockSize;
        }
    }
    public unsafe struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceTilePropertiesFeaturesQcom;
        public void* pNext;
        public int tileProperties;
        public VkPhysicalDeviceTilePropertiesFeaturesQCOM(VkStructureType sType, void* pNext, int tileProperties)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.tileProperties = tileProperties;
        }
    }
    public unsafe struct VkTilePropertiesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeTilePropertiesQcom;
        public void* pNext;
        public VkExtent3D tileSize;
        public VkExtent2D apronSize;
        public VkOffset2D origin;
        public VkTilePropertiesQCOM(VkStructureType sType, void* pNext, VkExtent3D tileSize, VkExtent2D apronSize, VkOffset2D origin)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.tileSize = tileSize;
            this.apronSize = apronSize;
            this.origin = origin;
        }
    }
    public unsafe struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceAmigoProfilingFeaturesSec;
        public void* pNext;
        public int amigoProfiling;
        public VkPhysicalDeviceAmigoProfilingFeaturesSEC(VkStructureType sType, void* pNext, int amigoProfiling)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.amigoProfiling = amigoProfiling;
        }
    }
    public unsafe struct VkAmigoProfilingSubmitInfoSEC
    {
        public VkStructureType sType = VkStructureType.StructureTypeAmigoProfilingSubmitInfoSec;
        public void* pNext;
        public ulong firstDrawTimestamp;
        public ulong swapBufferTimestamp;
        public VkAmigoProfilingSubmitInfoSEC(VkStructureType sType, void* pNext, ulong firstDrawTimestamp, ulong swapBufferTimestamp)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.firstDrawTimestamp = firstDrawTimestamp;
            this.swapBufferTimestamp = swapBufferTimestamp;
        }
    }
    public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesExt;
        public void* pNext;
        public int attachmentFeedbackLoopLayout;
        public VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT(VkStructureType sType, void* pNext, int attachmentFeedbackLoopLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.attachmentFeedbackLoopLayout = attachmentFeedbackLoopLayout;
        }
    }
    public unsafe struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDepthClampZeroOneFeaturesExt;
        public void* pNext;
        public int depthClampZeroOne;
        public VkPhysicalDeviceDepthClampZeroOneFeaturesEXT(VkStructureType sType, void* pNext, int depthClampZeroOne)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.depthClampZeroOne = depthClampZeroOne;
        }
    }
    public unsafe struct VkPhysicalDeviceAddressBindingReportFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceAddressBindingReportFeaturesExt;
        public void* pNext;
        public int reportAddressBinding;
        public VkPhysicalDeviceAddressBindingReportFeaturesEXT(VkStructureType sType, void* pNext, int reportAddressBinding)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.reportAddressBinding = reportAddressBinding;
        }
    }
    public unsafe struct VkDeviceAddressBindingCallbackDataEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceAddressBindingCallbackDataExt;
        public void* pNext;
        public VkDeviceAddressBindingFlagBitsEXT flags;
        public ulong baseAddress;
        public ulong size;
        public VkDeviceAddressBindingTypeEXT bindingType;
        public VkDeviceAddressBindingCallbackDataEXT(VkStructureType sType, void* pNext, VkDeviceAddressBindingFlagBitsEXT flags, ulong baseAddress, ulong size, VkDeviceAddressBindingTypeEXT bindingType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.baseAddress = baseAddress;
            this.size = size;
            this.bindingType = bindingType;
        }
    }
    public unsafe struct VkPhysicalDeviceOpticalFlowFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceOpticalFlowFeaturesNv;
        public void* pNext;
        public int opticalFlow;
        public VkPhysicalDeviceOpticalFlowFeaturesNV(VkStructureType sType, void* pNext, int opticalFlow)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.opticalFlow = opticalFlow;
        }
    }
    public unsafe struct VkPhysicalDeviceOpticalFlowPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceOpticalFlowPropertiesNv;
        public void* pNext;
        public VkOpticalFlowGridSizeFlagBitsNV supportedOutputGridSizes;
        public VkOpticalFlowGridSizeFlagBitsNV supportedHintGridSizes;
        public int hintSupported;
        public int costSupported;
        public int bidirectionalFlowSupported;
        public int globalFlowSupported;
        public uint minWidth;
        public uint minHeight;
        public uint maxWidth;
        public uint maxHeight;
        public uint maxNumRegionsOfInterest;
        public VkPhysicalDeviceOpticalFlowPropertiesNV(VkStructureType sType, void* pNext, VkOpticalFlowGridSizeFlagBitsNV supportedOutputGridSizes, VkOpticalFlowGridSizeFlagBitsNV supportedHintGridSizes, int hintSupported, int costSupported, int bidirectionalFlowSupported, int globalFlowSupported, uint minWidth, uint minHeight, uint maxWidth, uint maxHeight, uint maxNumRegionsOfInterest)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.supportedOutputGridSizes = supportedOutputGridSizes;
            this.supportedHintGridSizes = supportedHintGridSizes;
            this.hintSupported = hintSupported;
            this.costSupported = costSupported;
            this.bidirectionalFlowSupported = bidirectionalFlowSupported;
            this.globalFlowSupported = globalFlowSupported;
            this.minWidth = minWidth;
            this.minHeight = minHeight;
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;
            this.maxNumRegionsOfInterest = maxNumRegionsOfInterest;
        }
    }
    public unsafe struct VkOpticalFlowImageFormatInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeOpticalFlowImageFormatInfoNv;
        public void* pNext;
        public VkOpticalFlowUsageFlagBitsNV usage;
        public VkOpticalFlowImageFormatInfoNV(VkStructureType sType, void* pNext, VkOpticalFlowUsageFlagBitsNV usage)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.usage = usage;
        }
    }
    public unsafe struct VkOpticalFlowImageFormatPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeOpticalFlowImageFormatPropertiesNv;
        public void* pNext;
        public VkFormat format;
        public VkOpticalFlowImageFormatPropertiesNV(VkStructureType sType, void* pNext, VkFormat format)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.format = format;
        }
    }
    public unsafe struct VkOpticalFlowSessionCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeOpticalFlowSessionCreateInfoNv;
        public void* pNext;
        public uint width;
        public uint height;
        public VkFormat imageFormat;
        public VkFormat flowVectorFormat;
        public VkFormat costFormat;
        public VkOpticalFlowGridSizeFlagBitsNV outputGridSize;
        public VkOpticalFlowGridSizeFlagBitsNV hintGridSize;
        public VkOpticalFlowPerformanceLevelNV performanceLevel;
        public VkOpticalFlowSessionCreateFlagBitsNV flags;
        public VkOpticalFlowSessionCreateInfoNV(VkStructureType sType, void* pNext, uint width, uint height, VkFormat imageFormat, VkFormat flowVectorFormat, VkFormat costFormat, VkOpticalFlowGridSizeFlagBitsNV outputGridSize, VkOpticalFlowGridSizeFlagBitsNV hintGridSize, VkOpticalFlowPerformanceLevelNV performanceLevel, VkOpticalFlowSessionCreateFlagBitsNV flags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.width = width;
            this.height = height;
            this.imageFormat = imageFormat;
            this.flowVectorFormat = flowVectorFormat;
            this.costFormat = costFormat;
            this.outputGridSize = outputGridSize;
            this.hintGridSize = hintGridSize;
            this.performanceLevel = performanceLevel;
            this.flags = flags;
        }
    }
    public unsafe struct VkOpticalFlowSessionCreatePrivateDataInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeOpticalFlowSessionCreatePrivateDataInfoNv;
        public void* pNext;
        public uint id;
        public uint size;
        public void* pPrivateData;
        public VkOpticalFlowSessionCreatePrivateDataInfoNV(VkStructureType sType, void* pNext, uint id, uint size, void* pPrivateData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.id = id;
            this.size = size;
            this.pPrivateData = pPrivateData;
        }
    }
    public unsafe struct VkOpticalFlowExecuteInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeOpticalFlowExecuteInfoNv;
        public void* pNext;
        public VkOpticalFlowExecuteFlagBitsNV flags;
        public uint regionCount;
        public VkRect2D* pRegions;
        public VkOpticalFlowExecuteInfoNV(VkStructureType sType, void* pNext, VkOpticalFlowExecuteFlagBitsNV flags, uint regionCount, VkRect2D* pRegions)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.regionCount = regionCount;
            this.pRegions = pRegions;
        }
    }
    public unsafe struct VkPhysicalDeviceFaultFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFaultFeaturesExt;
        public void* pNext;
        public int deviceFault;
        public int deviceFaultVendorBinary;
        public VkPhysicalDeviceFaultFeaturesEXT(VkStructureType sType, void* pNext, int deviceFault, int deviceFaultVendorBinary)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.deviceFault = deviceFault;
            this.deviceFaultVendorBinary = deviceFaultVendorBinary;
        }
    }
    public unsafe struct VkDeviceFaultAddressInfoEXT
    {
        public VkDeviceFaultAddressTypeEXT addressType;
        public ulong reportedAddress;
        public ulong addressPrecision;
        public VkDeviceFaultAddressInfoEXT(VkDeviceFaultAddressTypeEXT addressType, ulong reportedAddress, ulong addressPrecision)
        {
            this.addressType = addressType;
            this.reportedAddress = reportedAddress;
            this.addressPrecision = addressPrecision;
        }
    }
    public unsafe struct VkDeviceFaultVendorInfoEXT
    {
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
        public ulong vendorFaultCode;
        public ulong vendorFaultData;
    }
    public unsafe struct VkDeviceFaultCountsEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceFaultCountsExt;
        public void* pNext;
        public uint addressInfoCount;
        public uint vendorInfoCount;
        public ulong vendorBinarySize;
        public VkDeviceFaultCountsEXT(VkStructureType sType, void* pNext, uint addressInfoCount, uint vendorInfoCount, ulong vendorBinarySize)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.addressInfoCount = addressInfoCount;
            this.vendorInfoCount = vendorInfoCount;
            this.vendorBinarySize = vendorBinarySize;
        }
    }
    public unsafe struct VkDeviceFaultInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceFaultInfoExt;
        public void* pNext;
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
        public VkDeviceFaultAddressInfoEXT* pAddressInfos;
        public VkDeviceFaultVendorInfoEXT* pVendorInfos;
        public void* pVendorBinaryData;
        public VkDeviceFaultInfoEXT(){ }
    }
    public unsafe struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
    {
        public uint headerSize;
        public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;
        public uint vendorID;
        public uint deviceID;
        public uint driverVersion;
        public fixed byte pipelineCacheUUID[16];
        public uint applicationNameOffset;
        public uint applicationVersion;
        public uint engineNameOffset;
        public uint engineVersion;
        public uint apiVersion;
    }
    public unsafe struct VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePipelineLibraryGroupHandlesFeaturesExt;
        public void* pNext;
        public int pipelineLibraryGroupHandles;
        public VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT(VkStructureType sType, void* pNext, int pipelineLibraryGroupHandles)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pipelineLibraryGroupHandles = pipelineLibraryGroupHandles;
        }
    }
    public unsafe struct VkDepthBiasInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDepthBiasInfoExt;
        public void* pNext;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        public VkDepthBiasInfoEXT(VkStructureType sType, void* pNext, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.depthBiasConstantFactor = depthBiasConstantFactor;
            this.depthBiasClamp = depthBiasClamp;
            this.depthBiasSlopeFactor = depthBiasSlopeFactor;
        }
    }
    public unsafe struct VkDepthBiasRepresentationInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeDepthBiasRepresentationInfoExt;
        public void* pNext;
        public VkDepthBiasRepresentationEXT depthBiasRepresentation;
        public int depthBiasExact;
        public VkDepthBiasRepresentationInfoEXT(VkStructureType sType, void* pNext, VkDepthBiasRepresentationEXT depthBiasRepresentation, int depthBiasExact)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.depthBiasRepresentation = depthBiasRepresentation;
            this.depthBiasExact = depthBiasExact;
        }
    }
    public unsafe struct VkDecompressMemoryRegionNV
    {
        public ulong srcAddress;
        public ulong dstAddress;
        public ulong compressedSize;
        public ulong decompressedSize;
        public VkMemoryDecompressionMethodFlagBitsNV decompressionMethod;
        public VkDecompressMemoryRegionNV(ulong srcAddress, ulong dstAddress, ulong compressedSize, ulong decompressedSize, VkMemoryDecompressionMethodFlagBitsNV decompressionMethod)
        {
            this.srcAddress = srcAddress;
            this.dstAddress = dstAddress;
            this.compressedSize = compressedSize;
            this.decompressedSize = decompressedSize;
            this.decompressionMethod = decompressionMethod;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderCoreBuiltinsPropertiesArm;
        public void* pNext;
        public ulong shaderCoreMask;
        public uint shaderCoreCount;
        public uint shaderWarpsPerCore;
        public VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM(VkStructureType sType, void* pNext, ulong shaderCoreMask, uint shaderCoreCount, uint shaderWarpsPerCore)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderCoreMask = shaderCoreMask;
            this.shaderCoreCount = shaderCoreCount;
            this.shaderWarpsPerCore = shaderWarpsPerCore;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderCoreBuiltinsFeaturesArm;
        public void* pNext;
        public int shaderCoreBuiltins;
        public VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM(VkStructureType sType, void* pNext, int shaderCoreBuiltins)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderCoreBuiltins = shaderCoreBuiltins;
        }
    }
    public unsafe struct VkFrameBoundaryEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeFrameBoundaryExt;
        public void* pNext;
        public VkFrameBoundaryFlagBitsEXT flags;
        public ulong frameID;
        public uint imageCount;
        public VkImage* pImages;
        public uint bufferCount;
        public VkBuffer* pBuffers;
        public ulong tagName;
        public nuint tagSize;
        public void* pTag;
        public VkFrameBoundaryEXT(VkStructureType sType, void* pNext, VkFrameBoundaryFlagBitsEXT flags, ulong frameID, uint imageCount, VkImage* pImages, uint bufferCount, VkBuffer* pBuffers, ulong tagName, nuint tagSize, void* pTag)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.frameID = frameID;
            this.imageCount = imageCount;
            this.pImages = pImages;
            this.bufferCount = bufferCount;
            this.pBuffers = pBuffers;
            this.tagName = tagName;
            this.tagSize = tagSize;
            this.pTag = pTag;
        }
    }
    public unsafe struct VkPhysicalDeviceFrameBoundaryFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceFrameBoundaryFeaturesExt;
        public void* pNext;
        public int frameBoundary;
        public VkPhysicalDeviceFrameBoundaryFeaturesEXT(VkStructureType sType, void* pNext, int frameBoundary)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.frameBoundary = frameBoundary;
        }
    }
    public unsafe struct VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesExt;
        public void* pNext;
        public int dynamicRenderingUnusedAttachments;
        public VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT(VkStructureType sType, void* pNext, int dynamicRenderingUnusedAttachments)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dynamicRenderingUnusedAttachments = dynamicRenderingUnusedAttachments;
        }
    }
    public unsafe struct VkSurfacePresentModeEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfacePresentModeExt;
        public void* pNext;
        public VkPresentModeKHR presentMode;
        public VkSurfacePresentModeEXT(VkStructureType sType, void* pNext, VkPresentModeKHR presentMode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentMode = presentMode;
        }
    }
    public unsafe struct VkSurfacePresentScalingCapabilitiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfacePresentScalingCapabilitiesExt;
        public void* pNext;
        public VkPresentScalingFlagBitsEXT supportedPresentScaling;
        public VkPresentGravityFlagBitsEXT supportedPresentGravityX;
        public VkPresentGravityFlagBitsEXT supportedPresentGravityY;
        public VkExtent2D minScaledImageExtent;
        public VkExtent2D maxScaledImageExtent;
        public VkSurfacePresentScalingCapabilitiesEXT(VkStructureType sType, void* pNext, VkPresentScalingFlagBitsEXT supportedPresentScaling, VkPresentGravityFlagBitsEXT supportedPresentGravityX, VkPresentGravityFlagBitsEXT supportedPresentGravityY, VkExtent2D minScaledImageExtent, VkExtent2D maxScaledImageExtent)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.supportedPresentScaling = supportedPresentScaling;
            this.supportedPresentGravityX = supportedPresentGravityX;
            this.supportedPresentGravityY = supportedPresentGravityY;
            this.minScaledImageExtent = minScaledImageExtent;
            this.maxScaledImageExtent = maxScaledImageExtent;
        }
    }
    public unsafe struct VkSurfacePresentModeCompatibilityEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSurfacePresentModeCompatibilityExt;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
        public VkSurfacePresentModeCompatibilityEXT(VkStructureType sType, void* pNext, uint presentModeCount, VkPresentModeKHR* pPresentModes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentModeCount = presentModeCount;
            this.pPresentModes = pPresentModes;
        }
    }
    public unsafe struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSwapchainMaintenance1FeaturesExt;
        public void* pNext;
        public int swapchainMaintenance1;
        public VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT(VkStructureType sType, void* pNext, int swapchainMaintenance1)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchainMaintenance1 = swapchainMaintenance1;
        }
    }
    public unsafe struct VkSwapchainPresentFenceInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSwapchainPresentFenceInfoExt;
        public void* pNext;
        public uint swapchainCount;
        public VkFence* pFences;
        public VkSwapchainPresentFenceInfoEXT(VkStructureType sType, void* pNext, uint swapchainCount, VkFence* pFences)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchainCount = swapchainCount;
            this.pFences = pFences;
        }
    }
    public unsafe struct VkSwapchainPresentModesCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSwapchainPresentModesCreateInfoExt;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
        public VkSwapchainPresentModesCreateInfoEXT(VkStructureType sType, void* pNext, uint presentModeCount, VkPresentModeKHR* pPresentModes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentModeCount = presentModeCount;
            this.pPresentModes = pPresentModes;
        }
    }
    public unsafe struct VkSwapchainPresentModeInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSwapchainPresentModeInfoExt;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentModeKHR* pPresentModes;
        public VkSwapchainPresentModeInfoEXT(VkStructureType sType, void* pNext, uint swapchainCount, VkPresentModeKHR* pPresentModes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchainCount = swapchainCount;
            this.pPresentModes = pPresentModes;
        }
    }
    public unsafe struct VkSwapchainPresentScalingCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSwapchainPresentScalingCreateInfoExt;
        public void* pNext;
        public VkPresentScalingFlagBitsEXT scalingBehavior;
        public VkPresentGravityFlagBitsEXT presentGravityX;
        public VkPresentGravityFlagBitsEXT presentGravityY;
        public VkSwapchainPresentScalingCreateInfoEXT(VkStructureType sType, void* pNext, VkPresentScalingFlagBitsEXT scalingBehavior, VkPresentGravityFlagBitsEXT presentGravityX, VkPresentGravityFlagBitsEXT presentGravityY)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.scalingBehavior = scalingBehavior;
            this.presentGravityX = presentGravityX;
            this.presentGravityY = presentGravityY;
        }
    }
    public unsafe struct VkReleaseSwapchainImagesInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeReleaseSwapchainImagesInfoExt;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public uint imageIndexCount;
        public uint* pImageIndices;
        public VkReleaseSwapchainImagesInfoEXT(VkStructureType sType, void* pNext, VkSwapchainKHR swapchain, uint imageIndexCount, uint* pImageIndices)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.swapchain = swapchain;
            this.imageIndexCount = imageIndexCount;
            this.pImageIndices = pImageIndices;
        }
    }
    public unsafe struct VkPhysicalDeviceDepthBiasControlFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDepthBiasControlFeaturesExt;
        public void* pNext;
        public int depthBiasControl;
        public int leastRepresentableValueForceUnormRepresentation;
        public int floatRepresentation;
        public int depthBiasExact;
        public VkPhysicalDeviceDepthBiasControlFeaturesEXT(VkStructureType sType, void* pNext, int depthBiasControl, int leastRepresentableValueForceUnormRepresentation, int floatRepresentation, int depthBiasExact)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.depthBiasControl = depthBiasControl;
            this.leastRepresentableValueForceUnormRepresentation = leastRepresentableValueForceUnormRepresentation;
            this.floatRepresentation = floatRepresentation;
            this.depthBiasExact = depthBiasExact;
        }
    }
    public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayTracingInvocationReorderFeaturesNv;
        public void* pNext;
        public int rayTracingInvocationReorder;
        public VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV(VkStructureType sType, void* pNext, int rayTracingInvocationReorder)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rayTracingInvocationReorder = rayTracingInvocationReorder;
        }
    }
    public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayTracingInvocationReorderPropertiesNv;
        public void* pNext;
        public VkRayTracingInvocationReorderModeNV rayTracingInvocationReorderReorderingHint;
        public VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV(VkStructureType sType, void* pNext, VkRayTracingInvocationReorderModeNV rayTracingInvocationReorderReorderingHint)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rayTracingInvocationReorderReorderingHint = rayTracingInvocationReorderReorderingHint;
        }
    }
    public unsafe struct VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExtendedSparseAddressSpaceFeaturesNv;
        public void* pNext;
        public int extendedSparseAddressSpace;
        public VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV(VkStructureType sType, void* pNext, int extendedSparseAddressSpace)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.extendedSparseAddressSpace = extendedSparseAddressSpace;
        }
    }
    public unsafe struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExtendedSparseAddressSpacePropertiesNv;
        public void* pNext;
        public ulong extendedSparseAddressSpaceSize;
        public VkImageUsageFlagBits extendedSparseImageUsageFlags;
        public VkBufferUsageFlagBits extendedSparseBufferUsageFlags;
        public VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV(VkStructureType sType, void* pNext, ulong extendedSparseAddressSpaceSize, VkImageUsageFlagBits extendedSparseImageUsageFlags, VkBufferUsageFlagBits extendedSparseBufferUsageFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.extendedSparseAddressSpaceSize = extendedSparseAddressSpaceSize;
            this.extendedSparseImageUsageFlags = extendedSparseImageUsageFlags;
            this.extendedSparseBufferUsageFlags = extendedSparseBufferUsageFlags;
        }
    }
    public unsafe struct VkDirectDriverLoadingInfoLUNARG
    {
        public VkStructureType sType = VkStructureType.StructureTypeDirectDriverLoadingInfoLunarg;
        public void* pNext;
        public VkDirectDriverLoadingFlagsLUNARG flags;
        public delegate* unmanaged[Cdecl]<VkInstance, byte*, IntPtr> pfnGetInstanceProcAddr;
        public VkDirectDriverLoadingInfoLUNARG(VkStructureType sType, void* pNext, VkDirectDriverLoadingFlagsLUNARG flags, delegate* unmanaged[Cdecl]<VkInstance, byte*, IntPtr> pfnGetInstanceProcAddr)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.pfnGetInstanceProcAddr = pfnGetInstanceProcAddr;
        }
    }
    public unsafe struct VkDirectDriverLoadingListLUNARG
    {
        public VkStructureType sType = VkStructureType.StructureTypeDirectDriverLoadingListLunarg;
        public void* pNext;
        public VkDirectDriverLoadingModeLUNARG mode;
        public uint driverCount;
        public VkDirectDriverLoadingInfoLUNARG* pDrivers;
        public VkDirectDriverLoadingListLUNARG(VkStructureType sType, void* pNext, VkDirectDriverLoadingModeLUNARG mode, uint driverCount, VkDirectDriverLoadingInfoLUNARG* pDrivers)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.mode = mode;
            this.driverCount = driverCount;
            this.pDrivers = pDrivers;
        }
    }
    public unsafe struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMultiviewPerViewViewportsFeaturesQcom;
        public void* pNext;
        public int multiviewPerViewViewports;
        public VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM(VkStructureType sType, void* pNext, int multiviewPerViewViewports)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.multiviewPerViewViewports = multiviewPerViewViewports;
        }
    }
    public unsafe struct VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRayTracingPositionFetchFeaturesKhr;
        public void* pNext;
        public int rayTracingPositionFetch;
        public VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR(VkStructureType sType, void* pNext, int rayTracingPositionFetch)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.rayTracingPositionFetch = rayTracingPositionFetch;
        }
    }
    public unsafe struct VkDeviceImageSubresourceInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceImageSubresourceInfoKhr;
        public void* pNext;
        public VkImageCreateInfo* pCreateInfo;
        public VkImageSubresource2KHR* pSubresource;
        public VkDeviceImageSubresourceInfoKHR(VkStructureType sType, void* pNext, VkImageCreateInfo* pCreateInfo, VkImageSubresource2KHR* pSubresource)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pCreateInfo = pCreateInfo;
            this.pSubresource = pSubresource;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderCorePropertiesARM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderCorePropertiesArm;
        public void* pNext;
        public uint pixelRate;
        public uint texelRate;
        public uint fmaRate;
        public VkPhysicalDeviceShaderCorePropertiesARM(VkStructureType sType, void* pNext, uint pixelRate, uint texelRate, uint fmaRate)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pixelRate = pixelRate;
            this.texelRate = texelRate;
            this.fmaRate = fmaRate;
        }
    }
    public unsafe struct VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMultiviewPerViewRenderAreasFeaturesQcom;
        public void* pNext;
        public int multiviewPerViewRenderAreas;
        public VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM(VkStructureType sType, void* pNext, int multiviewPerViewRenderAreas)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.multiviewPerViewRenderAreas = multiviewPerViewRenderAreas;
        }
    }
    public unsafe struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeMultiviewPerViewRenderAreasRenderPassBeginInfoQcom;
        public void* pNext;
        public uint perViewRenderAreaCount;
        public VkRect2D* pPerViewRenderAreas;
        public VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM(VkStructureType sType, void* pNext, uint perViewRenderAreaCount, VkRect2D* pPerViewRenderAreas)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.perViewRenderAreaCount = perViewRenderAreaCount;
            this.pPerViewRenderAreas = pPerViewRenderAreas;
        }
    }
    public unsafe struct VkQueryLowLatencySupportNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeQueryLowLatencySupportNv;
        public void* pNext;
        public void* pQueriedLowLatencyData;
        public VkQueryLowLatencySupportNV(VkStructureType sType, void* pNext, void* pQueriedLowLatencyData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pQueriedLowLatencyData = pQueriedLowLatencyData;
        }
    }
    public unsafe struct VkMemoryMapInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryMapInfoKhr;
        public void* pNext;
        public VkMemoryMapFlagBits flags;
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
        public VkMemoryMapInfoKHR(VkStructureType sType, void* pNext, VkMemoryMapFlagBits flags, VkDeviceMemory memory, ulong offset, ulong size)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.memory = memory;
            this.offset = offset;
            this.size = size;
        }
    }
    public unsafe struct VkMemoryUnmapInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryUnmapInfoKhr;
        public void* pNext;
        public VkMemoryUnmapFlagBitsKHR flags;
        public VkDeviceMemory memory;
        public VkMemoryUnmapInfoKHR(VkStructureType sType, void* pNext, VkMemoryUnmapFlagBitsKHR flags, VkDeviceMemory memory)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.memory = memory;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderObjectFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderObjectFeaturesExt;
        public void* pNext;
        public int shaderObject;
        public VkPhysicalDeviceShaderObjectFeaturesEXT(VkStructureType sType, void* pNext, int shaderObject)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderObject = shaderObject;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderObjectPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderObjectPropertiesExt;
        public void* pNext;
        public fixed byte shaderBinaryUUID[16];
        public uint shaderBinaryVersion;
        public VkPhysicalDeviceShaderObjectPropertiesEXT(){ }
    }
    public unsafe struct VkShaderCreateInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeShaderCreateInfoExt;
        public void* pNext;
        public VkShaderCreateFlagBitsEXT flags;
        public VkShaderStageFlagBits stage;
        public VkShaderStageFlagBits nextStage;
        public VkShaderCodeTypeEXT codeType;
        public nuint codeSize;
        public void* pCode;
        public byte* pName;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
        public VkSpecializationInfo* pSpecializationInfo;
        public VkShaderCreateInfoEXT(VkStructureType sType, void* pNext, VkShaderCreateFlagBitsEXT flags, VkShaderStageFlagBits stage, VkShaderStageFlagBits nextStage, VkShaderCodeTypeEXT codeType, nuint codeSize, void* pCode, byte* pName, uint setLayoutCount, VkDescriptorSetLayout* pSetLayouts, uint pushConstantRangeCount, VkPushConstantRange* pPushConstantRanges, VkSpecializationInfo* pSpecializationInfo)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.stage = stage;
            this.nextStage = nextStage;
            this.codeType = codeType;
            this.codeSize = codeSize;
            this.pCode = pCode;
            this.pName = pName;
            this.setLayoutCount = setLayoutCount;
            this.pSetLayouts = pSetLayouts;
            this.pushConstantRangeCount = pushConstantRangeCount;
            this.pPushConstantRanges = pPushConstantRanges;
            this.pSpecializationInfo = pSpecializationInfo;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderTileImageFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderTileImageFeaturesExt;
        public void* pNext;
        public int shaderTileImageColorReadAccess;
        public int shaderTileImageDepthReadAccess;
        public int shaderTileImageStencilReadAccess;
        public VkPhysicalDeviceShaderTileImageFeaturesEXT(VkStructureType sType, void* pNext, int shaderTileImageColorReadAccess, int shaderTileImageDepthReadAccess, int shaderTileImageStencilReadAccess)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderTileImageColorReadAccess = shaderTileImageColorReadAccess;
            this.shaderTileImageDepthReadAccess = shaderTileImageDepthReadAccess;
            this.shaderTileImageStencilReadAccess = shaderTileImageStencilReadAccess;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderTileImagePropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderTileImagePropertiesExt;
        public void* pNext;
        public int shaderTileImageCoherentReadAccelerated;
        public int shaderTileImageReadSampleFromPixelRateInvocation;
        public int shaderTileImageReadFromHelperInvocation;
        public VkPhysicalDeviceShaderTileImagePropertiesEXT(VkStructureType sType, void* pNext, int shaderTileImageCoherentReadAccelerated, int shaderTileImageReadSampleFromPixelRateInvocation, int shaderTileImageReadFromHelperInvocation)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderTileImageCoherentReadAccelerated = shaderTileImageCoherentReadAccelerated;
            this.shaderTileImageReadSampleFromPixelRateInvocation = shaderTileImageReadSampleFromPixelRateInvocation;
            this.shaderTileImageReadFromHelperInvocation = shaderTileImageReadFromHelperInvocation;
        }
    }
    public unsafe struct VkImportScreenBufferInfoQNX
    {
        public VkStructureType sType = VkStructureType.StructureTypeImportScreenBufferInfoQnx;
        public void* pNext;
        public IntPtr* buffer;
        public VkImportScreenBufferInfoQNX(VkStructureType sType, void* pNext, IntPtr* buffer)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.buffer = buffer;
        }
    }
    public unsafe struct VkScreenBufferPropertiesQNX
    {
        public VkStructureType sType = VkStructureType.StructureTypeScreenBufferPropertiesQnx;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeBits;
        public VkScreenBufferPropertiesQNX(VkStructureType sType, void* pNext, ulong allocationSize, uint memoryTypeBits)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.allocationSize = allocationSize;
            this.memoryTypeBits = memoryTypeBits;
        }
    }
    public unsafe struct VkScreenBufferFormatPropertiesQNX
    {
        public VkStructureType sType = VkStructureType.StructureTypeScreenBufferFormatPropertiesQnx;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public ulong screenUsage;
        public VkFormatFeatureFlagBits formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
        public VkScreenBufferFormatPropertiesQNX(VkStructureType sType, void* pNext, VkFormat format, ulong externalFormat, ulong screenUsage, VkFormatFeatureFlagBits formatFeatures, VkComponentMapping samplerYcbcrConversionComponents, VkSamplerYcbcrModelConversion suggestedYcbcrModel, VkSamplerYcbcrRange suggestedYcbcrRange, VkChromaLocation suggestedXChromaOffset, VkChromaLocation suggestedYChromaOffset)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.format = format;
            this.externalFormat = externalFormat;
            this.screenUsage = screenUsage;
            this.formatFeatures = formatFeatures;
            this.samplerYcbcrConversionComponents = samplerYcbcrConversionComponents;
            this.suggestedYcbcrModel = suggestedYcbcrModel;
            this.suggestedYcbcrRange = suggestedYcbcrRange;
            this.suggestedXChromaOffset = suggestedXChromaOffset;
            this.suggestedYChromaOffset = suggestedYChromaOffset;
        }
    }
    public unsafe struct VkExternalFormatQNX
    {
        public VkStructureType sType = VkStructureType.StructureTypeExternalFormatQnx;
        public void* pNext;
        public ulong externalFormat;
        public VkExternalFormatQNX(VkStructureType sType, void* pNext, ulong externalFormat)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.externalFormat = externalFormat;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalMemoryScreenBufferFeaturesQnx;
        public void* pNext;
        public int screenBufferImport;
        public VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX(VkStructureType sType, void* pNext, int screenBufferImport)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.screenBufferImport = screenBufferImport;
        }
    }
    public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCooperativeMatrixFeaturesKhr;
        public void* pNext;
        public int cooperativeMatrix;
        public int cooperativeMatrixRobustBufferAccess;
        public VkPhysicalDeviceCooperativeMatrixFeaturesKHR(VkStructureType sType, void* pNext, int cooperativeMatrix, int cooperativeMatrixRobustBufferAccess)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.cooperativeMatrix = cooperativeMatrix;
            this.cooperativeMatrixRobustBufferAccess = cooperativeMatrixRobustBufferAccess;
        }
    }
    public unsafe struct VkCooperativeMatrixPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeCooperativeMatrixPropertiesKhr;
        public void* pNext;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public VkComponentTypeKHR AType;
        public VkComponentTypeKHR BType;
        public VkComponentTypeKHR CType;
        public VkComponentTypeKHR ResultType;
        public int saturatingAccumulation;
        public VkScopeKHR scope;
        public VkCooperativeMatrixPropertiesKHR(VkStructureType sType, void* pNext, uint MSize, uint NSize, uint KSize, VkComponentTypeKHR AType, VkComponentTypeKHR BType, VkComponentTypeKHR CType, VkComponentTypeKHR ResultType, int saturatingAccumulation, VkScopeKHR scope)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.MSize = MSize;
            this.NSize = NSize;
            this.KSize = KSize;
            this.AType = AType;
            this.BType = BType;
            this.CType = CType;
            this.ResultType = ResultType;
            this.saturatingAccumulation = saturatingAccumulation;
            this.scope = scope;
        }
    }
    public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCooperativeMatrixPropertiesKhr;
        public void* pNext;
        public VkShaderStageFlagBits cooperativeMatrixSupportedStages;
        public VkPhysicalDeviceCooperativeMatrixPropertiesKHR(VkStructureType sType, void* pNext, VkShaderStageFlagBits cooperativeMatrixSupportedStages)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.cooperativeMatrixSupportedStages = cooperativeMatrixSupportedStages;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderEnqueuePropertiesAMDX
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderEnqueuePropertiesAmdx;
        public void* pNext;
        public uint maxExecutionGraphDepth;
        public uint maxExecutionGraphShaderOutputNodes;
        public uint maxExecutionGraphShaderPayloadSize;
        public uint maxExecutionGraphShaderPayloadCount;
        public uint executionGraphDispatchAddressAlignment;
        public VkPhysicalDeviceShaderEnqueuePropertiesAMDX(VkStructureType sType, void* pNext, uint maxExecutionGraphDepth, uint maxExecutionGraphShaderOutputNodes, uint maxExecutionGraphShaderPayloadSize, uint maxExecutionGraphShaderPayloadCount, uint executionGraphDispatchAddressAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxExecutionGraphDepth = maxExecutionGraphDepth;
            this.maxExecutionGraphShaderOutputNodes = maxExecutionGraphShaderOutputNodes;
            this.maxExecutionGraphShaderPayloadSize = maxExecutionGraphShaderPayloadSize;
            this.maxExecutionGraphShaderPayloadCount = maxExecutionGraphShaderPayloadCount;
            this.executionGraphDispatchAddressAlignment = executionGraphDispatchAddressAlignment;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderEnqueueFeaturesAMDX
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderEnqueueFeaturesAmdx;
        public void* pNext;
        public int shaderEnqueue;
        public VkPhysicalDeviceShaderEnqueueFeaturesAMDX(VkStructureType sType, void* pNext, int shaderEnqueue)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderEnqueue = shaderEnqueue;
        }
    }
    public unsafe struct VkExecutionGraphPipelineCreateInfoAMDX
    {
        public VkStructureType sType = VkStructureType.StructureTypeExecutionGraphPipelineCreateInfoAmdx;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public VkExecutionGraphPipelineCreateInfoAMDX(VkStructureType sType, void* pNext, VkPipelineCreateFlagBits flags, uint stageCount, VkPipelineShaderStageCreateInfo* pStages, VkPipelineLibraryCreateInfoKHR* pLibraryInfo, VkPipelineLayout layout, VkPipeline basePipelineHandle, int basePipelineIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.flags = flags;
            this.stageCount = stageCount;
            this.pStages = pStages;
            this.pLibraryInfo = pLibraryInfo;
            this.layout = layout;
            this.basePipelineHandle = basePipelineHandle;
            this.basePipelineIndex = basePipelineIndex;
        }
    }
    public unsafe struct VkPipelineShaderStageNodeCreateInfoAMDX
    {
        public VkStructureType sType = VkStructureType.StructureTypePipelineShaderStageNodeCreateInfoAmdx;
        public void* pNext;
        public byte* pName;
        public uint index;
        public VkPipelineShaderStageNodeCreateInfoAMDX(VkStructureType sType, void* pNext, byte* pName, uint index)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pName = pName;
            this.index = index;
        }
    }
    public unsafe struct VkExecutionGraphPipelineScratchSizeAMDX
    {
        public VkStructureType sType = VkStructureType.StructureTypeExecutionGraphPipelineScratchSizeAmdx;
        public void* pNext;
        public ulong size;
        public VkExecutionGraphPipelineScratchSizeAMDX(VkStructureType sType, void* pNext, ulong size)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.size = size;
        }
    }
    public unsafe struct VkDispatchGraphInfoAMDX
    {
        public uint nodeIndex;
        public uint payloadCount;
        public VkDeviceOrHostAddressConstAMDX payloads;
        public ulong payloadStride;
        public VkDispatchGraphInfoAMDX(uint nodeIndex, uint payloadCount, VkDeviceOrHostAddressConstAMDX payloads, ulong payloadStride)
        {
            this.nodeIndex = nodeIndex;
            this.payloadCount = payloadCount;
            this.payloads = payloads;
            this.payloadStride = payloadStride;
        }
    }
    public unsafe struct VkDispatchGraphCountInfoAMDX
    {
        public uint count;
        public VkDeviceOrHostAddressConstAMDX infos;
        public ulong stride;
        public VkDispatchGraphCountInfoAMDX(uint count, VkDeviceOrHostAddressConstAMDX infos, ulong stride)
        {
            this.count = count;
            this.infos = infos;
            this.stride = stride;
        }
    }
    public unsafe struct VkBindMemoryStatusKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindMemoryStatusKhr;
        public void* pNext;
        public VkResult* pResult;
        public VkBindMemoryStatusKHR(VkStructureType sType, void* pNext, VkResult* pResult)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pResult = pResult;
        }
    }
    public unsafe struct VkBindDescriptorSetsInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindDescriptorSetsInfoKhr;
        public void* pNext;
        public VkShaderStageFlagBits stageFlags;
        public VkPipelineLayout layout;
        public uint firstSet;
        public uint descriptorSetCount;
        public VkDescriptorSet* pDescriptorSets;
        public uint dynamicOffsetCount;
        public uint* pDynamicOffsets;
        public VkBindDescriptorSetsInfoKHR(VkStructureType sType, void* pNext, VkShaderStageFlagBits stageFlags, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stageFlags = stageFlags;
            this.layout = layout;
            this.firstSet = firstSet;
            this.descriptorSetCount = descriptorSetCount;
            this.pDescriptorSets = pDescriptorSets;
            this.dynamicOffsetCount = dynamicOffsetCount;
            this.pDynamicOffsets = pDynamicOffsets;
        }
    }
    public unsafe struct VkPushConstantsInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePushConstantsInfoKhr;
        public void* pNext;
        public VkPipelineLayout layout;
        public VkShaderStageFlagBits stageFlags;
        public uint offset;
        public uint size;
        public void* pValues;
        public VkPushConstantsInfoKHR(VkStructureType sType, void* pNext, VkPipelineLayout layout, VkShaderStageFlagBits stageFlags, uint offset, uint size, void* pValues)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.layout = layout;
            this.stageFlags = stageFlags;
            this.offset = offset;
            this.size = size;
            this.pValues = pValues;
        }
    }
    public unsafe struct VkPushDescriptorSetInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePushDescriptorSetInfoKhr;
        public void* pNext;
        public VkShaderStageFlagBits stageFlags;
        public VkPipelineLayout layout;
        public uint set;
        public uint descriptorWriteCount;
        public VkWriteDescriptorSet* pDescriptorWrites;
        public VkPushDescriptorSetInfoKHR(VkStructureType sType, void* pNext, VkShaderStageFlagBits stageFlags, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stageFlags = stageFlags;
            this.layout = layout;
            this.set = set;
            this.descriptorWriteCount = descriptorWriteCount;
            this.pDescriptorWrites = pDescriptorWrites;
        }
    }
    public unsafe struct VkPushDescriptorSetWithTemplateInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePushDescriptorSetWithTemplateInfoKhr;
        public void* pNext;
        public VkDescriptorUpdateTemplate descriptorUpdateTemplate;
        public VkPipelineLayout layout;
        public uint set;
        public void* pData;
        public VkPushDescriptorSetWithTemplateInfoKHR(VkStructureType sType, void* pNext, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.descriptorUpdateTemplate = descriptorUpdateTemplate;
            this.layout = layout;
            this.set = set;
            this.pData = pData;
        }
    }
    public unsafe struct VkSetDescriptorBufferOffsetsInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeSetDescriptorBufferOffsetsInfoExt;
        public void* pNext;
        public VkShaderStageFlagBits stageFlags;
        public VkPipelineLayout layout;
        public uint firstSet;
        public uint setCount;
        public uint* pBufferIndices;
        public ulong* pOffsets;
        public VkSetDescriptorBufferOffsetsInfoEXT(VkStructureType sType, void* pNext, VkShaderStageFlagBits stageFlags, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stageFlags = stageFlags;
            this.layout = layout;
            this.firstSet = firstSet;
            this.setCount = setCount;
            this.pBufferIndices = pBufferIndices;
            this.pOffsets = pOffsets;
        }
    }
    public unsafe struct VkBindDescriptorBufferEmbeddedSamplersInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeBindDescriptorBufferEmbeddedSamplersInfoExt;
        public void* pNext;
        public VkShaderStageFlagBits stageFlags;
        public VkPipelineLayout layout;
        public uint set;
        public VkBindDescriptorBufferEmbeddedSamplersInfoEXT(VkStructureType sType, void* pNext, VkShaderStageFlagBits stageFlags, VkPipelineLayout layout, uint set)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stageFlags = stageFlags;
            this.layout = layout;
            this.set = set;
        }
    }
    public unsafe struct VkPhysicalDeviceCubicClampFeaturesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCubicClampFeaturesQcom;
        public void* pNext;
        public int cubicRangeClamp;
        public VkPhysicalDeviceCubicClampFeaturesQCOM(VkStructureType sType, void* pNext, int cubicRangeClamp)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.cubicRangeClamp = cubicRangeClamp;
        }
    }
    public unsafe struct VkPhysicalDeviceYcbcrDegammaFeaturesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceYcbcrDegammaFeaturesQcom;
        public void* pNext;
        public int ycbcrDegamma;
        public VkPhysicalDeviceYcbcrDegammaFeaturesQCOM(VkStructureType sType, void* pNext, int ycbcrDegamma)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.ycbcrDegamma = ycbcrDegamma;
        }
    }
    public unsafe struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerYcbcrConversionYcbcrDegammaCreateInfoQcom;
        public void* pNext;
        public int enableYDegamma;
        public int enableCbCrDegamma;
        public VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM(VkStructureType sType, void* pNext, int enableYDegamma, int enableCbCrDegamma)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.enableYDegamma = enableYDegamma;
            this.enableCbCrDegamma = enableCbCrDegamma;
        }
    }
    public unsafe struct VkPhysicalDeviceCubicWeightsFeaturesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCubicWeightsFeaturesQcom;
        public void* pNext;
        public int selectableCubicWeights;
        public VkPhysicalDeviceCubicWeightsFeaturesQCOM(VkStructureType sType, void* pNext, int selectableCubicWeights)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.selectableCubicWeights = selectableCubicWeights;
        }
    }
    public unsafe struct VkSamplerCubicWeightsCreateInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerCubicWeightsCreateInfoQcom;
        public void* pNext;
        public VkCubicFilterWeightsQCOM cubicWeights;
        public VkSamplerCubicWeightsCreateInfoQCOM(VkStructureType sType, void* pNext, VkCubicFilterWeightsQCOM cubicWeights)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.cubicWeights = cubicWeights;
        }
    }
    public unsafe struct VkBlitImageCubicWeightsInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeBlitImageCubicWeightsInfoQcom;
        public void* pNext;
        public VkCubicFilterWeightsQCOM cubicWeights;
        public VkBlitImageCubicWeightsInfoQCOM(VkStructureType sType, void* pNext, VkCubicFilterWeightsQCOM cubicWeights)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.cubicWeights = cubicWeights;
        }
    }
    public unsafe struct VkPhysicalDeviceImageProcessing2FeaturesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageProcessing2FeaturesQcom;
        public void* pNext;
        public int textureBlockMatch2;
        public VkPhysicalDeviceImageProcessing2FeaturesQCOM(VkStructureType sType, void* pNext, int textureBlockMatch2)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.textureBlockMatch2 = textureBlockMatch2;
        }
    }
    public unsafe struct VkPhysicalDeviceImageProcessing2PropertiesQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageProcessing2PropertiesQcom;
        public void* pNext;
        public VkExtent2D maxBlockMatchWindow;
        public VkPhysicalDeviceImageProcessing2PropertiesQCOM(VkStructureType sType, void* pNext, VkExtent2D maxBlockMatchWindow)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maxBlockMatchWindow = maxBlockMatchWindow;
        }
    }
    public unsafe struct VkSamplerBlockMatchWindowCreateInfoQCOM
    {
        public VkStructureType sType = VkStructureType.StructureTypeSamplerBlockMatchWindowCreateInfoQcom;
        public void* pNext;
        public VkExtent2D windowExtent;
        public VkBlockMatchWindowCompareModeQCOM windowCompareMode;
        public VkSamplerBlockMatchWindowCreateInfoQCOM(VkStructureType sType, void* pNext, VkExtent2D windowExtent, VkBlockMatchWindowCompareModeQCOM windowCompareMode)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.windowExtent = windowExtent;
            this.windowCompareMode = windowCompareMode;
        }
    }
    public unsafe struct VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDescriptorPoolOverallocationFeaturesNv;
        public void* pNext;
        public int descriptorPoolOverallocation;
        public VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV(VkStructureType sType, void* pNext, int descriptorPoolOverallocation)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.descriptorPoolOverallocation = descriptorPoolOverallocation;
        }
    }
    public unsafe struct VkPhysicalDeviceLayeredDriverPropertiesMSFT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceLayeredDriverPropertiesMsft;
        public void* pNext;
        public VkLayeredDriverUnderlyingApiMSFT underlyingAPI;
        public VkPhysicalDeviceLayeredDriverPropertiesMSFT(VkStructureType sType, void* pNext, VkLayeredDriverUnderlyingApiMSFT underlyingAPI)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.underlyingAPI = underlyingAPI;
        }
    }
    public unsafe struct VkPhysicalDevicePerStageDescriptorSetFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDevicePerStageDescriptorSetFeaturesNv;
        public void* pNext;
        public int perStageDescriptorSet;
        public int dynamicPipelineLayout;
        public VkPhysicalDevicePerStageDescriptorSetFeaturesNV(VkStructureType sType, void* pNext, int perStageDescriptorSet, int dynamicPipelineLayout)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.perStageDescriptorSet = perStageDescriptorSet;
            this.dynamicPipelineLayout = dynamicPipelineLayout;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalFormatResolveFeaturesANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalFormatResolveFeaturesAndroid;
        public void* pNext;
        public int externalFormatResolve;
        public VkPhysicalDeviceExternalFormatResolveFeaturesANDROID(VkStructureType sType, void* pNext, int externalFormatResolve)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.externalFormatResolve = externalFormatResolve;
        }
    }
    public unsafe struct VkPhysicalDeviceExternalFormatResolvePropertiesANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceExternalFormatResolvePropertiesAndroid;
        public void* pNext;
        public int nullColorAttachmentWithExternalFormatResolve;
        public VkChromaLocation externalFormatResolveChromaOffsetX;
        public VkChromaLocation externalFormatResolveChromaOffsetY;
        public VkPhysicalDeviceExternalFormatResolvePropertiesANDROID(VkStructureType sType, void* pNext, int nullColorAttachmentWithExternalFormatResolve, VkChromaLocation externalFormatResolveChromaOffsetX, VkChromaLocation externalFormatResolveChromaOffsetY)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.nullColorAttachmentWithExternalFormatResolve = nullColorAttachmentWithExternalFormatResolve;
            this.externalFormatResolveChromaOffsetX = externalFormatResolveChromaOffsetX;
            this.externalFormatResolveChromaOffsetY = externalFormatResolveChromaOffsetY;
        }
    }
    public unsafe struct VkAndroidHardwareBufferFormatResolvePropertiesANDROID
    {
        public VkStructureType sType = VkStructureType.StructureTypeAndroidHardwareBufferFormatResolvePropertiesAndroid;
        public void* pNext;
        public VkFormat colorAttachmentFormat;
        public VkAndroidHardwareBufferFormatResolvePropertiesANDROID(VkStructureType sType, void* pNext, VkFormat colorAttachmentFormat)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.colorAttachmentFormat = colorAttachmentFormat;
        }
    }
    public unsafe struct VkLatencySleepModeInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeLatencySleepModeInfoNv;
        public void* pNext;
        public int lowLatencyMode;
        public int lowLatencyBoost;
        public uint minimumIntervalUs;
        public VkLatencySleepModeInfoNV(VkStructureType sType, void* pNext, int lowLatencyMode, int lowLatencyBoost, uint minimumIntervalUs)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.lowLatencyMode = lowLatencyMode;
            this.lowLatencyBoost = lowLatencyBoost;
            this.minimumIntervalUs = minimumIntervalUs;
        }
    }
    public unsafe struct VkLatencySleepInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeLatencySleepInfoNv;
        public void* pNext;
        public VkSemaphore signalSemaphore;
        public ulong value;
        public VkLatencySleepInfoNV(VkStructureType sType, void* pNext, VkSemaphore signalSemaphore, ulong value)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.signalSemaphore = signalSemaphore;
            this.value = value;
        }
    }
    public unsafe struct VkSetLatencyMarkerInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeSetLatencyMarkerInfoNv;
        public void* pNext;
        public ulong presentID;
        public VkLatencyMarkerNV marker;
        public VkSetLatencyMarkerInfoNV(VkStructureType sType, void* pNext, ulong presentID, VkLatencyMarkerNV marker)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentID = presentID;
            this.marker = marker;
        }
    }
    public unsafe struct VkGetLatencyMarkerInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeGetLatencyMarkerInfoNv;
        public void* pNext;
        public uint timingCount;
        public VkLatencyTimingsFrameReportNV* pTimings;
        public VkGetLatencyMarkerInfoNV(VkStructureType sType, void* pNext, uint timingCount, VkLatencyTimingsFrameReportNV* pTimings)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.timingCount = timingCount;
            this.pTimings = pTimings;
        }
    }
    public unsafe struct VkLatencyTimingsFrameReportNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeLatencyTimingsFrameReportNv;
        public void* pNext;
        public ulong presentID;
        public ulong inputSampleTimeUs;
        public ulong simStartTimeUs;
        public ulong simEndTimeUs;
        public ulong renderSubmitStartTimeUs;
        public ulong renderSubmitEndTimeUs;
        public ulong presentStartTimeUs;
        public ulong presentEndTimeUs;
        public ulong driverStartTimeUs;
        public ulong driverEndTimeUs;
        public ulong osRenderQueueStartTimeUs;
        public ulong osRenderQueueEndTimeUs;
        public ulong gpuRenderStartTimeUs;
        public ulong gpuRenderEndTimeUs;
        public VkLatencyTimingsFrameReportNV(VkStructureType sType, void* pNext, ulong presentID, ulong inputSampleTimeUs, ulong simStartTimeUs, ulong simEndTimeUs, ulong renderSubmitStartTimeUs, ulong renderSubmitEndTimeUs, ulong presentStartTimeUs, ulong presentEndTimeUs, ulong driverStartTimeUs, ulong driverEndTimeUs, ulong osRenderQueueStartTimeUs, ulong osRenderQueueEndTimeUs, ulong gpuRenderStartTimeUs, ulong gpuRenderEndTimeUs)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentID = presentID;
            this.inputSampleTimeUs = inputSampleTimeUs;
            this.simStartTimeUs = simStartTimeUs;
            this.simEndTimeUs = simEndTimeUs;
            this.renderSubmitStartTimeUs = renderSubmitStartTimeUs;
            this.renderSubmitEndTimeUs = renderSubmitEndTimeUs;
            this.presentStartTimeUs = presentStartTimeUs;
            this.presentEndTimeUs = presentEndTimeUs;
            this.driverStartTimeUs = driverStartTimeUs;
            this.driverEndTimeUs = driverEndTimeUs;
            this.osRenderQueueStartTimeUs = osRenderQueueStartTimeUs;
            this.osRenderQueueEndTimeUs = osRenderQueueEndTimeUs;
            this.gpuRenderStartTimeUs = gpuRenderStartTimeUs;
            this.gpuRenderEndTimeUs = gpuRenderEndTimeUs;
        }
    }
    public unsafe struct VkOutOfBandQueueTypeInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeOutOfBandQueueTypeInfoNv;
        public void* pNext;
        public VkOutOfBandQueueTypeNV queueType;
        public VkOutOfBandQueueTypeInfoNV(VkStructureType sType, void* pNext, VkOutOfBandQueueTypeNV queueType)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.queueType = queueType;
        }
    }
    public unsafe struct VkLatencySubmissionPresentIdNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeLatencySubmissionPresentIdNv;
        public void* pNext;
        public ulong presentID;
        public VkLatencySubmissionPresentIdNV(VkStructureType sType, void* pNext, ulong presentID)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentID = presentID;
        }
    }
    public unsafe struct VkSwapchainLatencyCreateInfoNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeSwapchainLatencyCreateInfoNv;
        public void* pNext;
        public int latencyModeEnable;
        public VkSwapchainLatencyCreateInfoNV(VkStructureType sType, void* pNext, int latencyModeEnable)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.latencyModeEnable = latencyModeEnable;
        }
    }
    public unsafe struct VkLatencySurfaceCapabilitiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypeLatencySurfaceCapabilitiesNv;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
        public VkLatencySurfaceCapabilitiesNV(VkStructureType sType, void* pNext, uint presentModeCount, VkPresentModeKHR* pPresentModes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.presentModeCount = presentModeCount;
            this.pPresentModes = pPresentModes;
        }
    }
    public unsafe struct VkPhysicalDeviceCudaKernelLaunchFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCudaKernelLaunchFeaturesNv;
        public void* pNext;
        public int cudaKernelLaunchFeatures;
        public VkPhysicalDeviceCudaKernelLaunchFeaturesNV(VkStructureType sType, void* pNext, int cudaKernelLaunchFeatures)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.cudaKernelLaunchFeatures = cudaKernelLaunchFeatures;
        }
    }
    public unsafe struct VkPhysicalDeviceCudaKernelLaunchPropertiesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceCudaKernelLaunchPropertiesNv;
        public void* pNext;
        public uint computeCapabilityMinor;
        public uint computeCapabilityMajor;
        public VkPhysicalDeviceCudaKernelLaunchPropertiesNV(VkStructureType sType, void* pNext, uint computeCapabilityMinor, uint computeCapabilityMajor)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.computeCapabilityMinor = computeCapabilityMinor;
            this.computeCapabilityMajor = computeCapabilityMajor;
        }
    }
    public unsafe struct VkDeviceQueueShaderCoreControlCreateInfoARM
    {
        public VkStructureType sType = VkStructureType.StructureTypeDeviceQueueShaderCoreControlCreateInfoArm;
        public void* pNext;
        public uint shaderCoreCount;
        public VkDeviceQueueShaderCoreControlCreateInfoARM(VkStructureType sType, void* pNext, uint shaderCoreCount)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderCoreCount = shaderCoreCount;
        }
    }
    public unsafe struct VkPhysicalDeviceSchedulingControlsFeaturesARM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSchedulingControlsFeaturesArm;
        public void* pNext;
        public int schedulingControls;
        public VkPhysicalDeviceSchedulingControlsFeaturesARM(VkStructureType sType, void* pNext, int schedulingControls)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.schedulingControls = schedulingControls;
        }
    }
    public unsafe struct VkPhysicalDeviceSchedulingControlsPropertiesARM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceSchedulingControlsPropertiesArm;
        public void* pNext;
        public VkPhysicalDeviceSchedulingControlsFlagBitsARM schedulingControlsFlags;
        public VkPhysicalDeviceSchedulingControlsPropertiesARM(VkStructureType sType, void* pNext, VkPhysicalDeviceSchedulingControlsFlagBitsARM schedulingControlsFlags)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.schedulingControlsFlags = schedulingControlsFlags;
        }
    }
    public unsafe struct VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRelaxedLineRasterizationFeaturesImg;
        public void* pNext;
        public int relaxedLineRasterization;
        public VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG(VkStructureType sType, void* pNext, int relaxedLineRasterization)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.relaxedLineRasterization = relaxedLineRasterization;
        }
    }
    public unsafe struct VkPhysicalDeviceRenderPassStripedFeaturesARM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRenderPassStripedFeaturesArm;
        public void* pNext;
        public int renderPassStriped;
        public VkPhysicalDeviceRenderPassStripedFeaturesARM(VkStructureType sType, void* pNext, int renderPassStriped)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.renderPassStriped = renderPassStriped;
        }
    }
    public unsafe struct VkPhysicalDeviceRenderPassStripedPropertiesARM
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRenderPassStripedPropertiesArm;
        public void* pNext;
        public VkExtent2D renderPassStripeGranularity;
        public uint maxRenderPassStripes;
        public VkPhysicalDeviceRenderPassStripedPropertiesARM(VkStructureType sType, void* pNext, VkExtent2D renderPassStripeGranularity, uint maxRenderPassStripes)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.renderPassStripeGranularity = renderPassStripeGranularity;
            this.maxRenderPassStripes = maxRenderPassStripes;
        }
    }
    public unsafe struct VkRenderPassStripeInfoARM
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassStripeInfoArm;
        public void* pNext;
        public VkRect2D stripeArea;
        public VkRenderPassStripeInfoARM(VkStructureType sType, void* pNext, VkRect2D stripeArea)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stripeArea = stripeArea;
        }
    }
    public unsafe struct VkRenderPassStripeBeginInfoARM
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassStripeBeginInfoArm;
        public void* pNext;
        public uint stripeInfoCount;
        public VkRenderPassStripeInfoARM* pStripeInfos;
        public VkRenderPassStripeBeginInfoARM(VkStructureType sType, void* pNext, uint stripeInfoCount, VkRenderPassStripeInfoARM* pStripeInfos)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stripeInfoCount = stripeInfoCount;
            this.pStripeInfos = pStripeInfos;
        }
    }
    public unsafe struct VkRenderPassStripeSubmitInfoARM
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderPassStripeSubmitInfoArm;
        public void* pNext;
        public uint stripeSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pStripeSemaphoreInfos;
        public VkRenderPassStripeSubmitInfoARM(VkStructureType sType, void* pNext, uint stripeSemaphoreInfoCount, VkSemaphoreSubmitInfo* pStripeSemaphoreInfos)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.stripeSemaphoreInfoCount = stripeSemaphoreInfoCount;
            this.pStripeSemaphoreInfos = pStripeSemaphoreInfos;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderMaximalReconvergenceFeaturesKhr;
        public void* pNext;
        public int shaderMaximalReconvergence;
        public VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR(VkStructureType sType, void* pNext, int shaderMaximalReconvergence)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderMaximalReconvergence = shaderMaximalReconvergence;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderSubgroupRotateFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderSubgroupRotateFeaturesKhr;
        public void* pNext;
        public int shaderSubgroupRotate;
        public int shaderSubgroupRotateClustered;
        public VkPhysicalDeviceShaderSubgroupRotateFeaturesKHR(VkStructureType sType, void* pNext, int shaderSubgroupRotate, int shaderSubgroupRotateClustered)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderSubgroupRotate = shaderSubgroupRotate;
            this.shaderSubgroupRotateClustered = shaderSubgroupRotateClustered;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderExpectAssumeFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderExpectAssumeFeaturesKhr;
        public void* pNext;
        public int shaderExpectAssume;
        public VkPhysicalDeviceShaderExpectAssumeFeaturesKHR(VkStructureType sType, void* pNext, int shaderExpectAssume)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderExpectAssume = shaderExpectAssume;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderFloatControls2FeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderFloatControls2FeaturesKhr;
        public void* pNext;
        public int shaderFloatControls2;
        public VkPhysicalDeviceShaderFloatControls2FeaturesKHR(VkStructureType sType, void* pNext, int shaderFloatControls2)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderFloatControls2 = shaderFloatControls2;
        }
    }
    public unsafe struct VkPhysicalDeviceDynamicRenderingLocalReadFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceDynamicRenderingLocalReadFeaturesKhr;
        public void* pNext;
        public int dynamicRenderingLocalRead;
        public VkPhysicalDeviceDynamicRenderingLocalReadFeaturesKHR(VkStructureType sType, void* pNext, int dynamicRenderingLocalRead)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.dynamicRenderingLocalRead = dynamicRenderingLocalRead;
        }
    }
    public unsafe struct VkRenderingAttachmentLocationInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderingAttachmentLocationInfoKhr;
        public void* pNext;
        public uint colorAttachmentCount;
        public uint* pColorAttachmentLocations;
        public VkRenderingAttachmentLocationInfoKHR(VkStructureType sType, void* pNext, uint colorAttachmentCount, uint* pColorAttachmentLocations)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.colorAttachmentCount = colorAttachmentCount;
            this.pColorAttachmentLocations = pColorAttachmentLocations;
        }
    }
    public unsafe struct VkRenderingInputAttachmentIndexInfoKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypeRenderingInputAttachmentIndexInfoKhr;
        public void* pNext;
        public uint colorAttachmentCount;
        public uint* pColorAttachmentInputIndices;
        public uint* pDepthInputAttachmentIndex;
        public uint* pStencilInputAttachmentIndex;
        public VkRenderingInputAttachmentIndexInfoKHR(VkStructureType sType, void* pNext, uint colorAttachmentCount, uint* pColorAttachmentInputIndices, uint* pDepthInputAttachmentIndex, uint* pStencilInputAttachmentIndex)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.colorAttachmentCount = colorAttachmentCount;
            this.pColorAttachmentInputIndices = pColorAttachmentInputIndices;
            this.pDepthInputAttachmentIndex = pDepthInputAttachmentIndex;
            this.pStencilInputAttachmentIndex = pStencilInputAttachmentIndex;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderQuadControlFeaturesKHR
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderQuadControlFeaturesKhr;
        public void* pNext;
        public int shaderQuadControl;
        public VkPhysicalDeviceShaderQuadControlFeaturesKHR(VkStructureType sType, void* pNext, int shaderQuadControl)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderQuadControl = shaderQuadControl;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderAtomicFloat16VectorFeaturesNv;
        public void* pNext;
        public int shaderFloat16VectorAtomics;
        public VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV(VkStructureType sType, void* pNext, int shaderFloat16VectorAtomics)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderFloat16VectorAtomics = shaderFloat16VectorAtomics;
        }
    }
    public unsafe struct VkPhysicalDeviceMapMemoryPlacedFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMapMemoryPlacedFeaturesExt;
        public void* pNext;
        public int memoryMapPlaced;
        public int memoryMapRangePlaced;
        public int memoryUnmapReserve;
        public VkPhysicalDeviceMapMemoryPlacedFeaturesEXT(VkStructureType sType, void* pNext, int memoryMapPlaced, int memoryMapRangePlaced, int memoryUnmapReserve)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.memoryMapPlaced = memoryMapPlaced;
            this.memoryMapRangePlaced = memoryMapRangePlaced;
            this.memoryUnmapReserve = memoryUnmapReserve;
        }
    }
    public unsafe struct VkPhysicalDeviceMapMemoryPlacedPropertiesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceMapMemoryPlacedPropertiesExt;
        public void* pNext;
        public ulong minPlacedMemoryMapAlignment;
        public VkPhysicalDeviceMapMemoryPlacedPropertiesEXT(VkStructureType sType, void* pNext, ulong minPlacedMemoryMapAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.minPlacedMemoryMapAlignment = minPlacedMemoryMapAlignment;
        }
    }
    public unsafe struct VkMemoryMapPlacedInfoEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypeMemoryMapPlacedInfoExt;
        public void* pNext;
        public void* pPlacedAddress;
        public VkMemoryMapPlacedInfoEXT(VkStructureType sType, void* pNext, void* pPlacedAddress)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.pPlacedAddress = pPlacedAddress;
        }
    }
    public unsafe struct VkPhysicalDeviceRawAccessChainsFeaturesNV
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceRawAccessChainsFeaturesNv;
        public void* pNext;
        public int shaderRawAccessChains;
        public VkPhysicalDeviceRawAccessChainsFeaturesNV(VkStructureType sType, void* pNext, int shaderRawAccessChains)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderRawAccessChains = shaderRawAccessChains;
        }
    }
    public unsafe struct VkPhysicalDeviceImageAlignmentControlFeaturesMESA
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageAlignmentControlFeaturesMesa;
        public void* pNext;
        public int imageAlignmentControl;
        public VkPhysicalDeviceImageAlignmentControlFeaturesMESA(VkStructureType sType, void* pNext, int imageAlignmentControl)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.imageAlignmentControl = imageAlignmentControl;
        }
    }
    public unsafe struct VkPhysicalDeviceImageAlignmentControlPropertiesMESA
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceImageAlignmentControlPropertiesMesa;
        public void* pNext;
        public uint supportedImageAlignmentMask;
        public VkPhysicalDeviceImageAlignmentControlPropertiesMESA(VkStructureType sType, void* pNext, uint supportedImageAlignmentMask)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.supportedImageAlignmentMask = supportedImageAlignmentMask;
        }
    }
    public unsafe struct VkImageAlignmentControlCreateInfoMESA
    {
        public VkStructureType sType = VkStructureType.StructureTypeImageAlignmentControlCreateInfoMesa;
        public void* pNext;
        public uint maximumRequestedAlignment;
        public VkImageAlignmentControlCreateInfoMESA(VkStructureType sType, void* pNext, uint maximumRequestedAlignment)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.maximumRequestedAlignment = maximumRequestedAlignment;
        }
    }
    public unsafe struct VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT
    {
        public VkStructureType sType = VkStructureType.StructureTypePhysicalDeviceShaderReplicatedCompositesFeaturesExt;
        public void* pNext;
        public int shaderReplicatedComposites;
        public VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT(VkStructureType sType, void* pNext, int shaderReplicatedComposites)
        {
            this.sType = sType;
            this.pNext = pNext;
            this.shaderReplicatedComposites = shaderReplicatedComposites;
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}