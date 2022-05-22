# @param {String[]} strs
# @return {String[][]}
def group_anagrams(strs)
    arr = Array.new
    dict = Hash.new {|d,v| d[v] = []}
    
    strs.each do |s|
        dict[s.chars.sort.join] << s
    end
    
    dict.keys.sort.each do |index|
        arr << dict[index]
    end
    
    return arr
    
end

input = ["eat","tea","tan","ate","nat","bat"]

print group_anagrams(input)