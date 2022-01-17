package main

import "fmt"

func main() {
	//Test Inputs
	test1 :=  "abcabcbb"
	test2 :=  "bbbbb"
	test3 :=  "pwwkew"
	test4 :=  "abcabcbhghgfaadvb"



	fmt.Println(lengthOfLongestSubstring(test1))
	fmt.Println(lengthOfLongestSubstring(test2))
	fmt.Println(lengthOfLongestSubstring(test3))
	fmt.Println(lengthOfLongestSubstring(test4))
}



//Solution
func lengthOfLongestSubstring(s string) int {
	//Treat the slice/array like a Queue
	var queue []string
	hv := 0 //hold value variable

	for _, value := range s {

		if exist, index := contains(queue, string(value)); exist {
			queue = queue[index+1:]
			queue = append(queue, string(value))
			continue
		}
		queue = append(queue, string(value))
		if len(queue) > hv  {
			hv = len(queue)
		}
	}
	return hv
}


//Since longest-substring doesnt have traditional inbuilt contains method this needs to be implemented as a helper
//Method checks if item exist in string array and also returns the index
func contains(s []string, searchItem string) (bool, int) {
	for i, value := range s {
		if value == searchItem {
			return true, i
		}
	}
	return false, -1
}
