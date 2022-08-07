<script>
  import axios from "axios";
  import { Button } from 'sveltestrap';

  let activities = [];
  axios.get('http://localhost:5000/api/activities').then(response =>{
    activities = response.data;
    console.log(response.data)
  }, [])
</script>

<main>
  <Button color="primary">test</Button>
  <h1>Reactivities</h1>
  <ul>
    {#each activities as activity}
      <li>
        <p>
          {activity.title}
        </p>
      </li>
    {/each}
  </ul>
</main>
