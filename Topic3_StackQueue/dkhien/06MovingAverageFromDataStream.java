// Time complexity: O(n)
// Space complexity: O(n)

public class MovingAverage {
    int size;
    Queue<Integer> list = new LinkedList<>();

    /*
    * @param size: An integer
    */public MovingAverage(int size) {
        // do intialization if necessary
        this.size = size;
    }

    /*
     * @param val: An integer
     * @return:  
     */
    public double next(int val) {
        // write your code here
        list.add(val);
        while (list.size() > size) {
            list.remove();
        }
        double res = 0;
        for (int num : list) {
            res += num;
        }
        return res / list.size();
    }
}