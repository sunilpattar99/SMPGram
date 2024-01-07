import axios from "axios";
import { useEffect, useState } from "react"
import { Header, List } from "semantic-ui-react";

function App() {
  const [activities, setActivivties] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities').then(response => setActivivties(response.data))
  }, [])

  return (
    <div>
      <Header as='h2' icon='users' content='SMPgram'/>
      <List>
        {activities.map((activity: any) => (
          <List.Item key={activity.id}>
            {activity.title}
          </List.Item>
        ))}
      </List>
    </div>
    
  )
}

export default App
