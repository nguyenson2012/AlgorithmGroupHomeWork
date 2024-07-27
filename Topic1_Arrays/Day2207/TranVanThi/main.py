# two sum

def hashMap(nums, target):
    numMap = dict()
    for i in range(len(nums)):
        flag = target - nums[i]
        if flag in numMap:
            return [numMap[flag], i]
        numMap[nums[i]] = i

    return []                


if __name__ == "__main__":
    nums = [2,7,11,15]
    target = 9
    n = len(nums)
    hashMap(nums=nums, target=target)