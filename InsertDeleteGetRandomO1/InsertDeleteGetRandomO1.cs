public class RandomizedSet 
{

       Dictionary<int, int> myDictionary ;
        System.Random rand;
   
    

    
    public RandomizedSet() {

        myDictionary = new Dictionary<int, int>();
       rand = new System.Random(); 

      
        
    }
    
    public bool Insert(int val) {

        if(myDictionary.ContainsKey(val)){
            return false;
        }

        myDictionary.Add(val,val);
        Debug.Log( myDictionary.Count);
        return true;
        
    }
    
    public bool Remove(int val) {

        return  myDictionary.Remove(val);
        
    }
    
    public int GetRandom() {

        List<int>keyList = new List<int>(myDictionary.Keys);
        return myDictionary[keyList[rand.Next(keyList.Count)]];

      
        
    }

    
}
