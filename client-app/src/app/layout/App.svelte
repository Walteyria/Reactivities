<script>
  import axios from "axios";
  import NavBar from "./NavBar.svelte";

  let activities = [];
  axios.get('http://localhost:5000/api/activities').then(response =>{
    activities = response.data;
  }, [])
</script>

<main>
  <NavBar></NavBar>
  <ul >
    {#each activities as activity}
      <li>
        <p>
          {activity.title}
        </p>
      </li>
    {/each}
  </ul>
</main>
