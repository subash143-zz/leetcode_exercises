// 1418. Display Table of Food Orders in a Restaurant
// https://leetcode.com/problems/display-table-of-food-orders-in-a-restaurant/


public class Solution {
    public IList<IList<string>> DisplayTable(IList<IList<string>> orders) {
        var dict = new Dictionary<string, int>();
        var columns = new List<string>();
        var tables = new List<string>();
        IList<IList<string>> retVal = new List<IList<string>>();
        
        foreach(var item in orders){
            var key = $"{item[1]}_{item[2]}";
            if(!columns.Contains(item[2])){
                columns.Add(item[2]);
            }
            if(!tables.Contains(item[1])){
                tables.Add(item[1]);
            }
            
            if(!dict.ContainsKey(key)){
                dict[key] = 0;
            }
            dict[key] += 1;
        }
        
        columns.Sort(StringComparer.Ordinal);
        tables.Sort((a, b) => int.Parse(a).CompareTo(int.Parse(b)));
        
        var column_names = new List<string>();
        column_names.Add("Table");
        column_names.AddRange(columns);
        retVal.Add(column_names);
        
        foreach(var table in tables){
            var record = new List<string>();
            record.Add(table);
            foreach(var item in columns){
            var key = $"{table}_{item}";
                if(dict.ContainsKey(key)){
                    record.Add(dict[key].ToString());
                }
                else{
                    record.Add("0");
                }
            }
            retVal.Add(record);
        }
        
        return retVal;
        
        
    }
}