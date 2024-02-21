// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2022 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX)
	#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks {
	public static partial class SteamUGC {
		/// <summary>
		/// <para> Query UGC associated with a user. Creator app id or consumer app id must be valid and be set to the current running app. unPage should start at 1.</para>
		/// </summary>
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) {
			InteropHelp.TestIfAvailableClient();
			return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryUserUGCRequest(CSteamAPIContext.GetSteamUGC(), unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage);
		}

		/// <summary>
		/// <para> Query for all matching UGC. Creator app id or consumer app id must be valid and be set to the current running app. unPage should start at 1.</para>
		/// </summary>
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) {
			InteropHelp.TestIfAvailableClient();
			return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryAllUGCRequestPage(CSteamAPIContext.GetSteamUGC(), eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage);
		}

		/// <summary>
		/// <para> Query for all matching UGC using the new deep paging interface. Creator app id or consumer app id must be valid and be set to the current running app. pchCursor should be set to NULL or "*" to get the first result set.</para>
		/// </summary>
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor = null) {
			InteropHelp.TestIfAvailableClient();
			using (var pchCursor2 = new InteropHelp.UTF8StringHandle(pchCursor)) {
				return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryAllUGCRequestCursor(CSteamAPIContext.GetSteamUGC(), eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, pchCursor2);
			}
		}

		/// <summary>
		/// <para> Query for the details of the given published file ids (the RequestUGCDetails call is deprecated and replaced with this)</para>
		/// </summary>
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) {
			InteropHelp.TestIfAvailableClient();
			return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryUGCDetailsRequest(CSteamAPIContext.GetSteamUGC(), pvecPublishedFileID, unNumPublishedFileIDs);
		}

		/// <summary>
		/// <para> Send the query to Steam</para>
		/// </summary>
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SendQueryUGCRequest(CSteamAPIContext.GetSteamUGC(), handle);
		}

		/// <summary>
		/// <para> Retrieve an individual result after receiving the callback for querying UGC</para>
		/// </summary>
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCResult(CSteamAPIContext.GetSteamUGC(), handle, index, out pDetails);
		}

		public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCNumTags(CSteamAPIContext.GetSteamUGC(), handle, index);
		}

		public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchValue2 = Marshal.AllocHGlobal((int)cchValueSize);
			bool ret = NativeMethods.ISteamUGC_GetQueryUGCTag(CSteamAPIContext.GetSteamUGC(), handle, index, indexTag, pchValue2, cchValueSize);
			pchValue = ret ? InteropHelp.PtrToStringUTF8(pchValue2) : null;
			Marshal.FreeHGlobal(pchValue2);
			return ret;
		}

		public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchValue2 = Marshal.AllocHGlobal((int)cchValueSize);
			bool ret = NativeMethods.ISteamUGC_GetQueryUGCTagDisplayName(CSteamAPIContext.GetSteamUGC(), handle, index, indexTag, pchValue2, cchValueSize);
			pchValue = ret ? InteropHelp.PtrToStringUTF8(pchValue2) : null;
			Marshal.FreeHGlobal(pchValue2);
			return ret;
		}

		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchURL2 = Marshal.AllocHGlobal((int)cchURLSize);
			bool ret = NativeMethods.ISteamUGC_GetQueryUGCPreviewURL(CSteamAPIContext.GetSteamUGC(), handle, index, pchURL2, cchURLSize);
			pchURL = ret ? InteropHelp.PtrToStringUTF8(pchURL2) : null;
			Marshal.FreeHGlobal(pchURL2);
			return ret;
		}

		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchMetadata2 = Marshal.AllocHGlobal((int)cchMetadatasize);
			bool ret = NativeMethods.ISteamUGC_GetQueryUGCMetadata(CSteamAPIContext.GetSteamUGC(), handle, index, pchMetadata2, cchMetadatasize);
			pchMetadata = ret ? InteropHelp.PtrToStringUTF8(pchMetadata2) : null;
			Marshal.FreeHGlobal(pchMetadata2);
			return ret;
		}

		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCChildren(CSteamAPIContext.GetSteamUGC(), handle, index, pvecPublishedFileID, cMaxEntries);
		}

		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCStatistic(CSteamAPIContext.GetSteamUGC(), handle, index, eStatType, out pStatValue);
		}

		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCNumAdditionalPreviews(CSteamAPIContext.GetSteamUGC(), handle, index);
		}

		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchURLOrVideoID2 = Marshal.AllocHGlobal((int)cchURLSize);
			IntPtr pchOriginalFileName2 = Marshal.AllocHGlobal((int)cchOriginalFileNameSize);
			bool ret = NativeMethods.ISteamUGC_GetQueryUGCAdditionalPreview(CSteamAPIContext.GetSteamUGC(), handle, index, previewIndex, pchURLOrVideoID2, cchURLSize, pchOriginalFileName2, cchOriginalFileNameSize, out pPreviewType);
			pchURLOrVideoID = ret ? InteropHelp.PtrToStringUTF8(pchURLOrVideoID2) : null;
			Marshal.FreeHGlobal(pchURLOrVideoID2);
			pchOriginalFileName = ret ? InteropHelp.PtrToStringUTF8(pchOriginalFileName2) : null;
			Marshal.FreeHGlobal(pchOriginalFileName2);
			return ret;
		}

		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCNumKeyValueTags(CSteamAPIContext.GetSteamUGC(), handle, index);
		}

		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchKey2 = Marshal.AllocHGlobal((int)cchKeySize);
			IntPtr pchValue2 = Marshal.AllocHGlobal((int)cchValueSize);
			bool ret = NativeMethods.ISteamUGC_GetQueryUGCKeyValueTag(CSteamAPIContext.GetSteamUGC(), handle, index, keyValueTagIndex, pchKey2, cchKeySize, pchValue2, cchValueSize);
			pchKey = ret ? InteropHelp.PtrToStringUTF8(pchKey2) : null;
			Marshal.FreeHGlobal(pchKey2);
			pchValue = ret ? InteropHelp.PtrToStringUTF8(pchValue2) : null;
			Marshal.FreeHGlobal(pchValue2);
			return ret;
		}

		/// <summary>
		/// <para> Return the first value matching the pchKey. Note that a key may map to multiple values.  Returns false if there was an error or no matching value was found.</para>
		/// </summary>
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchValue2 = Marshal.AllocHGlobal((int)cchValueSize);
			using (var pchKey2 = new InteropHelp.UTF8StringHandle(pchKey)) {
				bool ret = NativeMethods.ISteamUGC_GetQueryFirstUGCKeyValueTag(CSteamAPIContext.GetSteamUGC(), handle, index, pchKey2, pchValue2, cchValueSize);
				pchValue = ret ? InteropHelp.PtrToStringUTF8(pchValue2) : null;
				Marshal.FreeHGlobal(pchValue2);
				return ret;
			}
		}

		public static uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, out EUGCContentDescriptorID pvecDescriptors, uint cMaxEntries) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCContentDescriptors(CSteamAPIContext.GetSteamUGC(), handle, index, out pvecDescriptors, cMaxEntries);
		}

		/// <summary>
		/// <para> Release the request to free up memory, after retrieving results</para>
		/// </summary>
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_ReleaseQueryUGCRequest(CSteamAPIContext.GetSteamUGC(), handle);
		}

		/// <summary>
		/// <para> Options to set for querying UGC</para>
		/// </summary>
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) {
			InteropHelp.TestIfAvailableClient();
			using (var pTagName2 = new InteropHelp.UTF8StringHandle(pTagName)) {
				return NativeMethods.ISteamUGC_AddRequiredTag(CSteamAPIContext.GetSteamUGC(), handle, pTagName2);
			}
		}

		/// <summary>
		/// <para> match any of the tags in this group</para>
		/// </summary>
		public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, System.Collections.Generic.IList<string> pTagGroups) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_AddRequiredTagGroup(CSteamAPIContext.GetSteamUGC(), handle, new InteropHelp.SteamParamStringArray(pTagGroups));
		}

		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) {
			InteropHelp.TestIfAvailableClient();
			using (var pTagName2 = new InteropHelp.UTF8StringHandle(pTagName)) {
				return NativeMethods.ISteamUGC_AddExcludedTag(CSteamAPIContext.GetSteamUGC(), handle, pTagName2);
			}
		}

		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnOnlyIDs(CSteamAPIContext.GetSteamUGC(), handle, bReturnOnlyIDs);
		}

		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnKeyValueTags(CSteamAPIContext.GetSteamUGC(), handle, bReturnKeyValueTags);
		}

		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnLongDescription(CSteamAPIContext.GetSteamUGC(), handle, bReturnLongDescription);
		}

		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnMetadata(CSteamAPIContext.GetSteamUGC(), handle, bReturnMetadata);
		}

		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnChildren(CSteamAPIContext.GetSteamUGC(), handle, bReturnChildren);
		}

		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnAdditionalPreviews(CSteamAPIContext.GetSteamUGC(), handle, bReturnAdditionalPreviews);
		}

		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnTotalOnly(CSteamAPIContext.GetSteamUGC(), handle, bReturnTotalOnly);
		}

		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnPlaytimeStats(CSteamAPIContext.GetSteamUGC(), handle, unDays);
		}

		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) {
			InteropHelp.TestIfAvailableClient();
			using (var pchLanguage2 = new InteropHelp.UTF8StringHandle(pchLanguage)) {
				return NativeMethods.ISteamUGC_SetLanguage(CSteamAPIContext.GetSteamUGC(), handle, pchLanguage2);
			}
		}

		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetAllowCachedResponse(CSteamAPIContext.GetSteamUGC(), handle, unMaxAgeSeconds);
		}

		/// <summary>
		/// <para> Options only for querying user UGC</para>
		/// </summary>
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) {
			InteropHelp.TestIfAvailableClient();
			using (var pMatchCloudFileName2 = new InteropHelp.UTF8StringHandle(pMatchCloudFileName)) {
				return NativeMethods.ISteamUGC_SetCloudFileNameFilter(CSteamAPIContext.GetSteamUGC(), handle, pMatchCloudFileName2);
			}
		}

		/// <summary>
		/// <para> Options only for querying all UGC</para>
		/// </summary>
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetMatchAnyTag(CSteamAPIContext.GetSteamUGC(), handle, bMatchAnyTag);
		}

		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) {
			InteropHelp.TestIfAvailableClient();
			using (var pSearchText2 = new InteropHelp.UTF8StringHandle(pSearchText)) {
				return NativeMethods.ISteamUGC_SetSearchText(CSteamAPIContext.GetSteamUGC(), handle, pSearchText2);
			}
		}

		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetRankedByTrendDays(CSteamAPIContext.GetSteamUGC(), handle, unDays);
		}

		public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetTimeCreatedDateRange(CSteamAPIContext.GetSteamUGC(), handle, rtStart, rtEnd);
		}

		public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetTimeUpdatedDateRange(CSteamAPIContext.GetSteamUGC(), handle, rtStart, rtEnd);
		}

		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) {
			InteropHelp.TestIfAvailableClient();
			using (var pKey2 = new InteropHelp.UTF8StringHandle(pKey))
			using (var pValue2 = new InteropHelp.UTF8StringHandle(pValue)) {
				return NativeMethods.ISteamUGC_AddRequiredKeyValueTag(CSteamAPIContext.GetSteamUGC(), handle, pKey2, pValue2);
			}
		}

		/// <summary>
		/// <para> DEPRECATED - Use CreateQueryUGCDetailsRequest call above instead!</para>
		/// </summary>
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RequestUGCDetails(CSteamAPIContext.GetSteamUGC(), nPublishedFileID, unMaxAgeSeconds);
		}

		/// <summary>
		/// <para> Steam Workshop Creator API</para>
		/// <para> create new item for this app with no content attached yet</para>
		/// </summary>
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_CreateItem(CSteamAPIContext.GetSteamUGC(), nConsumerAppId, eFileType);
		}

		/// <summary>
		/// <para> start an UGC item update. Set changed properties before commiting update with CommitItemUpdate()</para>
		/// </summary>
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (UGCUpdateHandle_t)NativeMethods.ISteamUGC_StartItemUpdate(CSteamAPIContext.GetSteamUGC(), nConsumerAppId, nPublishedFileID);
		}

		/// <summary>
		/// <para> change the title of an UGC item</para>
		/// </summary>
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) {
			InteropHelp.TestIfAvailableClient();
			using (var pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle)) {
				return NativeMethods.ISteamUGC_SetItemTitle(CSteamAPIContext.GetSteamUGC(), handle, pchTitle2);
			}
		}

		/// <summary>
		/// <para> change the description of an UGC item</para>
		/// </summary>
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) {
			InteropHelp.TestIfAvailableClient();
			using (var pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription)) {
				return NativeMethods.ISteamUGC_SetItemDescription(CSteamAPIContext.GetSteamUGC(), handle, pchDescription2);
			}
		}

		/// <summary>
		/// <para> specify the language of the title or description that will be set</para>
		/// </summary>
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) {
			InteropHelp.TestIfAvailableClient();
			using (var pchLanguage2 = new InteropHelp.UTF8StringHandle(pchLanguage)) {
				return NativeMethods.ISteamUGC_SetItemUpdateLanguage(CSteamAPIContext.GetSteamUGC(), handle, pchLanguage2);
			}
		}

		/// <summary>
		/// <para> change the metadata of an UGC item (max = k_cchDeveloperMetadataMax)</para>
		/// </summary>
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) {
			InteropHelp.TestIfAvailableClient();
			using (var pchMetaData2 = new InteropHelp.UTF8StringHandle(pchMetaData)) {
				return NativeMethods.ISteamUGC_SetItemMetadata(CSteamAPIContext.GetSteamUGC(), handle, pchMetaData2);
			}
		}

		/// <summary>
		/// <para> change the visibility of an UGC item</para>
		/// </summary>
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetItemVisibility(CSteamAPIContext.GetSteamUGC(), handle, eVisibility);
		}

		/// <summary>
		/// <para> change the tags of an UGC item</para>
		/// </summary>
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, System.Collections.Generic.IList<string> pTags, bool bAllowAdminTags = false) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetItemTags(CSteamAPIContext.GetSteamUGC(), updateHandle, new InteropHelp.SteamParamStringArray(pTags), bAllowAdminTags);
		}

		/// <summary>
		/// <para> update item content from this local folder</para>
		/// </summary>
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) {
			InteropHelp.TestIfAvailableClient();
			using (var pszContentFolder2 = new InteropHelp.UTF8StringHandle(pszContentFolder)) {
				return NativeMethods.ISteamUGC_SetItemContent(CSteamAPIContext.GetSteamUGC(), handle, pszContentFolder2);
			}
		}

		/// <summary>
		/// <para>  change preview image file for this item. pszPreviewFile points to local image file, which must be under 1MB in size</para>
		/// </summary>
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) {
			InteropHelp.TestIfAvailableClient();
			using (var pszPreviewFile2 = new InteropHelp.UTF8StringHandle(pszPreviewFile)) {
				return NativeMethods.ISteamUGC_SetItemPreview(CSteamAPIContext.GetSteamUGC(), handle, pszPreviewFile2);
			}
		}

		/// <summary>
		/// <para>  use legacy upload for a single small file. The parameter to SetItemContent() should either be a directory with one file or the full path to the file.  The file must also be less than 10MB in size.</para>
		/// </summary>
		public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetAllowLegacyUpload(CSteamAPIContext.GetSteamUGC(), handle, bAllowLegacyUpload);
		}

		/// <summary>
		/// <para> remove all existing key-value tags (you can add new ones via the AddItemKeyValueTag function)</para>
		/// </summary>
		public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_RemoveAllItemKeyValueTags(CSteamAPIContext.GetSteamUGC(), handle);
		}

		/// <summary>
		/// <para> remove any existing key-value tags with the specified key</para>
		/// </summary>
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) {
			InteropHelp.TestIfAvailableClient();
			using (var pchKey2 = new InteropHelp.UTF8StringHandle(pchKey)) {
				return NativeMethods.ISteamUGC_RemoveItemKeyValueTags(CSteamAPIContext.GetSteamUGC(), handle, pchKey2);
			}
		}

		/// <summary>
		/// <para> add new key-value tags for the item. Note that there can be multiple values for a tag.</para>
		/// </summary>
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) {
			InteropHelp.TestIfAvailableClient();
			using (var pchKey2 = new InteropHelp.UTF8StringHandle(pchKey))
			using (var pchValue2 = new InteropHelp.UTF8StringHandle(pchValue)) {
				return NativeMethods.ISteamUGC_AddItemKeyValueTag(CSteamAPIContext.GetSteamUGC(), handle, pchKey2, pchValue2);
			}
		}

		/// <summary>
		/// <para>  add preview file for this item. pszPreviewFile points to local file, which must be under 1MB in size</para>
		/// </summary>
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) {
			InteropHelp.TestIfAvailableClient();
			using (var pszPreviewFile2 = new InteropHelp.UTF8StringHandle(pszPreviewFile)) {
				return NativeMethods.ISteamUGC_AddItemPreviewFile(CSteamAPIContext.GetSteamUGC(), handle, pszPreviewFile2, type);
			}
		}

		/// <summary>
		/// <para>  add preview video for this item</para>
		/// </summary>
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) {
			InteropHelp.TestIfAvailableClient();
			using (var pszVideoID2 = new InteropHelp.UTF8StringHandle(pszVideoID)) {
				return NativeMethods.ISteamUGC_AddItemPreviewVideo(CSteamAPIContext.GetSteamUGC(), handle, pszVideoID2);
			}
		}

		/// <summary>
		/// <para>  updates an existing preview file for this item. pszPreviewFile points to local file, which must be under 1MB in size</para>
		/// </summary>
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) {
			InteropHelp.TestIfAvailableClient();
			using (var pszPreviewFile2 = new InteropHelp.UTF8StringHandle(pszPreviewFile)) {
				return NativeMethods.ISteamUGC_UpdateItemPreviewFile(CSteamAPIContext.GetSteamUGC(), handle, index, pszPreviewFile2);
			}
		}

		/// <summary>
		/// <para>  updates an existing preview video for this item</para>
		/// </summary>
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) {
			InteropHelp.TestIfAvailableClient();
			using (var pszVideoID2 = new InteropHelp.UTF8StringHandle(pszVideoID)) {
				return NativeMethods.ISteamUGC_UpdateItemPreviewVideo(CSteamAPIContext.GetSteamUGC(), handle, index, pszVideoID2);
			}
		}

		/// <summary>
		/// <para> remove a preview by index starting at 0 (previews are sorted)</para>
		/// </summary>
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_RemoveItemPreview(CSteamAPIContext.GetSteamUGC(), handle, index);
		}

		public static bool AddContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_AddContentDescriptor(CSteamAPIContext.GetSteamUGC(), handle, descid);
		}

		public static bool RemoveContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_RemoveContentDescriptor(CSteamAPIContext.GetSteamUGC(), handle, descid);
		}

		/// <summary>
		/// <para> commit update process started with StartItemUpdate()</para>
		/// </summary>
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) {
			InteropHelp.TestIfAvailableClient();
			using (var pchChangeNote2 = new InteropHelp.UTF8StringHandle(pchChangeNote)) {
				return (SteamAPICall_t)NativeMethods.ISteamUGC_SubmitItemUpdate(CSteamAPIContext.GetSteamUGC(), handle, pchChangeNote2);
			}
		}

		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetItemUpdateProgress(CSteamAPIContext.GetSteamUGC(), handle, out punBytesProcessed, out punBytesTotal);
		}

		/// <summary>
		/// <para> Steam Workshop Consumer API</para>
		/// </summary>
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SetUserItemVote(CSteamAPIContext.GetSteamUGC(), nPublishedFileID, bVoteUp);
		}

		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_GetUserItemVote(CSteamAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_AddItemToFavorites(CSteamAPIContext.GetSteamUGC(), nAppId, nPublishedFileID);
		}

		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RemoveItemFromFavorites(CSteamAPIContext.GetSteamUGC(), nAppId, nPublishedFileID);
		}

		/// <summary>
		/// <para> subscribe to this item, will be installed ASAP</para>
		/// </summary>
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SubscribeItem(CSteamAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		/// <summary>
		/// <para> unsubscribe from this item, will be uninstalled after game quits</para>
		/// </summary>
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_UnsubscribeItem(CSteamAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		/// <summary>
		/// <para> number of subscribed items</para>
		/// </summary>
		public static uint GetNumSubscribedItems() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetNumSubscribedItems(CSteamAPIContext.GetSteamUGC());
		}

		/// <summary>
		/// <para> all subscribed item PublishFileIDs</para>
		/// </summary>
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetSubscribedItems(CSteamAPIContext.GetSteamUGC(), pvecPublishedFileID, cMaxEntries);
		}

		/// <summary>
		/// <para> get EItemState flags about item on this client</para>
		/// </summary>
		public static uint GetItemState(PublishedFileId_t nPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetItemState(CSteamAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		/// <summary>
		/// <para> get info about currently installed content on disc for items that have k_EItemStateInstalled set</para>
		/// <para> if k_EItemStateLegacyItem is set, pchFolder contains the path to the legacy file itself (not a folder)</para>
		/// </summary>
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchFolder2 = Marshal.AllocHGlobal((int)cchFolderSize);
			bool ret = NativeMethods.ISteamUGC_GetItemInstallInfo(CSteamAPIContext.GetSteamUGC(), nPublishedFileID, out punSizeOnDisk, pchFolder2, cchFolderSize, out punTimeStamp);
			pchFolder = ret ? InteropHelp.PtrToStringUTF8(pchFolder2) : null;
			Marshal.FreeHGlobal(pchFolder2);
			return ret;
		}

		/// <summary>
		/// <para> get info about pending update for items that have k_EItemStateNeedsUpdate set. punBytesTotal will be valid after download started once</para>
		/// </summary>
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetItemDownloadInfo(CSteamAPIContext.GetSteamUGC(), nPublishedFileID, out punBytesDownloaded, out punBytesTotal);
		}

		/// <summary>
		/// <para> download new or update already installed item. If function returns true, wait for DownloadItemResult_t. If the item is already installed,</para>
		/// <para> then files on disk should not be used until callback received. If item is not subscribed to, it will be cached for some time.</para>
		/// <para> If bHighPriority is set, any other item download will be suspended and this item downloaded ASAP.</para>
		/// </summary>
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_DownloadItem(CSteamAPIContext.GetSteamUGC(), nPublishedFileID, bHighPriority);
		}

		/// <summary>
		/// <para> game servers can set a specific workshop folder before issuing any UGC commands.</para>
		/// <para> This is helpful if you want to support multiple game servers running out of the same install folder</para>
		/// </summary>
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) {
			InteropHelp.TestIfAvailableClient();
			using (var pszFolder2 = new InteropHelp.UTF8StringHandle(pszFolder)) {
				return NativeMethods.ISteamUGC_BInitWorkshopForGameServer(CSteamAPIContext.GetSteamUGC(), unWorkshopDepotID, pszFolder2);
			}
		}

		/// <summary>
		/// <para> SuspendDownloads( true ) will suspend all workshop downloads until SuspendDownloads( false ) is called or the game ends</para>
		/// </summary>
		public static void SuspendDownloads(bool bSuspend) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUGC_SuspendDownloads(CSteamAPIContext.GetSteamUGC(), bSuspend);
		}

		/// <summary>
		/// <para> usage tracking</para>
		/// </summary>
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_StartPlaytimeTracking(CSteamAPIContext.GetSteamUGC(), pvecPublishedFileID, unNumPublishedFileIDs);
		}

		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_StopPlaytimeTracking(CSteamAPIContext.GetSteamUGC(), pvecPublishedFileID, unNumPublishedFileIDs);
		}

		public static SteamAPICall_t StopPlaytimeTrackingForAllItems() {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_StopPlaytimeTrackingForAllItems(CSteamAPIContext.GetSteamUGC());
		}

		/// <summary>
		/// <para> parent-child relationship or dependency management</para>
		/// </summary>
		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_AddDependency(CSteamAPIContext.GetSteamUGC(), nParentPublishedFileID, nChildPublishedFileID);
		}

		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RemoveDependency(CSteamAPIContext.GetSteamUGC(), nParentPublishedFileID, nChildPublishedFileID);
		}

		/// <summary>
		/// <para> add/remove app dependence/requirements (usually DLC)</para>
		/// </summary>
		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_AddAppDependency(CSteamAPIContext.GetSteamUGC(), nPublishedFileID, nAppID);
		}

		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RemoveAppDependency(CSteamAPIContext.GetSteamUGC(), nPublishedFileID, nAppID);
		}

		/// <summary>
		/// <para> request app dependencies. note that whatever callback you register for GetAppDependenciesResult_t may be called multiple times</para>
		/// <para> until all app dependencies have been returned</para>
		/// </summary>
		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_GetAppDependencies(CSteamAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		/// <summary>
		/// <para> delete the item without prompting the user</para>
		/// </summary>
		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_DeleteItem(CSteamAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		/// <summary>
		/// <para> Show the app's latest Workshop EULA to the user in an overlay window, where they can accept it or not</para>
		/// </summary>
		public static bool ShowWorkshopEULA() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_ShowWorkshopEULA(CSteamAPIContext.GetSteamUGC());
		}

		/// <summary>
		/// <para> Retrieve information related to the user's acceptance or not of the app's specific Workshop EULA</para>
		/// </summary>
		public static SteamAPICall_t GetWorkshopEULAStatus() {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_GetWorkshopEULAStatus(CSteamAPIContext.GetSteamUGC());
		}

		/// <summary>
		/// <para> Return the user's community content descriptor preferences</para>
		/// </summary>
		public static uint GetUserContentDescriptorPreferences(out EUGCContentDescriptorID pvecDescriptors, uint cMaxEntries) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetUserContentDescriptorPreferences(CSteamAPIContext.GetSteamUGC(), out pvecDescriptors, cMaxEntries);
		}
	}
}

#endif // !DISABLESTEAMWORKS
