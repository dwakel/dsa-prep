package main

import "fmt"


//https://leetcode.com/problems/median-of-two-sorted-arrays/submissions/

//Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
//The overall run time complexity should be O(log (m+n)).

func main() {
	//Test Data
	arr1 := []int{1,2}
	arr2 := []int{3,4}

	fmt.Println(findMedianSortedArrays(arr1, arr2))

}


func findMedianSortedArrays(nums1 []int, nums2 []int) float64 {
	sortedArr := mergeAndSort(nums1, nums2, []int{})
	length := len(sortedArr)

	if length % 2 == 0 {
		return float64(sortedArr[(length/2)-1] + sortedArr[(length/2)]) / 2
	}
	return float64(sortedArr[(length/2)])
}


func mergeAndSort(nums1 []int, nums2 []int, res []int) []int {
	//Stoping Logic
	if len(nums1) < 1 && len(nums2) < 1 {
		return res
	}
	if len(nums1) >= 1 && len(nums2) < 1 {
		res = append(res, nums1...)
		return res
	}
	if len(nums1) < 1 && len(nums2) >= 1 {
		res = append(res, nums2...)
		return res
	}

	//Sorting Logic
	if nums1[0] < nums2[0] {
		res = append(res, nums1[0])
		nums1 = nums1[1:]
		return mergeAndSort(nums1, nums2, res)
	} else {
		res = append(res, nums2[0])
		nums2 = nums2[1:]
		return mergeAndSort(nums1, nums2, res)
	}
}
