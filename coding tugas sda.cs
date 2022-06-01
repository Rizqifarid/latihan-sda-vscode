//dijkstra
public class shortestpath
{
    public int minDistance(int dist[], Boolean b[])
    {
        int min = integer.MAX_VALUE , index = -1 ;
        for ( int x = 0 ; x<5 ; x++)
        {
            if(b[x] == false && dist[x] <= min)
            {
                min = dist[x];
                index =x;

            }
            }
            return index ;
        

    
    }

    public void printGraph(int dist[] , int x)
    {
        system.out.println("distance from source to destination is ");
        for(int i = 0 , i < 5 , i++)

        {
            system.out.println(i+ "-----" + dist [i]);
        }
    }
    
    
    public void dijkstra(int graph[][] , int src)
    {
        int dist[] = new int[5];

        Boolean b = new Boolean [5] ;
        for(int i = o ; i<5 ; i++)
        {
            dist[i] = integer.MAX_VALUE ;
            B[I]    = FALSE ;

        }

        dist[0] = 0 ;
        for ( int count =0 ; count< 5 ; count ++)
        {
             int u = minDistance(dist,b);
             b[u]= true ; 
             for( iint x =0 ; x<5 ; x++)
             {
                 if(!b[x]&&graph[u][x]!=0 && dist[u]!=integer.MAX_VALUE && dist[u]+graph[u][x]< dist[x] )
                       {
                           dist[x] = dist[u]+ graph[u][x] ;
                       }
             }
             printGraph(dist,5);
        
        
        }


    }


    public static void main(string args[])
    {
        int graph [][] = new int [][] {{0,4,0,0,7},
                                      {4,0,1,2,0},
                                      {0,1,0,6,0},
                                      {0,2,6,0,0},
                                      {7,0,0,0,0}
                                      };

    shorestpath p = new shortestpath();
    p.dijkstra(graph , 0);
    }
}